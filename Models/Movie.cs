﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oop_a_2025_movies_74476.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; } = string.Empty;

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; } = string.Empty;

        

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Director { get; set; } = string.Empty;

        [StringLength(100)] // or more if needed
        [RegularExpression(@"^[A-Z].*$")]
        public string Cast { get; set; } = string.Empty;



        [Column(TypeName = "decimal(10,1)")]
        public decimal IMDbRating { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BoxOfficeRevenue { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string ReleaseCountry { get; set; } = string.Empty;







    }
}
