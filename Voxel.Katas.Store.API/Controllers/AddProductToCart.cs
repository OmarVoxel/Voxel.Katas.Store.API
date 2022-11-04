using Microsoft.AspNetCore.Mvc;

namespace Voxel.Katas.Store.API.Controllers;


[ApiController]
[Route("[controller]")]
public class AddProductToCart : ControllerBase
{
    [HttpPost(Name = "AddProductToCart")]
    public void Get([FromQuery] string idProduct)
    {
        Cart cart = new Cart();
        cart.AddProduct(idProduct);
    }
}

