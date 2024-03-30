namespace Blazor_School_Management_System.Models
{
    public class FeeStructure
    {
        public int FeeStructureId { get; set; }
        public int FeeTypeId { get; set; }
        public string TypeName { get; set; }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public bool Monthly { get; set; }
        public bool Yearly { get; set; }
        public decimal FeeAmount { get; set; }
        public FeeType FeeType { get; set; } // Replace 'FeeType' with your actual model if available
        public Standard Standard { get; set; } // Replace 'Standard' with your actual model if available
    }

}
