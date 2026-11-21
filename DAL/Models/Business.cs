
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Business
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string BusisnessName { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Dascription { get; set; } = string.Empty ;

        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        //מפתחות זרים
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        //רשימת המלצות שנכתבו על העסק
        public ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();


    }
}
