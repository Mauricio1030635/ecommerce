using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public class Actor_Movies
    {
        public int idMovie { get; set; }
        public movie Movie { get; set; }
        public int idActor { get; set; }
        public actor actor { get; set; }
    }
}
