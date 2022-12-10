class Main
{
    static void Main(string[] args)
    {
        // Random ile sayı çekmek
        Random random = new Random();
        int sayi = random.Next(1, 999);
        Console.WriteLine("Seçilen sayı: " + sayi);

        // Üçgen hipotenüsü hesaplayan bir C# kodu
        Console.WriteLine("1.Dik Kenarı Giriniz: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2.Dik Kenarı Giriniz: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());
        double hipo = Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2));
        Console.WriteLine("1.Kenar: " + kenar1 + " 2.Kenar: " + kenar2 + " Hipotenüs: " + hipo);

        // Birleşik Yapı (Hipotenüs bulma ama Random ile)
        Random hpt = new Random();
        double k1 = hpt.Next(1, 101);
        double k2 = hpt.Next(1, 101);
        double hipotenus = Math.Sqrt(Math.Pow(k1, 2) + Math.Pow(k2, 2));
        Console.WriteLine("1.Kenar: " + k1 + " 2.Kenar: " + k2 + " Hipotenüs: " + hipotenus);
        Console.ReadKey();
    }
}
