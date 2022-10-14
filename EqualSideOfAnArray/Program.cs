using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSideOfAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Console.ReadKey();
        }
     
        public static int FindEvenIndex(int[] arr)
        {
            int leftSum = 0, rightSum = arr.Sum();

            for (int i = 0; i < arr.Length; ++i)
            {
                rightSum -= arr[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += arr[i];
            }

            return -1;
        }

        public static int FindEvenIndex1(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum()) { return i; }
            }
            return -1;
        }

        public static int FindEvenIndex2(int[] arr)
        {
            int leftSum = 0, rightSum = 0;
            int index = -1;
            //first initialize the right sum as the whole array sum
            foreach (int element in arr)
            {
                rightSum += element;
            }
            foreach (int element in arr)
            {
                index++;
                //subtract the index from the right sum first;
                rightSum -= element;
                //test to see if the sums are equal
                if (leftSum == rightSum)
                {
                    return index;
                }
                //then add it back to the left
                leftSum += element;
            }
            return -1;
        }
    }
}
