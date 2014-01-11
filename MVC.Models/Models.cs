namespace MVC.Models
{
    using Builder;
    using Design;

    public static class Models
    {
        public static IGenericModelExpressionBuilder<TBase> From<TBase>() where TBase : class
        {
            return new ModelExpressionBuilder<TBase>();
        }
    }
}
