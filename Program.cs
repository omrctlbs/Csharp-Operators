using System.Runtime.InteropServices;

namespace Operators;

class Program
{
    static void Main(string[] args)
    {
            string name;
            int age;
            int score;

            Console.WriteLine("Please enter your name : " );
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age : " );
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your score: ");
            score = Convert.ToInt32(Console.ReadLine());

            bool isAdult = (age >= 18);
            bool isHighScore = (score >= 80);

            Console.WriteLine("Hello" + " " + name);

            if (isAdult && isHighScore){
                Console.WriteLine("You are adult and high score");
            }
            else if (isAdult) {
                Console.WriteLine("You are adult");                
            }
            else if(isHighScore) {
                Console.WriteLine("You are high score");
            }
            else {
            Console.WriteLine("You are not an adult and do not have a high score.");
            }


            int doubledScore;
            doubledScore = score *=2;
            Console.WriteLine("Your score doubled: " + doubledScore);

    }
}
//AND (&&)
//OR (||)
//NOT (!)
//Açıklamalar:
//Değişken Tanımlama: Kullanıcı adı (name), yaş (age) ve puan (score) için değişkenler tanımlanır.
//Kullanıcı Girdisi: Console.ReadLine() ile kullanıcıdan bilgi alınır ve Convert.ToInt32() ile tam sayıya dönüştürülür.
//Yaş ve Puan Kontrolü: Yaşın 18 veya daha büyük olup olmadığı ve puanın 80'den büyük olup olmadığı kontrol edilir.
//Mantıksal Operatörler: Yaş ve puan kombinasyonları kullanılarak çeşitli mesajlar yazdırılır.
//Aritmetik İşlemler: Puanın iki katına çıkarılması ve sonucun yazdırılması işlemi yapılır.
//Eşitlik Kontrolü: Orijinal puanın, iki katına çıkarılmış puanın yarısına eşit olup olmadığı kontrol edilir ve sonuç yazdırılır.
//Bu uygulama, kullanıcıdan alınan verilerle basit matematiksel ve mantıksal işlemleri gösterir ve operatörlerin nasıl kullanıldığını anlamanıza yardımcı olur.







