using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
    }
}