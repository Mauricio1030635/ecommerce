using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public class cinema
    {
        [Key]
        public int id{ get; set; }
        public string Logo { get; set; }
        public string name{ get; set; }
        public string Description{ get; set; }

        //Relation
        List<movie> movies  { get; set; }
}
}
