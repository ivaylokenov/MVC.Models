namespace MVC.Models.Design
{
    public interface IEmptyModelExpression
    {
        IGenericModelExpression<TBase> From<TBase>() where TBase : class;
    }
}
