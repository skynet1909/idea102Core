using idea102Core.Application.Catalog.Products;
using idea102Core.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idea102Core.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductsController(IPublicProductService productService, IManageProductService manageService)
        {
            _publicProductService = productService;
            _manageProductService = manageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }
        
        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromQuery] ProductCreateRequest request)
        {
            var result = await _manageProductService.Create(request);
            if (result == 0)
                return BadRequest();
            return Ok(result);
        }
    }
}
