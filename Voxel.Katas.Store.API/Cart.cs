namespace Voxel.Katas.Store.API.Controllers;

public class Cart
{
    private List<Product> products = new();
    public IEnumerable<Product> CheckProductsOnCart() 
        => products;
    public void AddProduct(string idProduct)
    {
        ProductsList productsList = new ProductsList();
        var product = productsList.GetProduct(idProduct);
        products.Add(product);
    }
}