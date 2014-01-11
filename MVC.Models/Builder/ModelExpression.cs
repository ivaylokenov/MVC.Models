namespace MVC.Models.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Design;

    public class ModelExpression<TBase> : IGenericModelExpression<TBase>
        where TBase : class
    {
        public IGenericModelExpression<TBase> Include(params string[] names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Include(IList<string> names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Include(params BindType[] types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Include(IList<BindType> types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Exclude(params string[] names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Exclude(IList<string> names)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Exclude(params BindType[] types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Exclude(IList<BindType> types)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Cachable(bool cachable)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Category(string name)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Categories(params string[] categories)
        {
            throw new NotImplementedException();
        }

        public IGenericModelExpression<TBase> Categories(IList<string> categories)
        {
            throw new NotImplementedException();
        }
        public Expression<Func<TBase, TResult>> To<TResult>()
        {
            throw new NotImplementedException();
        }
    }
}
