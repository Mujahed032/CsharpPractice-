namespace Customer_order_and_item_composition_using_list
{
    public class Address
    {
        public int Id { get; set; }

        public int HouseNo { get; set; }

        public string StreetName { get; set;}

        public string City { get; set;}

        public string State { get; set;}

        public int PinCode { get; set;}
        public string Country { get; set;}

        public Address (int Id, int HouseNo, String StreetName, string City, string State, int PinCode, String Country)
        {
            this.Id= Id;
            this.HouseNo= HouseNo;
            this.StreetName = StreetName;
            this.City= City;
            this.State= State;
            this.PinCode= PinCode;
            this.Country= Country;
        }
        public void CustAddress()
        {
            Console.WriteLine($"Delivery Id is {Id}");
            Console.WriteLine($"Delivery HouseNo is {HouseNo}");
            Console.WriteLine($"Delivery StreetName is {StreetName}");
            Console.WriteLine($"Delivery City is {City}");
            Console.WriteLine($"Delivery State is {State}");
            Console.WriteLine($"Delivery PinCode is {PinCode}");
            Console.WriteLine($"Delivery Country is {Country}");
        }

    }
}