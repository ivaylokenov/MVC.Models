namespace MVC.Models.DataAnnotations
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class ModelCollectionAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
