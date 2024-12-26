using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public bool IsActive { get; set; }       
        public DateTime CreatedDate { get; set; } = DateTime.Now;  
        public string CreatedBy { get; set; }   
        public DateTime? ModifiedDate { get; set; }  
        public string ModifiedBy { get; set; }   

    }
}
