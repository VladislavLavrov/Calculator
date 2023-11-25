using Calculator.Data;
using Calculator.Models;
using Calculator.Services;
using Confluent.Kafka;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Calculator.Controllers
{
    public enum Operation { Add, Subtract, Multiply, Divide }

    public class CalculatorController : Controller
    {
        private CalculatorContext _context;
        private readonly KafkaProducerService<Null, string> _producer;

        public CalculatorController(CalculatorContext context, KafkaProducerService<Null, string> producer)
        {
            _context = context;
            _producer = producer;
        }

        //public async Task<IActionResult> AddMessage()
        //{
        //    var data = new InputData { X = 5, Y = 10 };
        //    var json = JsonSerializer.Serialize(data);

        //    // Добавить сообщение в Kafka
        //    await _producer.ProduceAsync("lavrov", new Message<Null, string> { Value = json });

        //    return RedirectToAction(nameof(Index));
        //}

        public async Task<IActionResult> Callback(int z)
        {
            var i = 0;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calculate(double num1, double num2, Operation operation)
        {
            double result = 0;
            switch (operation)
            {
                case Operation.Add:
                    result = num1 + num2;
                    break;
                case Operation.Subtract:
                    result = num1 - num2;
                    break;
                case Operation.Multiply:
                    result = num1 * num2;
                    break;
                case Operation.Divide:
                    result = num1 / num2;
                    break;
            }
            ViewBag.Result = result;

            DataInputVariant dataInputVariant = new DataInputVariant();
            dataInputVariant.Operand_1 = num1.ToString();
            dataInputVariant.Operand_2 = num2.ToString();
            dataInputVariant.Type_operation = operation.ToString();
            dataInputVariant.Result = result.ToString();
            
            _context.DataInputVariants.Add(dataInputVariant);
            _context.SaveChanges();

            return View("Index");
        }
    }
}