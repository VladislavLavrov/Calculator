using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Data
{
    public class Calculation
    {
        /// <summary>
        /// Счетчик записи
        /// </summary>       
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Операнд 1
        /// </summary>    
        [Column(TypeName = "decimal(12,3)")]
        public string Operand_1 { get; set; }

        /// <summary>
        /// Операнд 2
        /// </summary>
        [Column(TypeName = "decimal(12,3)")]
        public string Operand_2 { get; set; }

        /// <summary>
        /// Тип операции: 1 - сложение; 2 - разность; 3 - умножение; 4 - деление
        /// </summary>
        [Column(TypeName = "tinyint")]
        public string Type_operation { get; set; }

        /// <summary>
        /// Результат
        /// </summary>
        [Column(TypeName = "decimal(12,3)")]
        public string Result { get; set; }
    }
}
