class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayi girin: ");
        int derinlik = int.Parse(Console.ReadLine());

        int[] fibonacci = new int[derinlik];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < derinlik; i++)
        {
            fibonacci[i] = fibonacci[i-1] + fibonacci[i - 2];
               
        }

        double toplam = 0;
        double ortalama = 0;
        for (int i = 0; i < derinlik; i++)
        {
            toplam += fibonacci[i];
            ortalama = toplam / derinlik;
        }
                Console.WriteLine("Ortalama: "+ ortalama);
    }       
}