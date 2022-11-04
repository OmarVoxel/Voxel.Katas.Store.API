using Microsoft.AspNetCore.Mvc;

namespace Voxel.Katas.Store.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ShowProducts : ControllerBase
{
    [HttpGet(Name = "GetProducts")]
    public IEnumerable<Product> Get()
    {
        ProductsList productses = new ProductsList();
        return productses.GetProducts();
    }
}