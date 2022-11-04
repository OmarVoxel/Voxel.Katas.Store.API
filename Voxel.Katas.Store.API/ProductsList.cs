namespace Voxel.Katas.Store.API;

public class ProductsList
{
    private readonly List<Product> products = new();
    public ProductsList()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var file = File.ReadAllLines(currentDirectory + @"\Resources\productList.txt");
        foreach(var line in file)
        {
            var data = line.Split(',');
            var (idProduct, name, detail) = (data[0], data[1], data[2]);
            
            SetProduct(new Product
            {
                idProduct = idProduct,
                Name = name,
                Detail = detail
            });
        }
    }

    private void SetProduct(Product product) 
        =>  products.Add(product);

    public IEnumerable<Product> GetProducts() 
        => products;
    
    public Product GetProduct(string idProduct) 
        => products.First(product => product.idProduct == idProduct);
}