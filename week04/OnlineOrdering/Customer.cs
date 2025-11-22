namespace OnlineOrderingProgram
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }

        // Check if customer lives in the USA (delegates to Address)
        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }

        // Helper method to get shipping label info
        public string GetShippingLabel()
        {
            return $"{_name}\n{_address.GetFullAddress()}";
        }
    }
}