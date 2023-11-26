using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Calculator.Data
{
    public class DataInputVariant
    {
        [Key]
        public int ID_DataInputVariant { get; set; } // Уникальный идентификатор для объекта DataInputVariant

        [Column(TypeName = "varchar(128)")]
        public string? Operand_1 { get; set; } // Первый операнд для операции

        [Column(TypeName = "varchar(128)")]
        public string? Operand_2 { get; set; } // Второй операнд для операции

        [Column(TypeName = "varchar(128)")]
        public string? Type_operation { get; set; } // Тип операции (например, сложение, вычитание и т.д.)

        [Column(TypeName = "varchar(128)")]
        public string? Result { get; set; } // Результат выполнения операции
    }

}