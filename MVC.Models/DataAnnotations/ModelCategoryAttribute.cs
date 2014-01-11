namespace MVC.Models.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ModelCategoryAttribute : Attribute
    {
        public ModelCategoryAttribute(params string[] categories)
        {
            Categories = categories.ToList();
        }

        public IList<string> Categories { get; set; } 
    }
}
