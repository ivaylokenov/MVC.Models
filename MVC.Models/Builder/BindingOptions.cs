namespace MVC.Models.Builder
{
    using System.Collections.Generic;

    internal class BindingOptions
    {
        internal BindingOptions()
        {
            IncludedNames = new List<string>();
            IncludedTypes = new List<BindingType>();
            ExcludedNames = new List<string>();
            ExcludedTypes = new List<BindingType>();
            Categories = new List<string>();
        }

        internal IList<string> IncludedNames { get; set; }

        internal IList<BindingType> IncludedTypes { get; set; }

        internal IList<string> ExcludedNames { get; set; }

        internal IList<BindingType> ExcludedTypes { get; set; }

        internal IList<string> Categories { get; set; }

        internal bool Cachable { get; set; }
    }
}
