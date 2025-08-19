using System.ComponentModel.DataAnnotations;

namespace JobBoard.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Company { get; set; }

        public string Location { get; set; }

        [Display(Name = "Job Type")]
        public string Type { get; set; } // Full-Time, Part-Time, etc.

        public string Description { get; set; }
    }
}
