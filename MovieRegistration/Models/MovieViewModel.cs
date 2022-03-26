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

        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }

    



}
