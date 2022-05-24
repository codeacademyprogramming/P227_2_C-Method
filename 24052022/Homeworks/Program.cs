using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            // Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki
            // n ədədinin yerləşdiyi indexi tapan alqoritm (binary search)


            int[] numbers = { 1, 2, 3, 7, 10, 56, 76, 78, 89 };

            int n = 77;

            int max = numbers.Length - 1;
            int min = 0;
            int index = -1;

            while (min<=max)
            {
                int mid = (min+max)/2;
                if (n == numbers[mid])
                {
                    index = mid;
                    break;
                }
                else if (n > numbers[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            if(index == -1)
            {
                Console.WriteLine("Eded tapilmadi");
            }
            else
            {
                //Console.WriteLine(n+ " ededi "+index+" nomreli indexde yerlesir");
                Console.WriteLine($"{n} ededi {index} nomreli indexde yerlesir");
            }
            #endregion

            #region task2
            //Verilmiş ədədlər siyahısını artan sıra ilə düzülmüş ədədlər halına gətirən alqoritm

            int[] mixNumbers = { 425, 53, 1, 34, 21, 5, 74, 21, 34,3000 };

            for (int i = 0; i < mixNumbers.Length-1; i++)
            {
                for (int a = 0; a < mixNumbers.Length-i-1; a++)
                {
                    if (mixNumbers[a] > mixNumbers[a++])
                    {
                        int temp = mixNumbers[a];
                        mixNumbers[a]=mixNumbers[a+1];
                        mixNumbers[a + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < mixNumbers.Length; i++)
            {
                Console.WriteLine(mixNumbers[i]);
            }

            #endregion

            #region task3
            //Verilmiş iki ədədlər siyahısından birincisinin ikincisinin içində olub olmadığını
            //tapan alqoritm.Yəni birinci array-dəki ədədlərin hamısı 2ci array-də də varsa true
            //çıxır output-a , hər hansısa biri yoxdursa false

            int[] numbers1 = { 1, 2, 3, };
            int[] numbers2 = { 45, 10, 98,1, 45, 2, 44, 3 };

            bool check = false;
            for (int i = 0;i < numbers1.Length; i++)
            {
                check = false;
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if(numbers2[j] == numbers1[i])
                    {
                        check = true;
                        break;
                    }
                }

                if (!check)
                    break;
            }

            if(check)
                Console.WriteLine("var");
            else
                Console.WriteLine("yoxdur");



            #endregion


            #region task4
            //Console-dan  ad daxil edilməsini istəyən proqram. Əgər daxil edilən adda
            //rəqəm varsa yenidən daxil edilməlidir ta ki düz yazana qədər

            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool hasDigit;
            string name;
            do
            {
                Console.WriteLine("Ad daxil edin:");
                name = Console.ReadLine();

                hasDigit = false;
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < digits.Length; j++)
                    {
                        if (name[i] == digits[j])
                        {
                            hasDigit = true;
                            break;
                        }
                    }
                    if (hasDigit)
                        break;
                }

            } while (hasDigit);


            Console.WriteLine(name);

            #endregion

            #region Task5

            //Verilmiş yazılar siyahısındaki bütün sözlərin A hərfi ilə
            //başlayıb başlamadığını tapan proqram

            Console.WriteLine("Adlar siyahinizin uzunlugunu daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);
            string[] names = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. adi daxil et");
                names[i] = Console.ReadLine();
            }


            bool isStartWithA = true;
           

            for (int i = 0;i < names.Length; i++)
            {
                if(names[i][0] != 'A')
                {
                    isStartWithA = false;
                    break;
                }
            }

            if(isStartWithA)
                Console.WriteLine("Hamisi A ile baslayir");
            else
                Console.WriteLine("Hamisi A ile baslamir");
            #endregion
        }

    }
}
