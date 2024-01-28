namespace MultipleInterfaceImplementation.Repository.Common
{
    public class CommonFactoryRepo : ICommonFactoryRepo
    {
        private readonly IEnumerable<IShoppingCart> _shoppingCarts;
        public CommonFactoryRepo(IEnumerable<IShoppingCart> shoppingCarts)
        {
            _shoppingCarts = shoppingCarts;
        }

        public IShoppingCart GetInstance(string token)
        {
            return token switch
            {
                "Amazon" => this.GetService(typeof(ShoppingCartAmazon)),
                "EBay" => this.GetService(typeof(ShoppingCartEBay)),
                "FlipCart" => GetService(typeof(ShoppingCartFlipCart)),
                _ => throw new InvalidOperationException()
            };
        }

        public IShoppingCart GetService(Type type)
        {
            return _shoppingCarts.FirstOrDefault(x => x.GetType() == type)!;
        }
    }
}
