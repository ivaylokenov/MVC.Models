namespace MVC.ViewModels.Design
{
    public interface IModelExpression
    {
        IModelExpression Include();

        IModelExpression Exclude();

        IModelExpression Cachable();

        IModelExpression Cachable(bool cachable);
    }
}
