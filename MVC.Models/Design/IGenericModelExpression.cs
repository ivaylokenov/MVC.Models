namespace MVC.Models.Design
{
    using System;
    using System.Linq.Expressions;

    public interface IGenericModelExpression<TBase> : IModelExpression
        where TBase : class
    {
        Expression<Func<TBase, TResult>> To<TResult>();
    }
}
