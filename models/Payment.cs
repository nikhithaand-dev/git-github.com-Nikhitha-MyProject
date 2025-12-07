namespace SpeechifyPractice.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = "";
    }
}
