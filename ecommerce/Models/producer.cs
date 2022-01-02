using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class producer
    {
        [Key]
        public int Id { get; set; }
        public string profilePictureURL { get; set; }
        public string fullName { get; set; }
        public string Bio { get; set; }

        //Relation
        List<movie> movies { get; set; }
    }
}
