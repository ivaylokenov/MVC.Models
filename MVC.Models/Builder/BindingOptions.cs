namespace MVC.Models.Builder
{
    using System.Collections.Generic;
    using Design;

    public class BindingOptions : IBindingOptions
    {
        public BindingOptions()
        {
            IncludedNames = new List<string>();
            IncludedTypes = new List<BindingType>();
            ExcludedNames = new List<string>();
            ExcludedTypes = new List<BindingType>();
            Categories = new List<string>();
        }

        public IList<string> IncludedNames { get; private set; }

        public IList<BindingType> IncludedTypes { get; private set; }

        public IList<string> ExcludedNames { get; private set; }

        public IList<BindingType> ExcludedTypes { get; private set; }

        public IList<string> Categories { get; set; }

        public bool Cachable { get; set; }
    }
}
