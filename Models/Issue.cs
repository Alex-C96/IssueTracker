using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace IssueTracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public IssueStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public enum IssueStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }

}
