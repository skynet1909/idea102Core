using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Data.Entities
{
    public class ProductCategoryTranslation
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }

        public ProductCategory Category { get; set; }

        public Language Language { get; set; }
    }
}
