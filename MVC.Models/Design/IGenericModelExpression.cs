namespace MVC.Models.Design
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IGenericModelExpression<TBase>
        where TBase : class
    {
        IGenericModelExpression<TBase> Include(params string[] names);

        IGenericModelExpression<TBase> Include(IList<string> names);

        IGenericModelExpression<TBase> Include(params BindType[] types);

        IGenericModelExpression<TBase> Include(IList<BindType> types);

        IGenericModelExpression<TBase> Exclude(params string[] names);

        IGenericModelExpression<TBase> Exclude(IList<string> names);

        IGenericModelExpression<TBase> Exclude(params BindType[] types);

        IGenericModelExpression<TBase> Exclude(IList<BindType> types);

        IGenericModelExpression<TBase> Cachable(bool cachable);

        IGenericModelExpression<TBase> Category(string name);

        IGenericModelExpression<TBase> Categories(params string[] categories);

        IGenericModelExpression<TBase> Categories(IList<string> categories);

        Expression<Func<TBase, TResult>> To<TResult>();
    }
}
