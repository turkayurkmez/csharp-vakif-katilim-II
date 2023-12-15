namespace Serialization
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }

    public class ProductService
    {
        public List<Product> GetProducts() => new() {
            new() {  Name ="ABC", Description="abc", Price=5,Id=1},
            new() {  Name ="DEF", Description="abc", Price=5,Id=2},
            new() {  Name ="XYZ", Description="abc", Price=5,Id=3},

        };


    }
}
