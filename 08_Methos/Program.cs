using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using System.Dynamic;

namespace _08_Methos
{
    internal class Program  // Programın başlayacağı ilk sınıf.
    {
        static void Main(string[] args) //Method. 
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer —> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList() //Geriye değer döndürmeyen metotlar.
            //{
            //Console.WriteLine("Ali Yıldız");
            //Console.WriteLine("Ayşe Yıldız");
            //Console.WriteLine("Hakan Öztürk");
            //Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //Console.Read();
            #endregion

            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer —> Listele, ekle, sil, güncelle
            //Void

            //void Sum() //Geriye değer döndürmeyen metotlar.
            //{
            //int x = 1;
            //int y = 2;
            //int z = x + y;
            //Console.WriteLine(z);
            //}

            //Sum();
            //Console.Read();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{
            //Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");
            //Console.Read();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void CustomerCard(string name, string surName)
            //{
            //Console.WriteLine("Müşteri: " +name + " " +surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            //Console.Read();
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //int result = number1 + number2 + number3;
            //Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            //Console.Read();
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //return "Buse Yıldız";
            //}
            //CustomerName();


            //Console.ReadLine();
            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //string name = "Ali";
            //string surname = "Kaya";
            //return name + " " +surname;
            //}
            //Console.WriteLine(StudentCard());

            //Console.Read();
            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //string cardInfo = "Ülke: " + countryName + " -Basket: " + capital + " -Bayrak Rengi: " + flagColor;

            //return cardInfo;

            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            //Console.Read();
            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //int result = number1 + number2;
            //return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(98, 67));

            //Console.WriteLine(Sum(75, 8));
            //Console.WriteLine(Sum(43, 2));

            //Console.Read();
            #endregion


            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti." + "Ortalama: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci Başarısız Oldu." + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 45, 65, 100));
            Console.Read();

            #endregion
        }
    }
}



