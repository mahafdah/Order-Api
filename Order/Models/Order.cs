namespace Order.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreationDateTime { get; set; } = DateTime.Now;
    }
}
