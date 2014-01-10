namespace MVC.ViewModels.DataAnnotations
{
    using System;

    public class ModelBindAttribute : Attribute
    {
        private string condition;

        public ModelBindAttribute(string condition)
        {
            this.condition = condition;
        }
    }
}
