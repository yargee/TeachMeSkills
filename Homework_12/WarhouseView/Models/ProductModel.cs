namespace WarhouseView.Models
{
    public class ProductModel
    {
        public Guid Id { get;}
        public string Name { get;}
        public ProductInfo Info { get;}

        public ProductModel(Guid id ,string name, ProductInfo info)
        {
            Id = id;
            Name = name;
            Info = info;
        }
    }
}
