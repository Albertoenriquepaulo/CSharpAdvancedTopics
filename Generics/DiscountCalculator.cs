using System;

namespace Generics
{

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price * 1 / 3;
        }
    }

}
