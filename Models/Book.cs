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
        public int BookID { get; set; }
        public string bookName { get; set; }
        public DateTime releaseDate { get; set; }
        public Decimal price { get; set; }
        public int authorID { get; set; }
        public virtual Author Author { get; set; }
        public int PublisherID { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}