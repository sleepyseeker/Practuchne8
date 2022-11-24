using System;

namespace Practuchne8
{
    class Program
    {
        static void Main()
        {
            Param one = new Param();
            Param two = new Param();

            one.Length = 10;
            one.Start = 1;
            one.End = 12;

            two.Length = 10;
            two.Start = -3;
            two.End = 9;

            int[] One = new int[one.Length];
            int[] Two = new int[two.Length];

            one.Cr_arr(One, one.Length, one.Start, one.End);
            two.Cr_arr(Two, two.Length, two.Start, two.End);

            try
            {
                Console.Write("1ндекс елементу = ");
                int i = Int16.Parse(Console.ReadLine());
                Console.WriteLine("One[{0}]={1}", i, One[i]);
            }
            catch { Console.WriteLine("1ндекс елементу виходе за рамки масиву"); }

            one.SumArr(One, Two);
            Console.ReadLine();
            one.SustractArr(One, Two);
            one.skal_mult(One, 3);
            one.skal_del(One, 2);
            Console.ReadLine();

        }
    }
    class Param
    {
        public int Length;
        public int Start;
        public int End;
        int[] Arr;

        public void Cr_arr(int[] Arr, int Length, int Start, int End)
        {
            Random R = new Random();
            for (int i = 0; i < Length; i++)
            {
                Arr[i] = R.Next(Start, End);
                Console.Write("{0} ", Arr[i]);
            }
            Console.ReadLine();
        }
        public void SumArr(int[] a, int[] b)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] += b[i];
                Console.Write("{0} ", a[i]);
            }
        }
        public void SustractArr(int[] a, int[] b)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] -= b[i];
                Console.Write("{0} ", a[i]);
            }
        }
        public void skal_mult(int[] a, int temp)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] *= temp;
                Console.Write("{0} ", a[i]);
            }
        }
        public void skal_del(int[] a, int temp)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] /= temp;
                Console.Write("{0} ", a[i]);
            }
        }
    }
}