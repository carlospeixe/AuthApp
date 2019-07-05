using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please inform username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please inform password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string[] Roles { get; set; }

        public bool LoggedIn { get; set; }
    }

   
}