namespace WarhouseView.Models
{
    public class ProductModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public ProductInfo Info { get; private set; }

        public ProductModel(Guid id ,string name, ProductInfo info)
        {
            Id = id;
            Name = name;
            Info = info;
        }
    }
}
