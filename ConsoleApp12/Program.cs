
internal class Program
{
    //Geriye Değer Döndürmeyen Bir void metot.

    static void Sarkı()
    {
        Console.WriteLine("Akşamlar bir roman gibi biterdi, \r\nJezabel kan içinde yatardı, \r\nLimandan bir gemi giderdi, \r\nSen, kalkıp ona giderdin...");

    }

    static void Main(string[] args)
    {
        Sarkı();
    }

    //Geriye Tamsayı Döndüren Bir metot
    int result = Sayilar();

    static int Sayilar(int min = 1, int max = 100)
    {
        Random random = new Random();
        int randomSayi = random.Next(min, max);
        Console.WriteLine("\nRastgele Üretilen Sayı: " + randomSayi);
        return randomSayi % 2;

    }
    //Parametre Alan ve geriye deper döndüren bir metot
    static void Main()
    {
        int result = carpım(4, 5);
        Console.WriteLine(" Carpım: " + result);

        static int carpım = ({ a},{ b});
        {
            return (a * b);

        }
    }
}




//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

class Program3 {
    static void Main() {
        GreetUser("Melisa", "Kılıç");
        static void GreetUser(string name, string soyName)
        {
            Console.WriteLine("Hoş geldiniz, " + name + soyName + "!");
        }
    } }

       


    
    
 


    

    
        





