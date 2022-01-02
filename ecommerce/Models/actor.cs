using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class actor
    {
        [Key]
        public int Id{ get; set; }
        public string profilePictureURL{ get; set; }
        public string fullName{ get; set; }
        public string Bio{ get; set; }
        public List<Actor_Movies> moviesActores { get; set; }
    }
}
