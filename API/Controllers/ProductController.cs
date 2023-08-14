using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		public string GetProducts()
		{
			return "This Method wil get all products";
		}

		[HttpGet("{id}")]
		public string GetProducts(int id)
		{
			return "This Method wil get product by id";
		}
	}
}
