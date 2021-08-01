using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.ViewModels.Catalog.Categories
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}
