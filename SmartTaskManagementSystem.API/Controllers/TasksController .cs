using Microsoft.AspNetCore.Mvc;
using SmartTaskManagementSystem.API.Data;
using SmartTaskManagementSystem.API.Models;

namespace SmartTaskManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            //get all tasks
            return Ok(_context.Tasks.ToList());
        }

        [HttpPost]
        public IActionResult CreateTask(TaskItem task)
        {
            //create task
            task.DueDate = task.DueDate.ToUniversalTime();
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Ok(task);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, TaskItem task)
        {
            //update task
            var existingTask = _context.Tasks.Find(id);
            if (existingTask == null)
            {
                return NotFound();
            }
            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.Status = task.Status;
            existingTask.Priority = task.Priority;
            existingTask.DueDate = task.DueDate.ToUniversalTime();
            _context.SaveChanges();
            return Ok(existingTask);
        }
    }
}