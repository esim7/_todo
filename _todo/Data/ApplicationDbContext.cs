using System;
using System.Collections.Generic;
using System.Text;
using _todo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _todo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
