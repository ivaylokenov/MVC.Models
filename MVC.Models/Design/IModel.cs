namespace MVC.Models.Design
{
    public interface IModel<TModel>
        where TModel : class, new()
    {
        TModel ConvertToBase(TModel model = null);
    }
}
