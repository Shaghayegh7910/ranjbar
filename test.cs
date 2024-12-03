public class ProductPriceChecker
{
    public void CheckPrices()
    {
        Console.Write("لطفا تعداد محصولات را وارد کنید: ");
        int productCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < productCount; i++)
        {
            Console.Write("لطفا قیمت محصول  را وارد کنید: ", i + 1);
            int price = int.Parse(Console.ReadLine());

            if (price >= 1000)
            {
                Console.WriteLine("very Expensive");
            }
            else if (price >= 900)
            {
                Console.WriteLine("Expensive");
            }
            else if (price >= 700)
            {
                Console.WriteLine("Good");
            }
            else if (price >= 600)
            {
                Console.WriteLine("very good");
            }
            else if (price >= 500)
            {
                Console.WriteLine("cheep");
            }
            else
            {
                Console.WriteLine("very cheep");
            }
        }
    }
}