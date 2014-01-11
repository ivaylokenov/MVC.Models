namespace MVC.Models.Design
{
    public interface IEmptyModelExpression
    {
        IGenericModelExpression<TModel> From<TModel>() where TModel : class;
    }
}
