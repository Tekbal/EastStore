namespace EastStore.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public string Picture { get; set; }
}
}
