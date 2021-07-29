using idea102Core.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Data.Entities
{
    public class ProductCategory
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<ProductCategoryTranslation> ProductCategoryTranslations { get; set; }
    }
}
