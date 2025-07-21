using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeC_project
{
    internal class Program
    {
        #region Q1 part one
        //static void passbyvalue(string name)
        //{
        //    name = "ziad ramadan kamel";
        //}
        //static void passbyreference(ref string name)
        //{
        //    name = "ziad ramadan kamel";
        //}
        #endregion
        #region Q2 part one
        //static void passbyvalue(int[] arr)
        //{
        //    arr = new int[] { 1,2,3,};
        //}
        //static void passbyreference(ref int[] arr)
        //{
        //    arr = new int[] { 1, 2, 3, };
        //}
        #endregion
        #region Q3 part one 
        //static (int sum , int sub) sumandsub(int z , int i ,int a ,int d)
        //{
        //    int sum = z + i;
        //    int sub = a - d;
        //    return (sum, sub);
        //} 
        #endregion
        #region Q4 part one 
        //static int sumofthedigitsnumber(int num)
        //{
        //    int sum = 0;
        //    while (num != 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;
        //    }
        //    return sum;
        //}

        #endregion
        #region Q5 part one 
        //static bool isprime(int number)
        //{
        //    if (number <= 1) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //}
        #endregion
        #region Q6 part one 
        //static void minmaxarray(int[] arr, ref int min, ref int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    foreach (int num in arr)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        #endregion
        #region Q7 part one 
        //static int factorial(int n)
        //{
        //    int result = 1;
        //    for (int i = 2; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion
        #region Q8 part one 
        //static string changechar(string word, int index = 0, char newchar = 'z')
        //{
        //    char[] charchters = word.ToCharArray();
        //    charchters[index] = newchar;
        //    return new string(charchters);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1 part two
            // in pass by value like number the modification happen only in the value inside the function it will not affect the orginal varible
            // while in the pass by reference we send the memory address which holding the value so if we change the value inside the function the value assigned to the memory will be change too
            //string name = "ziad ramdan";
            //passbyvalue(name);
            //Console.WriteLine(name);
            //passbyreference(ref name);
            //Console.WriteLine(name);
            #endregion
            #region Q2 part two
            // as we deal with reference type so i will try it with array so in pass by value the we can modify
            // the array elements but we cant reassign it to a new value otherwise in the
            // call by reference we can make we can reassign the array to a new one on other word reassigned to new object 
            //int[] arr = { 4,5,6,7};
            //passbyvalue(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //passbyreference(ref arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q3 part two 
            //var answer = sumandsub(1,2,3,4);
            //Console.WriteLine(answer.sum);
            //Console.WriteLine(answer.sub);
            #endregion
            #region Q4 part two
            //int num = 555;
            //Console.WriteLine(sumofthedigitsnumber(num));
            #endregion
            #region Q5 part two
            //int num = 9;
            //Console.WriteLine(isprime(num));
            #endregion
            #region Q6 part two
            //int[] arr = { 1,2,3,4,5,6,7 };
            //int min = 0;
            //int max = 0;
            //minmaxarray(arr, ref min, ref max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion
            #region Q7 part two
            //int num = 7;
            //Console.WriteLine(factorial(num));
            #endregion
            #region Q8 part two
            //string word = "ziadramdan";
            //Console.WriteLine(changechar(word , 1 , 'y'));
            #endregion
        }
    }
}
