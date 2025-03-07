using ReportBuilderAPI.Client.Components.Models;

namespace ReportBuilderAPI.Client.Components.Data
{
    public static class SampleData
    {
        private static readonly Random random = new();

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new() { Country = "Almanya", GrossValue = 15000, NetValue = 12000, OrderDate = GetRandomDate() },
                new() { Country = "Fransa", GrossValue = 10000, NetValue = 13000, OrderDate = GetRandomDate() },
                new() { Country = "Amerika", GrossValue = 11000, NetValue = 8000, OrderDate = GetRandomDate() },
                new() { Country = "Fas", GrossValue = 18000, NetValue = 20000, OrderDate = GetRandomDate() },
                new() { Country = "Tunus", GrossValue = 14000, NetValue = 8000, OrderDate = GetRandomDate() },
                new() { Country = "İngiltere", GrossValue = 9000, NetValue = 12000, OrderDate = GetRandomDate() },
                new() { Country = "Pakistan", GrossValue = 21000, NetValue = 13000, OrderDate = GetRandomDate() },
                new() { Country = "Bulgaristan", GrossValue = 12000, NetValue = 4000, OrderDate = GetRandomDate() },
                new() { Country = "İsveç", GrossValue = 7000, NetValue = 4000, OrderDate = GetRandomDate() },
                new() { Country = "Danimarka", GrossValue = 13000, NetValue = 16000, OrderDate = GetRandomDate() }
            };
        }

        private static DateTime GetRandomDate()
        {
            return DateTime.Today.AddDays(-random.Next(0, 365)); // Son 1 yıl içinde rastgele bir tarih
        }
    }
}
