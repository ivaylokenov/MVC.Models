namespace MVC.ViewModels.Design
{
    public interface IEmptyModelExpression
    {
        IGenericModelExpression<TModel> From<TModel>() where TModel : class;
    }
}
