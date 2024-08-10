using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blogapi.Data;
using Blogapi.Models;
using Microsoft.EntityFrameworkCore;


namespace Blogapi.Controllers
{
    [Route("[controller]")]
    public class PostController : Controller
    {

        private readonly ApplicationDbContext _context;


        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<PostModel>>> Get()
        {
            return await _context.Postmodel.ToListAsync();
        }
        [HttpPost]

    }
}