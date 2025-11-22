namespace OnlineOrderingProgram
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _pricePerUnit;
        private int _quantity;

        public Product(string name, string productId, double pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public double GetPricePerUnit()
        {
            return _pricePerUnit;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        // Calculate total cost for this product
        public double GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }

        // Helper method to display product info (for packing label)
        public string GetPackingLabelLine()
        {
            return $"{_name} ({_productId})";
        }
    }
}