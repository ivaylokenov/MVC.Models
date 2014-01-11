namespace MVC.Models.Design
{
    using System;
    using System.Linq.Expressions;
    using Design;

    public interface IGenericModelExpression<TModel> : IModelExpression
    {
        Expression<Func<TModel, TResult>> To<TResult>() where TResult : new();
    }
}
