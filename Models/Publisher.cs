using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kl980715_MIS4200.Models
{
    public class Publisher
    {
        public int publisherId { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company name is required")]
        [StringLength(30)]
        public string companyName { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "The comapny's State is requred")]
        [StringLength(20)]
        public string state { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "The comapny's City is requred")]
        [StringLength(20)]
        public string city { get; set; }
        
        [Display(Name = "Address")]
        [StringLength(100)]
        public string address { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}