
// --- ORDER CLASS ---
using System;
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

        public double CalculateTotalCost()
        {
            double subtotal = 0;
            foreach (var product in _products)
            {
                subtotal += product.GetTotalCost();
            }
             double shipping = 0;
            if (_customer.IsInUSA())
            {
                shipping = 5.00; // Local shipping
            }
            else
            {
                shipping = 35.00; // International shipping
            }

           
            return subtotal + shipping;
        }

        public string GetPackingLabel()
        {
            string label = "PACKING LABEL:\n";
            foreach (var product in _products)
            {
                label += $"- {product.GetPackingInfo()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
    }