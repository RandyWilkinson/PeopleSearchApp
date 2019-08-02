using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearchApi.Models
{
    public class Person
    {
        public string PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }

        public int Age { get; set; }

        public string Interests { get; set; }

    }
}
