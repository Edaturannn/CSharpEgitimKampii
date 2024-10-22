using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program  // Programın başlayacağı ilk sınıf.
    {
        static void Main(string[] args) //Method. 
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine("*");
            //}

            //Console.Read();
            #endregion


            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.Write("*");
            //}

            //Console.Read();
            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun.

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.Write("**********");
            //}

            //Console.Read();
            #endregion

            #region Dik üçgen oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //for (int j = 1; j <= i; j++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //}

            //Console.Read();
            #endregion


            #region Ters Dik üçgen oluşturma

            //for (int i = 5; i >= 1; i--)
            //{
            //for (int j = 1; j <= i; j++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //}
            //Console.Read();
            #endregion


            #region Dik üçgen ve ters dik üçgeni oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //for (int j = 1; j <= i; j++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //for (int m = 1; m <= k; m++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //}
            //Console.Read();
            #endregion



            #region Baklava dilimi oluşturma

            //üst kısım
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //for (int j = n - 1; j > 0; j--)
            //{
            //Console.Write(" ");
            //}

            //for (int k = 1; k <= 2 * i - 1; k++)
            //{
            //Console.Write("*");
            //}

            //Console.WriteLine();
            //}

            //alt kısım

            //for (int i = n - 1; i >= 1; i--)
            //{
            //for (int j = n - 1; j > 0; j--)
            //{
            //Console.Write(" ");
            //}

            //for (int k = 1; k <= 2 * i - 1; k++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //}
            //Console.Read();
            #endregion


            #region Piramit oluşturma

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //boşluk oluşturma
            //for (int j = n - i; j > 0; j--)
            //{
            //Console.Write(" ");
            //}

            //yıldız oluşturma
            //for (int k = 1; k <= 2 * i - 1; k++)
            //{
            //Console.Write("*");
            //}
            //Console.WriteLine();
            //}

            //Console.Read();
            #endregion


            #region Ters Piramit oluşturma

            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                //boşluk oluşturma
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //boşluk oluşturma
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
            #endregion
        }
    }
}


