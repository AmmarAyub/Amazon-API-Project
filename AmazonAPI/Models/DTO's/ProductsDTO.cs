using System.ComponentModel.DataAnnotations;

namespace AmazonAPI.Models.DTO_s
{
    public class ProductsDTO
    {
        public int ProductId { get; set; }

        [Required]
        //[StringLength(100)]
        public string ProductName { get; set; } = null!;

        [Range(0, double.MaxValue)]
        public decimal? UnitPrice { get; set; }

        [Required]
        public int Status { get; set; }

        [StringLength(50)]
        public string? ItemCode { get; set; }

        public bool? IsTrackable { get; set; }

        [Required]
        [StringLength(50)]
        public string HstryUserId { get; set; } = null!;
        public DateTime? HstryDateTime { get; set; }
    }
}
