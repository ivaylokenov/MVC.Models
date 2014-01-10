namespace MVC.ViewModels.Interfaces
{
    public interface IGenericFluentViewModel<TModel, TViewModel> : IFluentViewModel
        where TModel : class
        where TViewModel : class
    {
        IFluentViewModel From();

        IFluentViewModel To();
    }
}
