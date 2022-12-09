using System.Runtime.InteropServices;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Merhaba Dünya!"); // print("Merhaba Dünya!", end=\n)
        Console.Write("Merhaba Dünya2!"); // print("Merhaba Dünya2!", end="")
        Console.Write("Merhaba Dünya3!");

        // Değişken Tanımlama
        // int, String, char, bool, double
        int sayi;
        sayi = 5;
        int sayi2 = 10;
        Console.WriteLine("1.Sayı " + sayi + " 2.Sayı " + sayi2);
        String metin = "Yazı";
        bool uzun = false;
        double sayi3 = 3.141592; // float

        // Kullanıcıdan veri alma
        // Console.ReadLine();
        // ToInt32() , ToString, Todouble...
        int a = 5; //Convert.ToInt32(Console.ReadLine());
        int b = 6; //Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);

        // Math
        double yenisayi = 28.6;
        double yenisayi2 = 13.4;
        yenisayi = Math.Round(yenisayi);
        Console.WriteLine(yenisayi);
        double min = Math.Min(yenisayi, yenisayi2);
        double max = Math.Max(yenisayi, yenisayi2);
        Console.WriteLine(min);
        Console.WriteLine(max);
        // üssünü almak
        double karesayi = Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);
        Console.WriteLine(karesayi);

        // karekökk
        double sayii = 49;
        double karekok = Math.Sqrt(sayii);
        Console.WriteLine(karekok);

        //Random
        Random zar = new Random();
        int zarsayi = zar.Next(1, 7);
        Console.WriteLine("Seçilen Sayı : " + zarsayi);

        //Hipotenüs hesaplayan kod
        Console.WriteLine("1.Dik Kenarı Giriniz: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2.Dik Kenarı Giriniz: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());
        double hipo = Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2));
        Console.WriteLine("1.Kenar: " + kenar1 + " 2.Kenar: " + kenar2 + " Hipotenüs: " + hipo);

        // Randomlu hipotenüs
        Random hpt = new Random();
        double k1 = hpt.Next(1, 101);
        double k2 = hpt.Next(1, 101);
        double hipotenus = Math.Sqrt(Math.Pow(k1, 2) + Math.Pow(k2, 2));
        Console.WriteLine("1.Kenar: " + k1 + " 2.Kenar: " + k2 + " Hipotenüs: " + hipotenus);

        // Daha yeni başlıyoruz: if, else if, else + switch ve case?  PAZARR

        Console.ReadKey();
    }
}