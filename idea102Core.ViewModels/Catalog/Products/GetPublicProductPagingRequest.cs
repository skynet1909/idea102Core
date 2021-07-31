using idea102Core.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
