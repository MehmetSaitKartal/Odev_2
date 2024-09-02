namespace Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = SayiUret();
            DiziYazdir(dizi);
            Console.WriteLine($"En Büyük Değer: {EnBuyukDeger(dizi)}");
            Console.WriteLine($"En Küçük Değer: {EnKucukDeger(dizi)}");
        }
        static int[] SayiUret()
        {
            int[] dizi = new int[10];
            Random r = new Random();

            for ( int i = 0; i < dizi.Length; i++ )
            {
                try
                {
                    Console.WriteLine($"Lütfen {i + 1}. Sayıyı Giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    dizi[i] = r.Next(0, sayi + 1); 
                } 
                catch(FormatException )
                {
                    Console.WriteLine("Lütfen Geçerli Bir Sayı Girin ");
                    i--;
                }
            }
            return dizi;
        }
        static void DiziYazdir(int[] dizi)
        {
            Console.WriteLine("Dizinin Elemanları:");
            foreach ( int sayi in dizi )
            {
                Console.WriteLine(sayi);
            }
        }
        static int EnBuyukDeger(int[] dizi)
        {
            int EnBuyuk=dizi[0];

            foreach ( int sayi in dizi)
            {
                if ( sayi > EnBuyuk)
                {
                    EnBuyuk = sayi;
                }
            }
            return EnBuyuk;
        }
        static int EnKucukDeger( int[] dizi)
        {
            int EnKucuk=dizi[0];

            foreach( int sayi in dizi)
            {
                if( sayi < EnKucuk)
                {
                    EnKucuk = sayi;
                }
            }
            return EnKucuk;
        }
    }
}
