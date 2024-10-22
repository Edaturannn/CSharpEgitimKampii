using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
namespace _07_ForeachLoop
{
    internal class Program  // Programın başlayacağı ilk sınıf.
    {
        static void Main(string[] args) //Method. 
        {
            #region Foreach Döngüsü


            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova"};

            //foreach (string x in cities)
            //{
            //Console.WriteLine(x);
            //}


            //Console.Read();
            #endregion

            #region Foreach Döngüsü

            //int[] numbers = { 45, 78, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //Console.WriteLine(number);
            //}
            //Console.Read();
            #endregion

            #region Foreach Döngüsü

            //int[] numbers = { 45, 78, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //if (number % 2 == 0)
            //{
            //Console.WriteLine(number);
            //}
            //}
            //Console.Read();
            #endregion

            #region Foreach Döngüsü

            //int[] numbers = { 45, 78, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //total += i;
            //}
            //Console.WriteLine(total);
            //Console.Read();
            #endregion


            #region Foreach Döngüsü

            //List<int> numbers = new List<int>() //Liste oluşturduk.
            //{
            //1, 2, 3, 4, 5, 8
            //};

            //foreach (int number in numbers)
            //{
            //Console.WriteLine(number);
            //}
            //Console.Read();
            #endregion

            #region Foreach Döngüsü

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //Console.WriteLine(c);
            //}
            //Console.Read();
            #endregion




            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{ i + 1}. Öğrencinin ismini giriniz: ");

                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. Sınav notunu giriniz: ");

                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value; //notları topluyoruz.
                }
                Console.WriteLine();
				studentExamAvg[i] = totalExamResult / 3;
			}

			//Sınav ortalamaları

			for(int i = 0; i<studentCount; i++)	
			{
                Console.WriteLine($"{studentNames[i]} isimli ortalamsı: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve gecip kalma durumları

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
                }

                Console.WriteLine("---------------------------------");

			}	
			Console.Read();
			#endregion
        }
    }
}



