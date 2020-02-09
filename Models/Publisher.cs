using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kl980715_MIS4200.Models
{
    public class Publisher
    {
        public int publisherID { get; set; }
        public string companyName { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}