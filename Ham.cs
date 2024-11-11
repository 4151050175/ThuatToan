using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan
{
    public class Ham
    {
        public void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public int GiaiThua(int a)
        {
            if (a == 1)
                return 1;
            else
                return a * GiaiThua(a - 1);
        }
        public int Fibonacy(int n)
        {
            if (n <= 1)
                return n;
            else
                return (Fibonacy(n - 1) + Fibonacy(n - 2));
        }
        public List<int> ShowFibonacy(int n)
        {
            List<int> ds = new List<int>();
            for (int i = 0; i <=n ; i++)
            {
                ds.Add(Fibonacy(i));
            }
            return ds;
        }
        public bool Check_Mang(int[] a)
        {
            int mid = a.Length / 2;
            for (int i = 0; i <= mid; i++)
            
                if (a[i] != a[a.Length - i - 1])
                    return false;
                return true;
            
        }
    }
}
