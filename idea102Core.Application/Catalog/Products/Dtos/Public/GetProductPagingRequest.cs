﻿using idea102Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
