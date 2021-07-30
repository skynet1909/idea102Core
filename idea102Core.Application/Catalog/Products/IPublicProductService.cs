using idea102Core.Application.Catalog.Products.Dtos;
using idea102Core.Application.Catalog.Products.Dtos.Manage;
using idea102Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idea102Core.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
