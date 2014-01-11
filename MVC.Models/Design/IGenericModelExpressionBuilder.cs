namespace MVC.Models.Design
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IGenericModelExpressionBuilder<TBase>
        where TBase : class
    {
        IGenericModelExpressionBuilder<TBase> IncludeNames(params string[] names);

        IGenericModelExpressionBuilder<TBase> IncludeNames(IList<string> names);

        IGenericModelExpressionBuilder<TBase> IncludeTypes(params BindingType[] types);

        IGenericModelExpressionBuilder<TBase> IncludeTypes(IList<BindingType> types);

        IGenericModelExpressionBuilder<TBase> ExcludeNames(params string[] names);

        IGenericModelExpressionBuilder<TBase> ExcludeNames(IList<string> names);

        IGenericModelExpressionBuilder<TBase> ExcludeTypes(params BindingType[] types);

        IGenericModelExpressionBuilder<TBase> ExcludeTypes(IList<BindingType> types);

        IGenericModelExpressionBuilder<TBase> Cachable(bool cachable);

        IGenericModelExpressionBuilder<TBase> Category(string name);

        IGenericModelExpressionBuilder<TBase> Categories(params string[] categories);

        IGenericModelExpressionBuilder<TBase> Categories(IList<string> categories);

        Expression<Func<TBase, TResult>> To<TResult>();
    }
}
