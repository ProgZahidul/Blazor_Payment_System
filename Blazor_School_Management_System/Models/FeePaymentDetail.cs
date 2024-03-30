namespace Blazor_School_Management_System.Models
{
    public class FeePaymentDetail
    {
        public int FeePaymentDetailId { get; set; }
        public int FeePaymentId { get; set; }
        public string FeeTypeName { get; set; }
        public decimal FeeAmount { get; set; }
    }

}
