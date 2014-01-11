namespace MVC.Models.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Design;

    public class ModelExpressionBuilder<TBase> : IGenericModelExpressionBuilder<TBase>
        where TBase : class
    {
        private BindingOptions options;

        public ModelExpressionBuilder() 
        {
             options = new BindingOptions();
        }

        public IGenericModelExpressionBuilder<TBase> IncludeNames(params string[] names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> IncludeNames(IList<string> names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> IncludeTypes(params BindingType[] types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpressionBuilder<TBase> IncludeTypes(IList<BindingType> types)
        {
            throw new NotImplementedException();
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
