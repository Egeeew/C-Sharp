using System.Net.Http.Headers;
using System.Runtime.InteropServices;

class program2
{
    static void Main(String[] args)
    {
        // if, else if, else

        int sayi1 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 == 0)
        {
            Console.WriteLine("Null girmeye çalıştıysan olmadı");
        }

        else if (sayi1 < 0) 
        {
            Console.WriteLine("Negatif değer");
        }

        else
        {
            Console.WriteLine("Pozitif değer");
        }

        // switch - case - default olayları
        // birden fazla else if yazmak yerine yapılıyor if=else if=case, else=default

        Console.WriteLine("Gün gir: ");
        String gun = Console.ReadLine();

        switch(gun)
        {
            case "Pazartesi":
                Console.WriteLine("Bugün pazartesi");
                break;

            case "Salı":
                Console.WriteLine("Bugün salı");
                break;

            case "Çarşamba":
                Console.WriteLine("Bugün çarşamba");
                break;
            
            case "Perşembe":
                Console.WriteLine("Bugün perşembe");
                break;
            
            case "Cuma":
                Console.WriteLine("Bugün Cuma");
                break;
            
            case "Cumartesi":
                Console.WriteLine("Bugün Cumartesi");
                break;
            
            case "Pazar":
                Console.WriteLine("Bugün Pazar");
                break;

            default:
                Console.WriteLine("Yanlış giriş..?");
                break;
        }

        // && (and) ve || (or)

        int sayi2 = Convert.ToInt32(Console.ReadLine());
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 == 0 && sayi3 == 0)
        {
            Console.WriteLine("İkisi de 0");
        }

        else if (sayi2 < 0 || sayi3 < 0)
        {
            Console.WriteLine("En az biri 0'dan küçük");
        }

        else if (sayi2 > 0 || sayi3 > 0)
        {
            Console.WriteLine("En az biri 0'dan büyük");
        }

        else
        {
            Console.WriteLine("Else durumuna düştü");
        }

        // gibi çoğaltılabilir

        // while döngüsü
        // (sağla(ma)dığı sürece yap)

        Console.WriteLine("İsminiz: ");
        String isim = Console.ReadLine();

        while (isim == "")
        {
            Console.WriteLine("İsminiz: ");
            isim = Console.ReadLine();
        }

        Console.WriteLine("Yaşınız: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        while (yas < 0)
        {
            Console.WriteLine("Yaşınız: ");
            yas = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(yas+ " yaşındaki " + isim + " merhaba!");

        // do-while döngüsü
        // (yap - olana kadar)
        // sayı tahmin oyunu

        Random sayi = new Random();
        int istenen = sayi.Next(1, 31);
        int tahminsay = 0;
        do
        {
            Console.WriteLine("Tuttuğum sayıyı tahmin et (1,30): ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (istenen == tahmin)
            {
                Console.WriteLine("Tebrikler, bildin!");
                break;
            }

            else if (istenen > tahmin)
            {
                Console.WriteLine("Daha büyük bir sayı dene!");
                tahminsay += 1;
            }

            else
            {
                Console.WriteLine("Daha küçük bir sayı dene!");
                tahminsay += 1;
            }
        } while (tahminsay < 10);
        Console.WriteLine(tahminsay + " denemede " + istenen + " sayısını doğru bildin.");

        // for döngüsü

        for (int i = 15; i > -1; i--)
        {
            Console.WriteLine(i);
        }

        // arrayler (python'un listeleri)
        // foreach döngüsü
        String[] dersler = { "Matematik", "Biyoloji", "Kimya", "Fizik" };

        dersler[0] = "Edebiyat";
        Console.WriteLine(dersler[0]);

        foreach (String ders in dersler)
        { 
            Console.WriteLine(ders); 
        }

        // .Length nedir nasıl kullanılır
        int uzunluk = dersler.Length;
        Console.WriteLine("Uzunluk: " + uzunluk);

        Console.ReadKey();
    }
}