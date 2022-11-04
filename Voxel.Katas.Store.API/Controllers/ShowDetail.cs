using Microsoft.AspNetCore.Mvc;

namespace Voxel.Katas.Store.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ShowProductDetail : ControllerBase
{
    [HttpPost(Name = "GetProductDetail")]
    public string Get([FromQuery] string idProduct)
    {
        ProductsList productsList = new ProductsList();
        var products = productsList.GetProducts();
        return products.First(product => product.idProduct == idProduct).Detail;
    }
}