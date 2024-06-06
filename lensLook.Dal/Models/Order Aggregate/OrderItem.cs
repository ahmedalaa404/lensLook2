namespace lensLook.Dal.models.Order_Aggregate
{
    public class OrderItem// In Database // Product Have U Add In Order
    {
        public OrderItem()
        {

        }

        public int Id { get; set; }
        public OrderItem(ProductItemOrder product, decimal price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public ProductItemOrder Product { get; set; } //Not Have Change

        public decimal Price { get; set; }// can U Have Deffirent here 

        public int Quantity { get; set; }




    }
}
