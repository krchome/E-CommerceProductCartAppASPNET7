namespace ECommerceShoppingCartAppASPNET7.Models
{
    public class Cart
    {
        public string Id { get; set; }
        public List<Item> Items { get; set; }
        public double TotalCost => Items.Sum(item => item.Cost); // Calculate the total cost based on the costs of all items

        public Cart()
        {
            Items = new List<Item>();
        }

    }
}
