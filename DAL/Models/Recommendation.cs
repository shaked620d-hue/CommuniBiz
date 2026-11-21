using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Recommendation
    {
        [Key]
        public int Id { get; set; }

        public int BusinessId { get; set; }
        [ForeignKey(nameof(BusinessId))]
        public Business? Business { get; set; }

        public int RecommenderId { get; set; }
        [ForeignKey(nameof(RecommenderId))]
        public User? Recommeder { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; } = string.Empty;

        // תאריך ביצוע השירות/הרכישה
        public DateOnly ExecutionDate { get; set; }

        // תאריך כתיבת ההמלצה
        public DateTime RecommendationDate { get; set; } = DateTime.Now;

        public SatisfactionLevel Rating { get; set; }

        [Range(1, 10)]
        public int QualityScore { get; set; }

        [Range(1, 10)]
        public int AvailabilityScore { get; set; }

        [Range(1, 10)]
        public int PriceScore { get; set; }

        [Range(1, 10)]
        public int CourtesyScore { get; set; }

        [Range(1, 10)]
        public int ReliabilityScore { get; set; }

        //תמונות המצורפות להמלצה    
        public ICollection<RecommendationImage> Images { get; set; } = new List<RecommendationImage>();



    }
}
