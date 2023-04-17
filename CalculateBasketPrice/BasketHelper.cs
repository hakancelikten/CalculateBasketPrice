public class BasketHelper
{
    public static List<Basket> CalculateDiscount(List<Basket> basketList)
    {
        foreach (var basket in basketList)
        {
            if (basket.Quantity == 1)
            {
                basket.DiscountedAmount = basket.TotalAmount;
            }
            else
            {
                var BasketGroup = basketList.Where(x => x.Product.Group == basket.Product.Group);

                double basketGroupTotalAmount = BasketGroup.Sum(x => x.TotalAmount);

                if (basketGroupTotalAmount > 0.1 && basketGroupTotalAmount <= 1000)
                {
                    basket.DiscountedAmount = basket.TotalAmount;
                }
                else if (basketGroupTotalAmount > 1000 && basketGroupTotalAmount <= 2000)
                {
                    basket.DiscountedAmount = basket.TotalAmount - basket.TotalAmount * 1 / 100;

                }
                else if (basketGroupTotalAmount > 2000 && basketGroupTotalAmount <= 3000)
                {
                    basket.DiscountedAmount = basket.TotalAmount - basket.TotalAmount * 2 / 100;

                }
                else if (basketGroupTotalAmount > 3000 && basketGroupTotalAmount <= 4000)
                {
                    basket.DiscountedAmount = basket.TotalAmount - basket.TotalAmount * 3 / 100;

                }
                else if (basketGroupTotalAmount > 4000 && basketGroupTotalAmount <= 5000)
                {
                    basket.DiscountedAmount = basket.TotalAmount - basket.TotalAmount * 4 / 100;

                }
                else if (basketGroupTotalAmount > 5000 && basketGroupTotalAmount <= 6000)
                {
                    basket.DiscountedAmount = basket.TotalAmount - basket.TotalAmount * 5 / 100;

                }
                else if (basketGroupTotalAmount > 6000 && basketGroupTotalAmount <= 7000)
                {
                    basket.DiscountedAmount = basket.TotalAmount - basket.TotalAmount * 6 / 100;

                }
                else { basket.DiscountedAmount = basket.TotalAmount; }
            }
        }
        return basketList;
    }

}
