using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Infrastructure
{
    public class TodoItemContext : DbContext
    {
        public DbSet<TodoItem> todoItems { get; set; }
        public TodoItemContext (DbContextOptions<TodoItemContext> options) :base(options)
        {

        }
    }
}
