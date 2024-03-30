namespace Blazor_School_Management_System.Models
{
    public class FeePayment
    {
        public int FeePaymentId { get; set; } = 0;
        public int StudentId { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
        public decimal AmountPaid { get; set; } = 0;
        public List<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();
    }

}
