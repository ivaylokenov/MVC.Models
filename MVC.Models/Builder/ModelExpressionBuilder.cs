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

        private BindingOptions options;

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
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeNames(IList<string> names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeTypes(params BindingType[] types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> ExcludeTypes(IList<BindingType> types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> Cachable(bool cachable)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> Category(string name)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> Categories(params string[] categories)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> Categories(IList<string> categories)
        {
            throw new NotImplementedException();
        }
        public Expression<Func<TBase, TResult>> To<TResult>()
        {
            throw new NotImplementedException();
        }
    }
}
