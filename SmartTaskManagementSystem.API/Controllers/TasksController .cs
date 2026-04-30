using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SmartTaskManagementSystem.API.Data;
using SmartTaskManagementSystem.API.Models;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

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
            return Ok(_context.Tasks.ToList());
        }
        [HttpPost]
        public IActionResult CreateTask(TaskItem task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Ok(task);
        }
    }
}
