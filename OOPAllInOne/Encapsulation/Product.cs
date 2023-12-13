namespace Encapsulation
{
    public class Product
    {

        private double price;
        public void SetPrice(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            price = value;
        }

        public double GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {

            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        public int StockCount { get; set; } = 0;
        public bool IsInStock { get; } = false;


        public void ChangeStockLevel()
        {
            //IsInStock = true;
        }
        public Product()
        {
            IsInStock = true;
        }




    }
}
