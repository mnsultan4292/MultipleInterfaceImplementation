namespace MultipleInterfaceImplementation.Repository
{
    public class ShoppingCartAmazon :IShoppingCart
    {
        public object GetCart()
        {
            return $"item from Amazon";
        }
    }
}
