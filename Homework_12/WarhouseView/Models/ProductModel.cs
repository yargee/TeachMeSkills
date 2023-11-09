namespace WarhouseView.Models
{
    public class ProductModel
    {
        public Guid Guid { get;}
        public string Name { get;}
        public ProductInfo Info { get;}

        public ProductModel(Guid guid ,string name, ProductInfo info)
        {
            Guid = guid;
            Name = name;
            Info = info;
        }
    }
}
