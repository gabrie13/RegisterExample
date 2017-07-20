using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalculationTest.Models
{
    public class Register
    {
        [Key]
        public int      RegisterId   { get; set; }
        
        public decimal  Cash         { get; set; }
        
        public decimal  Visa         { get; set; }
        
        public decimal  Mastercard   { get; set; }

        public decimal  Amex         { get; set; }
       
        public decimal Discover      { get; set; }
    }
}