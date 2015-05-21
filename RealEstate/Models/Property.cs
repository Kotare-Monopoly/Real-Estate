using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    public class Property
    {
        [Key]
        public string Name { get; set; }
        public int BasePrice { get; set; }

    }
}