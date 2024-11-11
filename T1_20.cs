using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan
{
    public class T1_20
    {
        //ve hcn
        Ham h1 = new Ham();
        public void Bai1()
        {
            int length = 8, width = 5;
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //vẽ hcn rỗng
        public void Bai2()
        {
            int length = 8, width = 5;
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //vẽ bảng cửu chương
        public void Bai3()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    Console.Write($"{j}*{i} = {j * i} \t");
                }
                Console.WriteLine();
            }
        }
        //vẽ tam giác vuông góc trái dưới
        public void Bai4()
        {
            int h = 10;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        //vẽ tam giác vuông trái bên trên
        public void Bai5()
        {
            int h = 10;
            for (int i = h; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        //vẽ tam giác vuông phải dưới
        public void Bai6()
        {
            int h = 10;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (i > (h - j))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }
        //vẽ tam giác vuông phải trên
        public void Bai7()
        {
            int h = 10;
            for (int i = h; i >= 1; i--)
            {
                for (int j = 1; j <=h ; j++)
                {
                    if (j > (h - i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }

        }
        //tam giác đối xứng
        public void Bai8()
        {
            int h = 10;
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=2*h; j++)
                {
                    if (i > Math.Abs(h - j))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //tam giác số đối xứng

        public void Bai9()
        {
            int h = 10;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 2 * h; j++)
                {
                    if (i > Math.Abs(h - j))
                    {
                        Console.Write($"{Math.Abs(h-j)}");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //tam giác số rỗng
        public void Bai10()
        {
            int h = 10;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= 2 * h; j++)
                {
                    if (( Math.Abs(h - j)==(i- 1))||i==h)
                    {
                        Console.Write($"1");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //tìm giá trị lớn thứ 2 trong mảng
        public void Bai11()
        {
            int[] n = { 3, 5, 12, 11, 34, 56,57, 76 };
            int max = n.Max();
            int max2 = n.Min();
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > max2 && n[i] != max)
                {
                    max2 = n[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Max 2 = {max2}");
        }
        //nổi bọt 
        public void Bai12()
        {
            
            int[] n = { 3, 5, 12, 11, 34, 56, 57, 76,1 ,0,-110};
            foreach (var item in n)
            {
                Console.Write(item +"\t");
            }
            for (int i = 0; i < n.Length -2; i++)
            {
                for (int j = n.Length - 1; j >i; j--)
                {
                    if (n[j] < n[j - 1])
                    {
                        h1.Swap(ref n[j], ref n[j - 1]);
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
        }
        //tt Xen
        public void Bai13()
        {

            int[] n = { 3, 5, 12, 11, 34, 56, 57, 76, 1, 0, -110 };
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
            for (int i = 1; i <= n.Length - 1; i++)
            {
                for (int j = i; j >0 ; j--)
                {
                    if (n[j] < n[j - 1])
                    {
                        h1.Swap(ref n[j], ref n[j - 1]);
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
        }
        //sx chọn 
        public void Bai14()
        {

            int[] n = { 3, 5, 12, 11, 34, 56, 57, 76, 1, 0, -110 };
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
            for (int i = 0; i <= n.Length - 2; i++)
            {
                int PointMin = i;
                for (int j = i+1; j <=n.Length-1; j++)
                {
                    if (n[j] < n[PointMin])
                    {
                        PointMin = j;
                    }
                }
                h1.Swap(ref n[i], ref n[PointMin]);
            }
            Console.WriteLine();
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
        }
        //sx đổi chỗ trực tiếp
        public void Bai15()
        {

            int[] n = { 3, 5, 12, 11, 34, 56, 57, 76, 1, 0, -110 };
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
            for (int i = 0; i <= n.Length - 2; i++)
            {
                for (int j = i+1; j <=n.Length-1 ; j++)
                {
                    if (n[i] > n[j])
                    {
                        h1.Swap(ref n[i], ref n[j]);
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
        }
        //tính giai thừa
        public void Bai16()
        {
            int n = 4;
            Console.WriteLine($"The Factorial of {n} is:{h1.GiaiThua(n)}");
        }
        //phân tích 1 số nguyên N thành thừa số nguyên tố
        public void Bai17()
        {
            int n = 60, i = 2,m=n;
            List<int> danhSach = new List<int>();
            while (n > 1)
            {
                if (n % i == 0)
                {
                    danhSach.Add(i);
                        n = n / i;
                }
                else
                {
                    i++;
                }
            }
            if (danhSach.Count() == 1)
            {
                Console.WriteLine($" number {n} cannot be factored into prime numbers");
            }
            else
            {
                Console.Write(m +" = " );
                foreach (var item in danhSach)
                {
                   
                    Console.Write(item+"*");
                }
            }
        }
        //dãy fibonacy
        public void Bai18()
        {
            int n = 9;
            List<int> ds = new List<int>();
            ds = h1.ShowFibonacy(9);
            foreach (var item in ds)
            {
                Console.Write(item +"\t");
            }
            Console.WriteLine($"Fibonacy for {n} is: {h1.Fibonacy(n)}");
        }
        //tìm k gần với số x nhất math.abs(k-x) là min nhất
        public void Bai19()
        {
            int[] n = { 1, 2, 3, 4, 12,15, 45, 67, 13, 59 };
            foreach (var item in n)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Enter a number K from keyboard : ");
            int k = int.Parse(Console.ReadLine());
          
            int min = Math.Abs(n[0] - k),address_x = 0;
            for (int i = 0; i <= n.Length -1; i++)
            {
                int point = Math.Abs(k - n[i]);
                if(point < min)
                {
                    min = point;
                    address_x = i;
                }
                
            }
            
            Console.WriteLine("the number a closest to b is {0}",n[address_x]);
            
        }
        //check mảng này có đối xứng không 
        public void Bai20()
        {
            int[] n = { 1, 2, 3, 8, 4, 3, 2, 1 };
            bool check = h1.Check_Mang(n);
            if (check)
            {
                Console.WriteLine("this is a symmetrical arry ");
            }
            else
            {
                Console.WriteLine("this is not a symmetrical arry ");
            }
            
        }
    }
}
