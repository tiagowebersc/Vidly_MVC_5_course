﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int id { get; set; }

        [Required]
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        [Required]
        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        [Display(Name = "Date rented")]
        public DateTime DateRented { get; set; }

        [Display (Name = "Date returned")]
        public DateTime? DateReturned { get; set; }
    }
}