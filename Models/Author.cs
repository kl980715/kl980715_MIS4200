using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kl980715_MIS4200.Models
{
    public class Author
    {
        public int authorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string bookName { get; set; }
        public string email { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}