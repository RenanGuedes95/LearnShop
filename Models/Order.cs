namespace LearnShop.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<Ebook> Items { get; set; } = new List<Ebook>();
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string DownloadUrl { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; } = 0.0m;
    }
}
