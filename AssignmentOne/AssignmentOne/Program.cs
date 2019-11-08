using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1, 4, 4, 5, 5};
            
            PrintUnique(arr);

            Console.ReadKey();

        }
        //Write a program in C# Sharp to print all unique elements in an array
        static void PrintUnique(int[] arr)
        {
            int[] tempArr = new int[arr.Length];
            int j = 0;
            foreach (var i in arr)
            {
                if (!(tempArr.Contains<int>(i))) {
                    tempArr[j] = i;
                    j++;
                }
            }
            int[] tArr = new int[j];

            for (int i = 0; i < j; i++)
            {
                tArr[i] = tempArr[i];
            }
            
            foreach (var i in tArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
