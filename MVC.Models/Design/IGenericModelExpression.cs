namespace MVC.Models.Design
{
    using System;
    using System.Linq.Expressions;

    public interface IGenericModelExpression<TModel> : IModelExpression
    {
        Expression<Func<TModel, TResult>> To<TResult>() where TResult : new();
    }
}
