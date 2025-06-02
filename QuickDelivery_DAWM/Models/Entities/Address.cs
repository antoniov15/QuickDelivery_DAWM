using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickDelivery_DAWM.Models.Entities
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public int? UserId { get; set; }

        public int? PartnerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Street { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,8)")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "decimal(11,8)")]
        public decimal? Longitude { get; set; }

        [StringLength(255)]
        public string? Instructions { get; set; }

        public bool IsDefault { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key relationships
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        [ForeignKey("PartnerId")]
        public virtual Partner? Partner { get; set; }

        // Computed property
        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {PostalCode}, {Country}";
    }
}