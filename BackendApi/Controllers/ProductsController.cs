using idea102Core.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        public ProductsController(IPublicProductService productService)
        {
            _publicProductService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }
    }
}
