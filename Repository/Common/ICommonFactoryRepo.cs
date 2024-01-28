namespace MultipleInterfaceImplementation.Repository.Common
{
    public interface ICommonFactoryRepo
    {
        IShoppingCart GetInstance(string token);
    }
}
