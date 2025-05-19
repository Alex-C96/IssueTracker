using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace IssueTracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;
        [StringLength(1000)]
        public string Description { get; set; } = null!;
        public IssueStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public Issue()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }

    public enum IssueStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }

}
