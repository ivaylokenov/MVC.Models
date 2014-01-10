namespace MVC.ViewModels.Interfaces
{
    using System;

    public interface IViewModelExpression
    {
        Type From { get; set; }

        Type To { get; set; }
    }
}
