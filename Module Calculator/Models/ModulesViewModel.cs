using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Module_Calculator.Models
{
    public class ModulesViewModel
    {
        
        [Required]
        [Display(Name = "Module Code")]
        public string Code { get; set; }
        [Required]
        [Display(Name = "Module Code Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Hours per Week")]
        public int Hours { get; set; }
        [Required]
        [Display(Name = "Number of Weeks")]
        public int Weeks { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime Startdate { get; set; }
    }
}