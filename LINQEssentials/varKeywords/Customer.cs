namespace varKeywords
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class CustomerService
    {



        public List<Customer> GetCustomers()
        {

            return new List<Customer>()
            {
                 new(){ Name="Ayhan", City="Mersin",  Email="ayhan@test.com"},
                 new(){ Name="Ceyhun", City="Ankara", Email="ceyhun@test.com"},
                 new(){ Name="Melahat", City="İstanbul",Email="melahat@test.com"},
                 new(){ Name="Derya", City="Eskişehir",Email="derya@test.com"},

            };
        }


    }
}
