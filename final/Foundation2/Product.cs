namespace Foundation2
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;

        public Product(string name, string productId, double price)
        {
            _name = name;
            _productId = productId;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public double GetTotalCost(int quantity)
        {
            return _price * quantity;
        }
    }
}
