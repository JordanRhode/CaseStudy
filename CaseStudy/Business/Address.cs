namespace CaseStudy.Business
{
    public class Address
    {
        #region Properties
        private long? _addressID = null;
        public long? AddressID
        {
            get { return _addressID; }
            set { _addressID = value; }
        }

        private Person _user = null;
        public Person User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _street = null;
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _city = null;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _stateCode = null;
        public string StateCode
        {
            get { return _stateCode; }
            set { _stateCode = value; }
        }

        private int? _zip = null;
        public int? Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        #endregion

        public Address()
        {
        }

        public Address(long? addressID, string street, string city, string state, int? zip)
        {
            _addressID = addressID;
            _street = street;
            _city = city;
            _stateCode = state;
            _zip = zip;

        }

        public override bool Equals(object obj)
        {
            if (obj is Address)
            {
                Address address = (Address)obj;
                if (address.Street != null && address.City != null && address.StateCode != null && address.Zip != null)
                {
                    return ((this.Street == address.Street) && (this.City == address.City) &&
                        (this.StateCode == address.StateCode) && (this.Zip == address.Zip));
                }
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Street: {0}, City: {1}, State: {2}, Zip: {3}", this.Street, this.City, this.StateCode, this.Zip);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
