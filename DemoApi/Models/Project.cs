using System;
using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }  

        [Required]
        public string ProjectName { get; set; } = null!; 

        public bool IsActive { get; set; } = true;  

        public DateTime CreatedDate { get; set; } = DateTime.Now;  
 
        public string CreatedBy { get; set; } = null!;  

        public DateTime? ModifiedDate { get; set; }  

        public string? ModifiedBy { get; set; }  

        public string? Description { get; set; }  
    }
}
