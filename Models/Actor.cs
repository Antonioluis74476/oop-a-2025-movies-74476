using System;
using System.ComponentModel.DataAnnotations;

namespace oop_a_2025_movies_74476.Models
{
    public class Actor
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
