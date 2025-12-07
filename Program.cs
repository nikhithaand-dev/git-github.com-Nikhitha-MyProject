
using SpeechifyPractice.Services;
using SpeechifyPractice.Models;

namespace SpeechifyPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Payment Processor...");

            var payment = new Payment()
            {
                Id = 1,
                UserName = "JohnDoe",
                Amount = 99.50m,
                PaymentMethod = "CreditCard"
            };

            var processor = new PaymentProcessor();

            var result = processor.ProcessPayment(payment);

            Console.WriteLine($"Status: {result.Status}");
            Console.WriteLine($"Message: {result.Message}");
        }
    }
