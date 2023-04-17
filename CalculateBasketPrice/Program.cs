class Program
{
    static void Main(string[] args)
    {
        List<Product> productList = ProductHelper.SeedProduct(new List<Product>());

        List<Basket> basketList = new List<Basket>();

        Random random = new Random();

        while (basketList.Count < 8)
        {
            int randomProductId = random.Next(1, 15);

            var basket = basketList.SingleOrDefault(x => x.Product.Id == randomProductId);

            if (basket == default(Basket))
            {
                var randomQuantity = random.Next(1, 10);

                var product = productList.Single(x => x.Id == randomProductId);

                basketList.Add(
                    new Basket
                    {
                        Product = product,
                        Quantity = randomQuantity,
                        TotalAmount = product.Price * randomQuantity
                    });

            }
        }

        basketList = BasketHelper.CalculateDiscount(basketList);

        foreach (var basket in basketList)
        {
            Console.WriteLine($"Ürün: {basket.Product.Name}     Ürün Grubu: {basket.Product.Group}     Birim Fiyat: {basket.Product.Price} TL    Sipariş Adet: {basket.Quantity}   Toplam: {basket.TotalAmount} TL    İndirimli Tutar: {basket.DiscountedAmount} TL");
        }
        Console.WriteLine($"Sepet Tutarı: {basketList.Sum(x => x.DiscountedAmount)} TL");

        Console.ReadKey();
    }
}