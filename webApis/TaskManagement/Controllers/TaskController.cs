using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private static List<TaskModel>_task  = new List<TaskModel>{
            new TaskModel{Id=1 , Title="Get on the floor" , Description="live your life and stay on the floor"},
            new TaskModel{Id=2 , Title="Miami" , Description="Grab somebody Drinks little more"}
        };
        [HttpGet]
        public IActionResult GetAll(){
            if(_task.Count == 0){
                return NotFound();
            }
            return Ok(_task);
        }
        [HttpGet("{id}")]
        public IActionResult GetElementById(int id)
        {

            if (!ModelState.IsValid){
                return BadRequest();
            }
            var taskIdnew = _task.FirstOrDefault(item => item.Id == id);
            if (taskIdnew == null){
                return NotFound();
            }
            return Ok(taskIdnew);
        }
        [HttpPost]
        public IActionResult Create([FromBody]TaskModel task)
        {
            if (task == null){
                return BadRequest();
            }
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            var newTask = new TaskModel{

            Title = task.Title ,
            Description = task.Description
            };
            int newId = _task.Max(item => item.Id)+1;
            newTask.Id = newId;
            _task.Add(newTask);
            return CreatedAtAction(nameof(GetElementById) , new{id = newTask.Id} , newTask);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id , [FromBody] TaskModel updatedModel){
            if(updatedModel ==null ||  updatedModel.Id != id){
                return BadRequest();
            }
            var task = _task.FirstOrDefault(item => id ==item.Id);
            if(task == null){
                return NotFound();
            }
            task.Title = updatedModel.Title;
            task.Description = updatedModel.Description;
            return NoContent();
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id ){
            var task = _task.FirstOrDefault(item => item.Id == id);
            if (task ==null){
                return NotFound();
            }
            _task.Remove(task);
            return NoContent();
        }
    }
}


// ToDo : create update method and delete 