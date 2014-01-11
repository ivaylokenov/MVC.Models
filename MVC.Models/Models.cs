namespace MVC.Models
{
    using Builder;
    using Design;

    public static class Models
    {
        public static IGenericModelExpression<TBase> From<TBase>() where TBase : class
        {
            return new ModelExpression<TBase>();
        }
    }
}
