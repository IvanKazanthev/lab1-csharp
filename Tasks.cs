using System;

namespace lab1
{
    internal class Tasks
    {
        // МЕТОДЫ

        // Задание 1
        public double fraction(double x)
        {
            return x - (int)x;
        }

        // Задание 3
        public int charToNum(char x)
        {
            return x - '0';
        }

        // Задание 5
        public bool is2Digits(int x)
        {
            return (x >= 10 && x <= 99) || (x <= -10 && x >= -99);
        }

        // Задание 7
        public bool isInRange(int a, int b, int num)
        {
            return (num >= a && num <= b) || (num >= b && num <= a);
        }

        // Задание 9
        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        // УСЛОВИЯ

        // Задание 1
        public int abs(int x)
        {
            if (x < 0)
            {
                return -x;
            }

            return x;
        }

        // Задание 3
        public bool is35(int x)
        {
            return (x % 3 == 0 && x % 5 != 0) ||
                   (x % 3 != 0 && x % 5 == 0);
        }

        // Задание 5
        public int max3(int x, int y, int z)
        {
            int max = x;

            if (y > max)
            {
                max = y;
            }

            if (z > max)
            {
                max = z;
            }

            return max;
        }

        // Задание 7
        public int sum2(int x, int y)
        {
            int sum = x + y;

            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }

            return sum;
        }

        // Задание 9
        public string day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";
                case 2:
                    return "вторник";
                case 3:
                    return "среда";
                case 4:
                    return "четверг";
                case 5:
                    return "пятница";
                case 6:
                    return "суббота";
                case 7:
                    return "воскресенье";
                default:
                    return "это не день недели";
            }
        }

        // ЦИКЛЫ

        // Задание 1
        public string listNums(int x)
        {
            string result = "";

            for (int i = 0; i <= x; i++)
            {
                result += i + " ";
            }

            return result.TrimEnd();
        }

        // Задание 3
        public string chet(int x)
        {
            string result = "";

            for (int i = 0; i <= x; i += 2)
            {
                result += i + " ";
            }

            return result.TrimEnd();
        }

        // Задание 5
        public int numLen(long x)
        {
            int count = 1;

            while (x >= 10 || x <= -10)
            {
                x = x / 10;
                count++;
            }

            return count;
        }

        // Задание 7
        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // Задание 9
        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // МАССИВЫ
        
        // Задание 1
        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        // Задание 3
        public int maxAbs(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                {
                    max = arr[i];
                }
            }

            return max;
        }

        // Задание 5
        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            for (int i = 0; i < ins.Length; i++)
            {
                result[pos + i] = ins[i];
            }

            for (int i = pos; i < arr.Length; i++)
            {
                result[ins.Length + i] = arr[i];
            }

            return result;
        }

        // Задание 7
        public int[] reverseBack(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }

            return result;
        }

        // Задание 9
        public int[] findAll(int[] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }
    }
}