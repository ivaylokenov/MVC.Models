namespace MVC.Models.Design
{
    public interface IModelExpression
    {
        IModelExpression Include(params string[] names);

        IModelExpression Include(params BindType[] types);

        IModelExpression Exclude(params string[] names);

        IModelExpression Exclude(params BindType[] types);
        
        IModelExpression Cachable(bool cachable);

        IModelExpression Cachable(string name);

        IModelExpression Category(string name);

        IModelExpression Categories(params string[] categories);
    }
}
