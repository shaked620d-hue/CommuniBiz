using DAL.Models;
using System.ComponentModel.DataAnnotations;


namespace DAL.Models
{


    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;


        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;


        public DateTime? BirthDate { get; set; }



        [MaxLength(500)]
        public string? ImageUrl { get; set; }


        public ICollection<Business> Businesses { get; set; } = new List<Business>();


        public ICollection<Recommendation> Recommendations  { get; set; } =new List<Recommendation>();


   }
}