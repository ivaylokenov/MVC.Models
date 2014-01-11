namespace MVC.Models.DataAnnotations
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class ModelPropertyAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
