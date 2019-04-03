﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public MovieGenre MovieGenre { get; set; }

        [Required]
        [Display (Name="Genre")]
        public byte MovieGenreId { get; set; }

        [Required]
        [Display (Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name="Number in Stock")]
        [Range(1, 20)]
        public int TotalStock { get; set; }
    }

}