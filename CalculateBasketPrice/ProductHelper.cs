public class ProductHelper
{
    public static List<Product> SeedProduct(List<Product> productList)
    {
        productList.Add(new Product { Id = 1, Name = "PC", Price = 500, Group = 1 });
        productList.Add(new Product { Id = 2, Name = "Monitör", Price = 200, Group = 1 });
        productList.Add(new Product { Id = 3, Name = "Yazıcı", Price = 300, Group = 1 });
        productList.Add(new Product { Id = 4, Name = "Laptop", Price = 500, Group = 1 });
        productList.Add(new Product { Id = 5, Name = "Projeksiyon Cihazı", Price = 100, Group = 1 });
        productList.Add(new Product { Id = 6, Name = "Masa", Price = 200, Group = 2 });
        productList.Add(new Product { Id = 7, Name = "Sandalye", Price = 70, Group = 2 });
        productList.Add(new Product { Id = 8, Name = "Koltuk", Price = 100, Group = 2 });
        productList.Add(new Product { Id = 9, Name = "Sehpa", Price = 50, Group = 2 });
        productList.Add(new Product { Id = 10, Name = "Keson", Price = 50, Group = 2 });
        productList.Add(new Product { Id = 11, Name = "Eldiven", Price = 100, Group = 3 });
        productList.Add(new Product { Id = 12, Name = "Sedye", Price = 150, Group = 3 });
        productList.Add(new Product { Id = 13, Name = "Diş Ünitesi", Price = 600, Group = 3 });
        productList.Add(new Product { Id = 14, Name = "Ultrason Cihazı", Price = 700, Group = 3 });
        productList.Add(new Product { Id = 15, Name = "MR Cihazı", Price = 900, Group = 3 });

        return productList;
    }

}
