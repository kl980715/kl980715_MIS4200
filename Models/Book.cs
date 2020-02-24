using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kl980715_MIS4200.Models
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "The book name is requred")]
        [StringLength(30)]
        public string bookName { get; set; }
        [Display(Name = "Price")]
        [Required]
        [DataType(DataType.Currency)]

        public decimal price { get; set; }
        //[Display(Name = "Author Name"]
        public int authorId { get; set; }
        public virtual Author Author { get; set; }
        //[Display(Name = "Publisher Name"]
        public int publisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}