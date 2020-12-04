using System;

namespace rekurzio
{
    class Program
    {
        static int fank(int n)
        {
            if (n<0)
            {
                throw new ArgumentException("nem lehet negatív");
            }
            if (n==0)
            {
                return 1;
            }
            int vegeredmeny = n;
            for (int i = n; i >1; i--)
            {
                vegeredmeny *= (i - 1);
            }
            return vegeredmeny;
        }
        static int faktrekurzio(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("nem lehet negatív");
            }
            if (n>0)
            {
                return n*faktrekurzio(n - 1);
            }
           
            return 1;
        
        }
        static int hatvany(int a,int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("nem lehet negatív");
            }
            if (n == 0)
            {
                return 1;
            }
            int vegeredmeny = a;
            for (int i = 1; i < n; i++)
            {
                vegeredmeny *= a;
            }
            return vegeredmeny;
        }
        static int hatvanyRekurziv(int a,int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("nem lehet negatív");
            }
            if (n > 0)
            {
                return (int)Math.Pow(a,n);
            }

            return 1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(fank(5));
            Console.WriteLine(hatvany(2,3));
            Console.WriteLine(hatvanyRekurziv(2,3));
            Console.ReadKey();
        }
    }
}
