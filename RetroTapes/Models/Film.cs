using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace RetroTapes.Models
{
    [Table("film", Schema = "dbo")]
    public class Film
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }

        [Required]
        [Column("title")]
        [MaxLength(255)]
        public string? Title { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("release_year")]
        public string? ReleaseYear { get; set; }

        [Required]
        [Column("language_id")]
        public byte LanguageId { get; set; }

        [Column("original_language_id")]
        public byte? OriginalLanguageId { get; set; }

        [Required]
        [Column("rental_duration")]
        public byte RentalDuration { get; set; }

        [Required]
        [Column("rental_rate")]
        public decimal RentalRate { get; set; }

        [Column("length")]
        public short? Length { get; set; }

        [Required]
        [Column("replacement_cost")]
        public decimal ReplacementCost { get; set; }

        [Column("rating")]
        [MaxLength(10)]
        public string? Rating { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("special_features")]
        [MaxLength(255)]
        public string? SpecialFeatures { get; set; }


    }
}