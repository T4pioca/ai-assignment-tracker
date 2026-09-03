namespace AssignmentTracker.Server.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Course { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
        public string? Category { get; set; }
        public bool isCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }
}
