using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movie_database.Models
{
    public class Movie_details
    {
        [Key]
        public int Movie_ID { get; set; }
        public string Movie_Name { get; set; }
        public string Movie_Director_Name { get; set; }
        public string Movie_Language { get; set; }
        public string Movie_Type { get; set; }
    }
}
