using Calculator.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calculator.Data
{
    public enum Operation { Add, Subtract, Multiply, Divide }

    public class DataInputVariant
    {
        [Key]
        public int ID_DataInputVariant { get; set; }

        
        /// <summary>
        /// Параметр исходных данных: Num1
        /// </summary>        
        [Display(Name = "Operand_1")]
        public double Operand_1 { get; set; }

        /// <summary>
        /// Параметр исходных данных: Num2
        /// </summary>        
        [Display(Name = "Operand_2")]
        public double Operand_2 { get; set; }
                
        [Display(Name = "Type_operation")]
        public Operation Type_operation { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }
        
    }
}