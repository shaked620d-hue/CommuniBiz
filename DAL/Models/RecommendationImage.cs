using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Models
{

    public class RecommendationImage
    {

        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(500)]
        public string Path { get; set; } = string.Empty;


        public int RecommendationId { get; set; }
        [ForeignKey(nameof(RecommendationId))]

        public Recommendation? Recommendation{ get; set; }
        }
    }