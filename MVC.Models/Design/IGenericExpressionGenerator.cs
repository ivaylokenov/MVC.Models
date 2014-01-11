namespace MVC.Models.Design
{
    using System;
    using System.Linq.Expressions;

    public interface IGenericExpressionGenerator<TBase, TResult> : IExpressionGenerator
        where TBase : class
        where TResult : class 
    {
        Expression<Func<TBase, TResult>> Build();
    }
}
