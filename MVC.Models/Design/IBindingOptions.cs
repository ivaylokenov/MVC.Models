namespace MVC.Models.Design
{
    using System.Collections.Generic;

    public interface IBindingOptions
    {
        IList<string> IncludedNames { get; }

        IList<BindingType> IncludedTypes { get; }

        IList<string> ExcludedNames { get; }

        IList<BindingType> ExcludedTypes { get; }

        IList<string> Categories { get; }

        bool Cachable { get; set; }
    }
}
