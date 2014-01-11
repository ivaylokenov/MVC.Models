namespace MVC.Models.Builder
{
    using System;
    using System.Linq.Expressions;
    using Design;

    public class ExpressionGenerator<TBase, TResult> : IGenericExpressionGenerator<TBase, TResult>
        where TBase : class
        where TResult : class
    {
        private IBindingOptions bindingOptions;

        public ExpressionGenerator(IBindingOptions options)
        {
            bindingOptions = options;
        }

        public Expression<Func<TBase, TResult>> Build()
        {
            throw new NotImplementedException();
        }
    }
}
