using System;

namespace baitapvemang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ArrayDemo.TestDemo();
            Console.ReadKey();
            /*  Console.WriteLine("Bai tap ve mang \n");
              Console.WriteLine("Nhap so phan tu: ");
              int[] n = new int[10];//n la mot mang bao gom 10 so nguyen 
              int i, j;
              //khoi tao cac phan tu cua mang n
              for (i = 0; i < n.Length; i++)
              {
                  n[i] = i + 100;
              }    
              // hien thi cac gia tri phan tu cua mang
              for (j = 0; j < n.Length; j++)
              {
                  Console.WriteLine("phan tu [{0}] = {1}", j, n[j]);
              }   
              Console.ReadKey();*/
            /*Console.WriteLine("BAI TAP MANG 2 CHIEU!\n");
            Console.WriteLine("Moi ban nhap so dong cua mang: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so cot cua mang: "); ;
            int col = int.Parse(Console.ReadLine());
            //tao mang 2 chieu voi so dong va so cot da nhap
            int [,] IntArray = new int[row, col];
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.WriteLine("Moi ban nhap phan tu IntArray [{0},{1}] = ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum  = 0;
            Console.WriteLine("\n Mang ban vua nhap la: ");
            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write(IntArray[i, j] + " ");
                    sum += IntArray[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tong cac gia tri trong mang: " + sum);
            Console.ReadKey();*/
            int row, col;
            Console.Write("Nhap so dong: ");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            col = int.Parse(Console.ReadLine());
            int[,] IntArray = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Random random = new Random();
                    IntArray[i, j] = random.Next(IntArray[i, j]);
                }
            }
            Console.WriteLine("Mang sau khi xuat ngay nhien la: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Random random = new Random();
                    IntArray[i, j] = random.Next(IntArray[i, j]);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
