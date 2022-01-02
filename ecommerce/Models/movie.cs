using ecommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public class movie
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public string ImagenURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movies> moviesActores { get; set; }
    }

    
}
