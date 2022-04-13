namespace LinqMethods
{
    public  class Product
    {
        public Product(int id, string name, bool isActive = true)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
