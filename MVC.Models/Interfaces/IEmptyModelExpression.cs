namespace MVC.ViewModels.Interfaces
{
    public interface IEmptyModelExpression
    {
        IGenericModelExpression<TModel> From<TModel>() where TModel : class;
    }
}
