namespace EventInCSharp
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class CreatedCategoryEventArgs : EventArgs
    {
        public Category Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public string User { get; set; }
    }

    public class CategoryService
    {
        //public delegate void NewCategoryAddedEventHandler(object sender, CreatedCategoryEventArgs e);
        public event EventHandler<CreatedCategoryEventArgs> NewCategoryCreated;

        public void Create(Category category)
        {
            //db'ye ekledin....
            CreatedCategoryEventArgs args = new CreatedCategoryEventArgs
            {
                User = "turkay",
                Category = category,
                CreatedDate = DateTime.UtcNow
            };

            OnCategoryCreated(args);
        }

        private void OnCategoryCreated(CreatedCategoryEventArgs args)
        {
            if (NewCategoryCreated != null)
            {
                NewCategoryCreated(this, args);
            }
        }
    }
}
