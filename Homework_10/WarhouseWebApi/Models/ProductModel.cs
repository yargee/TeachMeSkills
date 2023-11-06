namespace WarhouseWebApi.Models
{
    public class ProductModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public ProductInfo Info { get; private set; }

        public ProductModel(string name, ProductInfo info)
        {
            Id = Guid.NewGuid();
            Name = name;
            Info = info;
        }
    }
}
