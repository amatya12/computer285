using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace computer285.Models
{
    public class Products
    {
        internal readonly object id;

        [Key]
        public int ID { get; set; }
        public String ProductName {get;set;}
        public decimal Price { get; set; }
        public String Description { get; set; }
        
    }
}