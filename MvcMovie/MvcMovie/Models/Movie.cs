using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
          [Required]
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [Range(1,100)]
        public Decimal Price { get; set; }
        [StringLength(5)]
        public string Rating { get; set; }

       
    }


    public class MovieDBContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }


    }
}