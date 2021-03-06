using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Title can only be 50 characters max")]
        public string Title { get; set; }
        public string Genre { get; set; }
        [Range(1880, 2022, ErrorMessage = "Year must be between 1880 and the current year")]
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }

    



}
