using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication117.Models
{
    public class SigninModel
    {
        public string Id { get; set; }
        [Required]
        public string UserLogin { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
