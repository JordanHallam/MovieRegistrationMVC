using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        [Required]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Please enter 4 digit ID")]
        public int ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =1, ErrorMessage ="Movie title must be 1-50 characters")]
        public string Title { get; set; }
        [Required]
        [StringLength(50, MinimumLength =1, ErrorMessage ="Genre must be 1-50 characrers")]
        public string Genre { get; set; }
        
        //[Range(1840, maximum: double.Parse(DateTime.Today.Year))]
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
