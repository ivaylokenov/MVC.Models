namespace MVC.Models.Design
{
    using System.Collections.Generic;

    public interface IModelExpression
    {
        IModelExpression Include(params string[] names);

        IModelExpression Include(IList<string> names);
        
        IModelExpression Include(params BindType[] types);

        IModelExpression Include(IList<BindType> types);

        IModelExpression Exclude(params string[] names);

        IModelExpression Exclude(IList<string> names);

        IModelExpression Exclude(params BindType[] types);

        IModelExpression Exclude(IList<BindType> types);
        
        IModelExpression Cachable(bool cachable);

        IModelExpression Cachable(string name);

        IModelExpression Category(string name);

        IModelExpression Categories(params string[] categories);

        IModelExpression Categories(IList<string> categories);
    }
}
