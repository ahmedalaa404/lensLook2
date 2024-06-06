namespace lensLook.Dal.models.Order_Aggregate
{
    public class Order
    {
        public Order()
        {

        }

        public int Id { get; set; }
        public Order(string buyerEmail, Address shippingAddress, decimal subTotal, ICollection<OrderItem> items, string paymentIntentId)
        {
            BuyerEmail = buyerEmail;


            ShippingAddress = shippingAddress;


            SubTotal = subTotal;
            Items = items;
            PaymentIntentId = paymentIntentId;
        }

        public string BuyerEmail { get; set; }


        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;


        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public Address ShippingAddress { get; set; } // One To One   Total of the Two Dimations


        //[not]
        public int? DeliveryMethodId { get; set; }



        public ICollection<OrderItem> Items { get; set; } = new HashSet<OrderItem>();
        public decimal SubTotal { get; set; }





        public string PaymentIntentId { get; set; }
    }

}
