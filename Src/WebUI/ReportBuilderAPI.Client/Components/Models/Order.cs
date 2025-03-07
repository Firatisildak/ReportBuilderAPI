namespace ReportBuilderAPI.Client.Components.Models
{
    public class Order
    {
        public string Country { get; set; }
        public decimal GrossValue { get; set; }
        public decimal NetValue { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
