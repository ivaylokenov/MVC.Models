namespace MVC.ViewModels.Interfaces
{
    public interface IFluentViewModel
    {
        IFluentViewModel Cachable();

        IFluentViewModel Include();

        IFluentViewModel Exclude();
    }
}
