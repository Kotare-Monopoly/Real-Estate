using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    public class Property
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int Hours { get; set; }
    }
}