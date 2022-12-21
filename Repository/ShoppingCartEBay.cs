namespace MultipleInterfaceImplementation.Repository
{
    public class ShoppingCartEBay : IShoppingCart
    {
        public object GetCart()
        {
            return $"item from Bay";
        }
    }
}
