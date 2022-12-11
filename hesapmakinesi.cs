class hesapmakinesi
{
    static void Main(String[] args)
    {
        Console.WriteLine("İşlem yazınız: ");
        String islem = (Console.ReadLine()).ToLower();
        switch (islem)
        {
            case "topla":
                Console.WriteLine("Sayıları giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                topla(sayi1, sayi2);
                break;

            case "cikar":
                Console.WriteLine("Sayıları giriniz: ");
                int sayi3 = Convert.ToInt32(Console.ReadLine());
                int sayi4 = Convert.ToInt32(Console.ReadLine());
                cikar(sayi3, sayi4);
                break;

            case "carp":
                Console.WriteLine("Sayıları giriniz: ");
                int sayi5 = Convert.ToInt32(Console.ReadLine());
                int sayi6 = Convert.ToInt32(Console.ReadLine());
                carp(sayi5, sayi6);
                break;

            case "bol":
                Console.WriteLine("Sayıları giriniz: ");
                int sayi7 = Convert.ToInt32(Console.ReadLine());
                int sayi8 = Convert.ToInt32(Console.ReadLine());
                bol(sayi7, sayi8);
                break;

            default:
                Console.WriteLine("Yanlış girişte bulundun!");
                break;
        }
    }

    static void topla(int x, int y)
    {
        x += y;
        Console.WriteLine("Sonuç:" + x);
    }

    static void cikar(int x, int y)
    {
        x -= y;
        Console.WriteLine("Sonuç:" + x);
    }

    static void carp(int x, int y)
    {
        x *= y;
        Console.WriteLine("Sonuç:" + x);
    }

    static void bol(int x, int y)
    {
        x /= y;
        Console.WriteLine("Sonuç:" + x);
    }
}