using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btOLO3
{
    class Program
    {
        //bai1
        public static int ptb2()
        {
            float a, b, c;
            float x1, x2;
               Console.Write("Nhap so a:");
               a = Convert.ToInt32(Console.ReadLine());
               Console.Write("Nhap so b:");
               b = Convert.ToInt32(Console.ReadLine());
               Console.Write("Nhap so c:");
               c = Convert.ToInt32(Console.ReadLine());
       

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.Write("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                }
                return 0;
            }

            float delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                x1 = x2 = 0;
                Console.Write("Phuong trinh vo nghiem!");
                return 0;
            }else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
                return 1;
            }
            else
            {
                delta = (float)Math.Sqrt(delta);
                x1 = (-b + delta) / (2 * a);
                x2 = (-b - delta) / (2 * a);
                Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
                return 2;
            }

        } 
        //bai2
        public static int Songuyento()
        {
            int n;
            Console.Write("Nhap so n:");
            n = Convert.ToInt32(Console.ReadLine());

            int f = 1;
            if (n < 2) return f = 0;

            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    f = 0;
                    break;
                }
                i++;
            }
            return f;

        }
        //bai3
        public static void MaTran()
        {
            Console.Write("Nhap N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            //nhap ma tran
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Arr[{i}][{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // in ma tran
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            // Kiểm tra ma trận có phải ma trận vuông hay không, nếu đúng hiển thị các phần tử thuộc
            // đường chéo chính và chéo phụ lên màn hình.

            if (m == n)
            {
                Console.Write("Duong cheo chinh cua ma tran la: ");
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (i == j)
                            Console.Write($"{arr[i, j]}");
                Console.WriteLine();
                Console.Write("Duong cheo phu cua ma tran la: ");
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (i+ j == n- 1)
                            Console.Write($"{arr[i, j]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ma tran khong vuong!");
            }
        }

        static void Main(string[] args)
        {
            //ptb2();
            //Songuyento();
            //int n;
            //int check = Songuyento();
            //if (check == 1)
            //{
            //    Console.Write(n + "la so nguyen to");
            //}
            //else
            //{
            //    Console.Write(n + "khong so nguyen to");
            //}

            MaTran();
           
            Console.ReadKey();
        }
    }
}
