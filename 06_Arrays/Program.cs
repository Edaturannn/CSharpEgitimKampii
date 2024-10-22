using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace _06_Arrays
{
    internal class Program  // Programın başlayacağı ilk sınıf.
    {
        static void Main(string[] args) //Method. 
        {
            #region Temel Dizi Örnekleri 

            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı" ;
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //Console.Read();
            #endregion


            #region Temel Dizi Örnekleri 

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //Console.Read();
            #endregion


            #region Temel Dizi Örnekleri 

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //Console.Read();
            #endregion

            //Atama yapılmamış elemana 0 yazar.


            #region Temel Dizi Örnekleri 

            //string[] cities = { "Prag" , "Rome" , "Atina" , "Ankara" , "Bursa"};

            //Console.WriteLine(cities[2]);

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı" , "Kırmızı" , "Beyaz" , "Mavi" , "Yeşil" , "Turuncu" , "Pembe"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //Console.WriteLine(colors[i]);
            //}

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //if (numbers[i] % 3 == 0)
            //{
            //Console.WriteLine(numbers[i]);
            //}
            //}

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme


            //char[] symbols = { 'a' , 'b' , 'c' , '*' , '/' , '-'};
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //Console.WriteLine(symbols[i]);
            //}

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //Dizideki en büyük elemanı bulan program.

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //if (myArray[i] > maxNumber)
            //{
            //maxNumber = myArray[i];
            //}
            //}

            //Console.WriteLine(maxNumber);
            //Console.Read();
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //Dizi methodları.

            //string[] persons = { "ali", "ahmet" , "ayşe" ,"cem" ,"buse" , "deniz"};

            //Console.WriteLine(persons.Length);

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme
            //Dizi methodları. Sıralama

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //Console.WriteLine(numbers[i]);
            //}

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme
            //Dizi methodları. 

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya"};

            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(index);

            //Console.Read();
            #endregion


            #region Dizideki Tüm Elemanları Listeleme
            //Dizi methodları. 

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Console.WriteLine("Dizin in En Büyük Elemını: " +numbers.Max() + "Dizinin En Küçük Elemanı: " +numbers.Min());

            //Console.Read();
            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //Console.Write($"Lütfen {i + 1}. Şehiri Giriniz: ");
            //cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //Console.WriteLine(cities[i]);
            //}
            //Console.Read();
            #endregion


            #region Kullanıcıdan Değer Alma

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            //Console.Read();
            #endregion


            #region Kullanıcıdan Değer Alma

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            Console.WriteLine("---------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.Read();
            #endregion
        }
    }
}



