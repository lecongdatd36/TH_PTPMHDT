using System;
using System.Collections.Generic;
using System.Linq;

namespace _1150080130_LECONGDAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" MENU ");
            Console.WriteLine("1. Tinh chu vi dien tich HCN");
            Console.WriteLine("2. Tim so lon hon trong 2 so");
            Console.WriteLine("3. Tim so lon nhat trong 3 so");
            Console.WriteLine("4. Cho biet thang co bao nhieu ngay");
            Console.WriteLine("5. Kiem tra tinh chan le va am duong");
            Console.WriteLine("6. Chu vi va dien tich HCN (double)");
            Console.WriteLine("7. Kiem tra 3 canh co tao tam giac khong");
            Console.WriteLine("8. Giai phuong trinh bac 2");
            Console.WriteLine("9. Tong cac phan tu trong mang");
            Console.WriteLine("10. Sap xep Selection Sort tu file");
            Console.WriteLine("11. Chen phan tu vao mang da sap tang");
            Console.Write("Moi chon: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: TinhChuViDienTich(); break;
                case 2: Tinhtong(); break;
                case 3: TimSoLonNhat(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 11: Bai11(); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }
        }

        static void TinhChuViDienTich()
        {
            Console.Write("Nhap chieu dai: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double fl = (a + b) * 2;
            double S = a * b;

            Console.WriteLine("Chu vi = " + fl);
            Console.WriteLine("Dien tich = " + S);
        }

        static void Tinhtong()
        {
            Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;
            Console.WriteLine("So lon hon = " + max);
        }

        static void TimSoLonNhat()
        {
            Console.Write("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine("So lon nhat = " + max);
        }

        static void Bai4()
        {
            Console.Write("Nhap thang (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int days = DateTime.DaysInMonth(year, month);
            Console.WriteLine("Thang {0}/{1} co {2} ngay", month, year, days);
        }

        static void Bai5()
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n % 2 == 0 ? "n la so chan" : "n la so le");
            Console.WriteLine(n < 0 ? "n la so am" : "n la so khong am");
        }

        static void Bai6()
        {
            Console.Write("Nhap chieu dai: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double cv = 2 * (a + b);
            double dt = a * b;

            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Dien tich = " + dt);
        }

        static void Bai7()
        {
            Console.Write("Nhap canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double p = (a + b + c) / 2;
                double dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Chu vi = " + (a + b + c));
                Console.WriteLine("Dien tich = " + dt);
            }
            else
            {
                Console.WriteLine("Khong tao thanh tam giac");
            }
        }

        static void Bai8()
        {
            Console.Write("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Vo so nghiem" : "Vo nghiem");
                else
                    Console.WriteLine("x = " + (-c / b));
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("Vo nghiem");
                else if (delta == 0) Console.WriteLine("Nghiem kep x = " + (-b / (2 * a)));
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                }
            }
        }

        static void Bai9()
        {
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int x in arr) sum += x;
            Console.WriteLine("Tong = " + sum);
        }

        static void Bai10()
        {
            string[] data = System.IO.File.ReadAllText("input_array.txt")
                .Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = Array.ConvertAll(data, int.Parse);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min]) min = j;

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            Console.WriteLine("Mang sau sap xep: " + string.Join(" ", arr));
        }

        static void Bai11()
        {
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            Console.WriteLine("Mang tang: " + string.Join(" ", arr));

            Console.Write("Nhap so can chen: ");
            int x = Convert.ToInt32(Console.ReadLine());

            List<int> list = arr.ToList();
            int pos = list.BinarySearch(x);
            if (pos < 0) pos = ~pos;
            list.Insert(pos, x);

            Console.WriteLine("Mang sau chen: " + string.Join(" ", list));
        }
    }
}
