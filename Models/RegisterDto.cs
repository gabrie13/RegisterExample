using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalculationTest.Models
{
    public class RegisterDto
    {
        [Key]
        public int     RegisterId       { get; set; }

        [DataType(DataType.Currency)]
        public decimal Cash             { get; set; }

        [DataType(DataType.Currency)]
        public decimal Visa             { get; set; }

        [DataType(DataType.Currency)]
        public decimal Mastercard       { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amex             { get; set; }

        [DataType(DataType.Currency)]
        public decimal Discover         { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total            { get; set; }

        

    }
}