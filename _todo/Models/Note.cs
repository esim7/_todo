using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace _todo.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [Display(Name = "Выполнить до:")]
        public DateTime DeadlineTime { get; set; }
        [Display(Name = "Название")]
        public string Title { get; set; }
        [Display(Name = "Текст")]
        public string Body { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}