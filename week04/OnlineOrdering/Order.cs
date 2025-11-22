using System;
using System.Collections.Generic;

namespace OnlineOrderingProgram
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Customer GetCustomer()
        {
            return _customer;
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        // Calculate total cost: sum of all product costs + shipping cost
        public double GetTotalCost()
        {
            double productTotal = 0;
            foreach (Product product in _products)
            {
                productTotal += product.GetTotalCost();
            }

            double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
            return productTotal + shippingCost;
        }

        // Generate packing label: list each product's name and ID
        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += $"  {product.GetPackingLabelLine()}\n";
            }
            return label;
        }

        // Generate shipping label: customer name and full address
        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetShippingLabel()}";
        }
    }
}