using SpeechifyPractice.Models;

namespace SpeechifyPractice.Services
{
    public class PaymentProcessor
    {
        public PaymentResult ProcessPayment(Payment payment)
        {
            if (payment.Amount <= 0)
            {
                return new PaymentResult
                {
                    Status = "Failed",
                    Message = "Invalid amount"
                };
            }

            if (string.IsNullOrEmpty(payment.PaymentMethod))
            {
                return new PaymentResult
                {
                    Status = "Failed",
                    Message = "Payment method missing"
                };
            }

            return new PaymentResult
            {
                Status = "OK",
                Message = "Payment Successful"
            };
        }
    }
}
