using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kl980715_MIS4200.Models
{
    public class Author
    {
        public System.Guid SID { get; set; }
        public int authorId { get; set; }
        [Display (Name="First Name")]
        [Required(ErrorMessage ="Author's first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Author's last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }

        public string fullName { get { return lastName + ", " + firstName; } }
        
        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "Author's Book name is required")]
        [StringLength(30)]
        public string bookName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Author's most frequently used email")]
        public string email { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}