using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program  // Programın başlayacağı ilk sınıf.
    {
        static void Main(string[] args) //Method. 
        {
            #region For Döngüsü

            //For(x;y;z)
            //x: başlangıç değeri
            //y: bitiş değeri
            //z: artış-azalışı gösterir


            //for (int i = 1; i <= 5; i++)
            //{
            //Console.WriteLine("C# İle Eğitim Kampı.");
            //}
            //Console.Read();
            #endregion

            #region For Döngüsü

            //for (int i = 1; i <= 20; i++)
            //{
            //Console.WriteLine(i);
            //}
            //Console.Read();
            #endregion

            #region For Döngüsü

            //for (int i = 3; i <= 50; i += 3)
            //{
            //Console.WriteLine(i);
            //}
            //Console.Read();
            #endregion


            #region For Döngüsü

            //Console.Write("Lütfen ekrana yazılması istediğiniz adedi giriniz: ");

            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
                //Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            //Console.Read();
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //if (i % 5 == 0)
            //{
            //Console.WriteLine(i);
            //}
            //}
            //Console.Read();
            #endregion


            #region For Döngüsü ile Karar Yapıları

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //totalValue += i;
            //}

            //Console.WriteLine(totalValue);
            //Console.Read();
            #endregion


            #region For Döngüsü ile Karar Yapıları

            int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //if (i % 2 == 0)
            //{
            //totalValue += i;
            //Console.WriteLine(i);
            //}
            //}

            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);
            //Console.Read();
            #endregion


            #region For Döngüsü ile Karar Yapıları

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //if (i % 7 == 0)
            //{
            //count++;
            //}
            //}
            //Console.WriteLine(count);
            //Console.Read();
            #endregion


            #region For Döngüsü ile Karar Yapıları

            //int bacterum = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //bacterum *= 2;
            //Console.WriteLine(I + “.Saat Sonunda: ” +bacterum);
            //}

            //Console.Read();
            #endregion



            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //Console.WriteLine("Merhaba Döngüler");
            //i++;
            //}

            //Console.Read();
            #endregion


            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //if (i % 3 == 0)
            //{
            //Console.WriteLine(i);
            //}
            //i++;
            //}

            //Console.Read();
            #endregion


            #region While Döngüsü

            //int sum = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //sum = sum + i;
            //i++;
            //}
            //Console.WriteLine(sum);
            //Console.Read();
            #endregion


            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayısını basamakları toplamını hesaplayan kodu yazınız.


            Console.WriteLine("3 Basmaklı Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;    // 4.56 —> 4

            Console.WriteLine(ones + "--" +tens + "--" + hundreds);

            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            Console.Read();
            #endregion

        }
    }
}


