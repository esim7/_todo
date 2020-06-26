using System;
using Microsoft.AspNetCore.Identity;

namespace _todo.Models
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}