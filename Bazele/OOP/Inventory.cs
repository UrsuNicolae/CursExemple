namespace Bazele.OOP
{
    public class Inventory
    {
        public List<Product> Products;

        public int Count => Products.Count;

        public Inventory()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public Product this[int index]
        {
            get
            {
                return Products[index];
            }
            set
            {
                Products[index] = value;
            }
        }
    }
}
