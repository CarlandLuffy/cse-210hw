using System;
using System.Collections.Generic;

namespace Foundation2
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _products;
        private List<int> _quantities;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
            _quantities = new List<int>();
        }

        public void AddProduct(Product product, int quantity)
        {
            _products.Add(product);
            _quantities.Add(quantity);
        }

        public double CalculateTotal()
        {
            double total = 0.0;

            for (int i = 0; i < _products.Count; i++)
            {
                double lineTotal = _products[i].GetTotalCost(_quantities[i]);
                total += lineTotal;
            }

            double shippingCost;

            if (_customer.LivesInUSA())
            {
                shippingCost = 5.0;
            }
            else
            {
                shippingCost = 35.0;
            }

            total += shippingCost;

            return total;
        }

        public string GetPackingLabel()
        {
            string result = "Packing Label:\n";

            for (int i = 0; i < _products.Count; i++)
            {
                Product product = _products[i];
                int quantity = _quantities[i];

                result += product.GetName() + " (ID: " + product.GetProductId() + ") x" + quantity + "\n";
            }

            return result;
        }

        public string GetShippingLabel()
        {
            return "Shipping Label:\n" + _customer.GetShippingLabel();
        }
    }
}
