using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagementSystem.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EventManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EventController(ApplicationDbContext context){
        _context = context;
    }

    [HttpGet]
    public async Task< ActionResult<IEnumerable<EventModel>>> GetEvents(){
        return await _context.Event.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<EventModel>> GetEvent(int id)
    {
        var eventModel = await _context.Event.FindAsync(id);
        if (eventModel ==null)
        {
            return NotFound();
        }
        return eventModel;
    }
    [HttpPost]
    public async Task<ActionResult<EventModel>> PostEvent(EventModel eventModel)
    {
        _context.Event.Add(eventModel);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEvent), new {id = eventModel.EventId} , eventModel);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutEvent(int id , EventModel eventModel)
    {
        if (id != eventModel.EventId){
            return BadRequest();
        }
        _context.Entry(eventModel).State = EntityState.Modified;
        try {
            await _context.SaveChangesAsync();
        }
        catch(DbUpdateConcurrencyException)
        {
                throw;
        }
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEvent(int id )
    {
        
    }
}