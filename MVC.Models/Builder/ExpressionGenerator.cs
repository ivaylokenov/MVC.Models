namespace MVC.Models.Builder
{
    using System;
    using System.Linq.Expressions;
    using Design;

    internal class ExpressionGenerator<TModel, TResult>
    {
        internal Expression<Func<TModel, TResult>> Build(IBindingOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
