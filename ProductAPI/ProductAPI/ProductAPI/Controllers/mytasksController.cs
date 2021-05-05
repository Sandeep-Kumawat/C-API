using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Infrastructure;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mytasksController : ControllerBase
    {
        private readonly TodoItemContext _context;

        public mytasksController(TodoItemContext context)
        {
            _context = context;
        }

        [HttpGet("items")]
        public List<TodoItem> getItems()
        {
            var result = from r in _context.todoItems select r;
            return result.ToList();
        }
        [HttpPost("items")]
        public TodoItem createItems(TodoItem item)
        {
            _context.todoItems.Add(item);
            _context.SaveChanges();
            return item;
        }
        [HttpPut("items/{id}")]
        public TodoItem updateItems(TodoItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
