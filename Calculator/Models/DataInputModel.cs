namespace Calculator.Models
{   
    public class DataInputModel
    {       
        public DataInputModel() { }
               
        public double Operand_1 { get; set; }

        public double Operand_2 { get; set; }

        public string Type_operation { get; set; }

        public double Result { get; set; }        
    }
}
