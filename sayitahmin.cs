class sayitahmin
{
    static void Main(String[] args)
    {
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
    }
}