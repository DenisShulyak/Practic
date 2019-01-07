using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)");
            Random rand = new Random();
            int LengthNumbersInt = 5;
            int RowNumbersDouble = 3;
            int ColNumbersDouble = 4;
            int[] numbersInt = new int[LengthNumbersInt];
            double[,] numbersDouble = new double[RowNumbersDouble, ColNumbersDouble];
            int maxInt = 0;
            int minInt = -1;
            double maxDouble = 0;
            double minDouble = -1;
            int sumInt = 0;
            double sumDouble = 0;
            int prodInt = 1; // product of numbers
            double prodDouble = 1;
            int sum = 0;
            int sumEvenInt = 0;
            double sumOddDouble = 0;
            for (int i = 0; i < numbersInt.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-й элимент массива: ");
                numbersInt[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbersDouble.GetLength(0); i++)
            {
                for (int j = 0; j < numbersDouble.GetLength(1); j++)
                {
                    numbersDouble[i, j] = rand.Next(0, 100);
                }
            }
            Console.WriteLine("Полученный одномерный массив: " + numbersInt[0] + " " + numbersInt[1] + " " + numbersInt[2] + " " + numbersInt[3] + " " + numbersInt[4] + " ");
            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < numbersDouble.GetLength(0); i++)
            {
                for (int j = 0; j < numbersDouble.GetLength(1); j++)
                {
                    Console.Write(numbersDouble[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numbersInt.Length; i++)
            {

                for (int j = 0; j < numbersDouble.GetLength(0); j++)
                {
                    for (int k = 0; k < numbersDouble.GetLength(1); k++)
                    {

                        if (numbersInt[i] == numbersDouble[j, k])
                        {
                            if (maxInt < numbersInt[i])
                            {
                                maxInt = numbersInt[i];
                                maxDouble = numbersDouble[j, k];
                            }
                            if (minInt > numbersInt[i])
                            {
                                minInt = numbersInt[i];
                                minDouble = numbersDouble[j, k];
                            }
                        }

                    }
                }
            }
            for (int i = 0; i < numbersInt.Length; i++)
            {
                sumInt = sumInt + numbersInt[i];
                prodInt *= numbersInt[i];
                if (numbersInt[i] % 2 == 0)
                {
                    sumEvenInt += numbersInt[i];
                }
            }

            for (int i = 0; i < numbersDouble.GetLength(0); i++)
            {
                for (int j = 0; j < numbersDouble.GetLength(1); j++)
                {
                    sumDouble = sumDouble + numbersDouble[i, j];
                    prodDouble *= numbersDouble[i, j];
                    if (numbersDouble[i, j] % 2 != 0)
                    {
                        sumOddDouble += numbersDouble[i, j];
                    }
                }
            }

            if (minInt == -1)
            {
                minInt = maxInt;
                minDouble = maxDouble;

            }
            sum = sumInt + (int)sumDouble;
            Console.WriteLine("Общий максимальный элимент: " + maxInt);
            Console.WriteLine("Общий минимальный элимент: " + minInt);
            Console.WriteLine("Общая сумма всех элиментов: " + sum);
            Console.WriteLine("Общее произведение всех элиментов: " + prodDouble * prodInt);
            Console.WriteLine("Сумма четных элиментов одномерного массива: " + sumEvenInt);
            Console.WriteLine("Сумма нечетных элиментов двумерного массива: " + sumOddDouble);


            Console.WriteLine("2)");

            Console.WriteLine("Ведите размер первого массива: ");
            int Length1 = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[Length1];
            Console.WriteLine("Ведите размер второго массива: ");
            int Length2 = int.Parse(Console.ReadLine());
            int[] numbers2 = new int[Length2];
            int Length3 = Length1 + Length2;

            int[] numbers3 = new int[Length3];
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rand.Next(0, 10);
            }
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = rand.Next(0, 10);
            }
            Console.WriteLine("Элименты первого массива: ");
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }
            Console.WriteLine("Элименты второго массива: ");
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers3[i] = numbers1[i];
            }

            for (int i = numbers1.Length, j = 0; i < numbers3.Length; i++, j++)
            {

                numbers3[i] =
                numbers2[j];

            }

            Console.WriteLine("Элименты третьего массива: ");
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.WriteLine(numbers3[i]);

            }
            int count = 1;
            int temp = numbers3[0];
            int[] numbers4 = numbers3;
            for (int i = 1; i < numbers3.Length; i++)
            {
                if (numbers3[i] != temp)
                {
                    for (int j = i + 1; j < numbers3.Length; j++)
                        if (numbers3[i] == numbers3[j])
                            numbers3[j] = temp;
                    count++;
                }
            }
            count = 0;

            for (int i = 1; i < numbers3.Length; i++)
            {
                if (numbers3[i] != numbers3[0]) numbers3[++count] = numbers3[i];

            }
            Console.WriteLine("Неповторяющиеся элименты первого и второго массива: ");
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(numbers3[i]);

            }

            Console.WriteLine("3) ");
            string line;
            Console.WriteLine("Введите строку: ");
            line = Console.ReadLine();
            Console.WriteLine("Введенная строка: " + line);

            char[] str1 = line.ToCharArray();
            char[] str2 = str1;
            Array.Reverse(str1);
            string line1 = new string(str1);
            Console.WriteLine("Перевернутая строка: " + line1);
            if (line == line1)
            {
                Console.WriteLine("Данная строка является палиндромом!");
            }
            else
            {
                Console.WriteLine("Данная строка не является палиндромом!");

            }
            Console.WriteLine("4) ");//Подсчитать кол-во слов в веденном предложении
            string sentence;
            Console.WriteLine("Введите предложение: ");// Hello my name is <Name>

            sentence = Console.ReadLine();
            Console.WriteLine("Данное предложение: " + sentence);
            char[] Sentence = sentence.ToCharArray();
            int countSentence = 1;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == ' ')
                {
                    countSentence++;
                }
            }
            Console.WriteLine("Кол-во слов в предложении: " + countSentence);


            Console.WriteLine("5) ");
            int[,] TwoArray = new int[5, 5];

            int Sum = 0;
            int max = 0;
            int min = 0;
            int iMin = 0, jMin = 0, iMax = 0, jMax = 0;
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    TwoArray[i, j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    if (min > TwoArray[i, j])
                    {
                        min = TwoArray[i, j];
                        iMin = i;
                        jMin = j;
                    }
                    if (max < TwoArray[i, j])
                    {
                        max = TwoArray[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }
            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    Console.Write(TwoArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Координаты максимального и минимального значения: ");
            Console.WriteLine("iMax = : " + iMax);
            Console.WriteLine("jMax = : " + jMax);
            Console.WriteLine("iMin = : " + iMin);
            Console.WriteLine("jMin = : " + jMin);

            if (iMin < iMax)
            {
                for (int i = iMin; i <= iMin; i++)
                {
                    for (int j = jMin; j < TwoArray.GetLength(1); j++)
                    {
                        Sum += TwoArray[i, j];
                    }
                }
                for (int i = iMin + 1; i < iMax; i++)
                {
                    for (int j = 0; j < TwoArray.GetLength(1); j++)
                    {
                        Sum += TwoArray[i, j];
                    }
                }
                for (int i = iMax; i <= iMax; i++)
                {
                    for (int j = 0; j <= jMax; j++)
                    {
                        Sum += TwoArray[i, j];
                    }
                }
            }
            else if(iMin>iMax)
            {
                for (int i = iMax; i <= iMax; i++)
                {
                    for (int j = jMax; j < TwoArray.GetLength(1); j++)
                    {
                        Sum += TwoArray[i, j];
                    }
                }
                for (int i = iMax + 1; i < iMin; i++)
                {
                    for (int j = 0; j < TwoArray.GetLength(1); j++)
                    {
                        Sum += TwoArray[i, j];
                    }
                }
                for (int i = iMin; i <= iMin; i++)
                {
                    for (int j = 0; j <= jMin; j++)
                    {
                        Sum += TwoArray[i, j];
                    }
                }
            }
            else if(iMax == iMin)
            {
                if(jMax > jMin)
                {
                    for(int i = iMax;i<=iMax;i++)
                    {
                        for(int j =jMin;j <= jMax;j++)
                        {
                            Sum += TwoArray[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = iMin; i <= iMin; i++)
                    {
                        for (int j = jMax; j <= jMin; j++)
                        {
                            Sum += TwoArray[i, j];
                        }
                    }
                }

            }
            Console.WriteLine("Сумма элементов между " + min + "(минимальное) и " + max + "(максимальное): " + Sum);

            Console.ReadLine();
        }
    }
}
