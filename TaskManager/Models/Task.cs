using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsCompleted { get; set; }
        public TimeSpan Timer { get; set; }
        public TaskStatus Status { get; set; }
        public TaskCategory Category { get; set; }
        public TaskPriority Priority { get; set; }
    }

    public enum TaskStatus
    {
        InProgress,
        Completed,
        NotStarted,
        Late,
        Archived,
        Deleted
    }

    public enum TaskCategory
    {
        Work,
        Personal,
        Home,
        Health,
        Finance,
        Education,
        Shopping,
        Travel,
        Errands,
        Hobbies,
        Projects,
        Birthdays,
        Entertainment,
        Other
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Urgent
    }
}
