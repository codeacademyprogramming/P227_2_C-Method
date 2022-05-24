using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            int[] numbers2 = { 1, 20, 33, 14, 5, 6 };


            int total = SumOfNumbers(new int[]{ 4,5});
            Console.WriteLine(total);


            int result = SumOfNumbers(numbers2);
            Console.WriteLine(result);



            //for (int i = 0;i<numbers.Length; i++)
            //{
            //    total = Sum(total, numbers[i]);
            //}

            bool chk = IsEven(44);
            Console.WriteLine(chk);

            ShowFullName("Hikmet", "Abbasov");
           


            string numStr;

            int num;

            do
            {
                Console.WriteLine("Tek eded daxil edin:");
                numStr = Console.ReadLine();
                num = Convert.ToInt32(numStr);

            } while (!IsOdd(num));



            //if(IsOdd(num))
            //{
            //    Console.WriteLine("Eded tekdir");
            //}
            //else
            //{
            //    Console.WriteLine("Eded tek deyil!");
            //}

            var result1 = Sum(4.4, 3.45);


            var result2 = Sum(10, 4);

            int oddCount = CalcOddCount(numbers1);


        }

        static int Sum(int num1, int num2, int num3 = 0)
        {
            int result = num1 + num2 + num3;
            return result;
        }
        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static double Sum(double n,double m)
        {
            double result = n + m;
            return result;
        }


        static int SumOfNumbers(int[] nums)
        {
            int total = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }

            return total;
        }

        static bool IsEven(int num)
        {
            bool check = num % 2 == 0;

            return check;
        }

        static void ShowFullName(string name,string surname)
        {
            //Console.WriteLine(name +" "+surname);
            Console.WriteLine($"{name} {surname}");
        }

        static bool IsOdd(int num)
        {
            bool check = num % 2 == 1;

            return check;
        }

        static int CalcOddCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOdd(numbers[i]))
                    count++;
            }

            return count;
        }
    }
}
