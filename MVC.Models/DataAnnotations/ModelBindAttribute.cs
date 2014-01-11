namespace MVC.Models.DataAnnotations
{
    using System;

    public class ModelBindAttribute : Attribute
    {
        public ModelBindAttribute(string condition)
        {
            Condition = condition;
        }

        public string Condition { get; set; }
    }
}
