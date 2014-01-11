namespace MVC.Models.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Design;
    using Extensions;

    public class ModelExpressionBuilder<TBase> : IGenericModelExpressionBuilder<TBase>
        where TBase : class
    {
        private const string NamesParameter = "names";
        private const string NamesNullExceptionMessage = "Binding names cannot be null";
        private const string TypesParameter = "types";
        private const string TypesNullExceptionMessage = "Binding types cannot be null";
        private const string CategoryNameParameter = "name";
        private const string CategoryNameNullOrEmptyMessage = "Category name cannot be null or empty";
        private const string CategoriesParameter = "categories";
        private const string CategoriesNullMessage = "Categories cannot be null";

        private readonly BindingOptions options;

        public ModelExpressionBuilder() 
        {
             options = new BindingOptions();
        }

        public IGenericModelExpressionBuilder<TBase> IncludeNames(params string[] names)
        {
            if (names == null) throw new ArgumentNullException(NamesParameter, NamesNullExceptionMessage);

            options.IncludedNames.AddRange(names);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> IncludeNames(IList<string> names)
        {
            if (names == null) throw new ArgumentNullException(NamesParameter, NamesNullExceptionMessage);

            options.IncludedNames.AddRange(names);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> IncludeTypes(params BindingType[] types)
        {
            if (types == null) throw new ArgumentNullException(TypesParameter, TypesNullExceptionMessage);

            options.IncludedTypes.AddRange(types);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> IncludeTypes(IList<BindingType> types)
        {
            if (types == null) throw new ArgumentNullException(TypesParameter, TypesNullExceptionMessage);

            options.IncludedTypes.AddRange(types);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeNames(params string[] names)
        {
            if (names == null) throw new ArgumentNullException(NamesParameter, NamesNullExceptionMessage);
            
            options.ExcludedNames.AddRange(names);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeNames(IList<string> names)
        {
            if (names == null) throw new ArgumentNullException(NamesParameter, NamesNullExceptionMessage);

            options.ExcludedNames.AddRange(names);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeTypes(params BindingType[] types)
        {
            if (types == null) throw new ArgumentNullException(TypesParameter, TypesNullExceptionMessage);

            options.ExcludedTypes.AddRange(types);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeTypes(IList<BindingType> types)
        {
            if (types == null) throw new ArgumentNullException(TypesParameter, TypesNullExceptionMessage);

            options.ExcludedTypes.AddRange(types);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> Cachable(bool cachable)
        {
            options.Cachable = cachable;
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> Category(string name)
        {
            if (!string.IsNullOrEmpty(name)) throw new ArgumentNullException(CategoryNameParameter, CategoryNameNullOrEmptyMessage);

            options.Categories.Add(name);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> Categories(params string[] categories)
        {
            if (categories == null) throw new ArgumentNullException(CategoriesParameter, CategoriesNullMessage);

            options.Categories.AddRange(categories);
            return this;
        }

        public IGenericModelExpressionBuilder<TBase> Categories(IList<string> categories)
        {
            if (categories == null) throw new ArgumentNullException(CategoriesParameter, CategoriesNullMessage);

            options.Categories.AddRange(categories);
            return this;
        }

        public Expression<Func<TBase, TResult>> To<TResult>()
        {
            throw new NotImplementedException();
        }
    }
}
