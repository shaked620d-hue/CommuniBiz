using DAL.Models;
using System.ComponentModel.DataAnnotations;


namespace DAL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;


        public ICollection<Business> Businesses { get; set; } = new List<Business>();
    }
}