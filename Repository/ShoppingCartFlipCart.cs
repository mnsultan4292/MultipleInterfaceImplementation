namespace MultipleInterfaceImplementation.Repository
{
    public class ShoppingCartFlipCart : IShoppingCart
    {
        public object GetCart()
        {
            return $"item from Flipcart";
        }
    }
}
