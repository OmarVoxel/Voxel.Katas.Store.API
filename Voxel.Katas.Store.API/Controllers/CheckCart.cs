using Microsoft.AspNetCore.Mvc;

namespace Voxel.Katas.Store.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CheckCart : ControllerBase
{
     [HttpGet(Name = "CheckCart")]
     public IEnumerable<Product> Get()
     {
          Cart cart = new Cart();
          IEnumerable<Product> products = cart.CheckProductsOnCart();
          return products;
     }
}