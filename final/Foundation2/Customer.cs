namespace Foundation2
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

        public string GetShippingLabel()
        {
            return _name + "\n" + _address.FullAddress();
        }

        public bool LivesInUSA()
        {
            return _address.IsUSA();
        }
    }
}
