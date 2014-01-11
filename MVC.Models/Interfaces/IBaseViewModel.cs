namespace MVC.ViewModels.Interfaces
{
    public interface IBaseViewModel<TModel> where TModel : class
    {
        TModel GetEntityModel(TModel entity = null);
    }
}
