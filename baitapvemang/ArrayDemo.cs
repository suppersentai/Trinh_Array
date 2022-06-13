using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvemang
{
    public class ArrayDemo
    {
        public static void TestDemo()
        {
            do
            {
                Console.Write("Nhap bai ban muon chay demo: ");
                string bai = Console.ReadLine();
                if (bai == "1") bai1();
                else if (bai == "2") bai2();
                else if (bai == "3") bai3();
            } while(true);
            Console.ReadKey();  
            static void bai1()
            {
                Console.WriteLine("Nhap va xuat cac gia tri ma gia tri tai do la gia tri am mang mot chieu cac so thuc!\n");
                int n = InputNumber("Nhap so phan tu ban muon nhap: ");
                float[] array = new float[n];
                //nhap gia tri phan tu cho mang
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("array [{0}]: ", i);
                    array[i] = float.Parse(Console.ReadLine());
                }
                //xuat gia tri phan tu cho mang
                Console.Write("Gia tri phan tu cua mang la: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("-" + array[i] + " ");
                }
                Console.ReadKey();
            }
            static void bai2()
            {
                Console.WriteLine("Nhap va xuat cac gia tri chan trong mang mot chieu cac so nguyen!\n");
                int n = InputNumber("Nhap so phan tu ban muon nhap: ");
                int[] array = new int[n];
                //nhap gia tri phan tu cho mang
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("arry [{0}]: ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }
                // xuat gia tri chan trong phan tu cua mang
                Console.Write("Gia tri cac phan tu cua mang la: ");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        Console.Write(array[i] + " ");
                    }
                    else Console.WriteLine("Khong co gia tri chan!");break;
                }               
                Console.ReadKey();
            }
            static void bai3()
            {
                Console.WriteLine("Tim gia tri lon nhat trong mang mot chieu cac so thuc!");
                int n = InputNumber("Nhap vao so phan tu ban muon nhap: ");
                float [] array = new float[n];
                //nhap gia tri phan tu cho mang
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("array [{0}]: ", i);
                    array[i]=float.Parse(Console.ReadLine());
                }
                //xuat gia tri lon nhat trong mang
                float max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                           
                    }
                    Console.WriteLine("Gia tri lon nhat la {0} ",array[i]);
                }
                Console.ReadKey();
            }    
            static int InputNumber(string text)
            {
                int val = 0;
                while (val == 0)
                {
                    Console.Write(text);
                    var input = Console.ReadLine();
                    int.TryParse(input.ToString(), out val);
                    if (val != 0) return val;
                }
                return 0;
            }

        }
    }
}
