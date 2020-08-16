using System;
using System.ComponentModel.DataAnnotations;

namespace Cork.Models
{
    public class User
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
