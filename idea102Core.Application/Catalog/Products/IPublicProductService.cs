using idea102Core.ViewModels.Catalog.Products;
using idea102Core.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idea102Core.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
    }
}
