using System;

namespace lab1;

internal class Program
{
    static void Main(string[] args)
    {
        Tasks tasks = new Tasks();

        // МЕТОДЫ

        // Задание 1
        Console.Write("Задание 1. Введите число: ");
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Ошибка! Введите число еще раз: ");
        }
        double result = tasks.fraction(x);
        Console.WriteLine("Дробная часть: " + result);

        // Задание 3
        Console.Write("Задание 2. Введите цифру: ");
        char x2;
        while (!char.TryParse(Console.ReadLine(), out x2) ||
               x2 < '0' || x2 > '9')
        {
            Console.Write(
                "Ошибка! Введите одну цифру от 0 до 9: "
            );
        }
        int result2 = tasks.charToNum(x2);
        Console.WriteLine("Число: " + result2);

        // Задание 5
        Console.Write("Задание 3. Введите число: ");
        int x3;
        while (!int.TryParse(Console.ReadLine(), out x3))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        bool result3 = tasks.is2Digits(x3);
        Console.WriteLine("Число двузначное: " + result3);

        // Задание 7
        Console.Write("Задание 4. Введите первое число: ");
        int a;
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите второе число: ");
        int b;
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите число для проверки: ");
        int num;
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        bool result4 = tasks.isInRange(a, b, num);
        Console.WriteLine(
            "Число входит в диапазон: " + result4
        );

        // Задание 9
        Console.Write("Задание 5. Введите первое число: ");
        int a2;
        while (!int.TryParse(Console.ReadLine(), out a2))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите второе число: ");
        int b2;
        while (!int.TryParse(Console.ReadLine(), out b2))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите третье число: ");
        int c2;
        while (!int.TryParse(Console.ReadLine(), out c2))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        bool result5 = tasks.isEqual(a2, b2, c2);
        Console.WriteLine("Все числа равны: " + result5);

        // УСЛОВИЯ

        // Задание 1
        Console.Write("Задание 6. Введите число: ");
        int x4;
        while (!int.TryParse(Console.ReadLine(), out x4))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        int result6 = tasks.abs(x4);
        Console.WriteLine("Модуль числа: " + result6);

        // Задание 3
        Console.Write("Задание 7. Введите число: ");
        int x5;
        while (!int.TryParse(Console.ReadLine(), out x5))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        bool result7 = tasks.is35(x5);
        Console.WriteLine(
            "Число делится ровно на 3 или 5: " + result7
        );

        // Задание 5
        Console.Write("Задание 8. Введите первое число: ");
        int x6;
        while (!int.TryParse(Console.ReadLine(), out x6))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите второе число: ");
        int y6;
        while (!int.TryParse(Console.ReadLine(), out y6))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите третье число: ");
        int z6;
        while (!int.TryParse(Console.ReadLine(), out z6))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        int result8 = tasks.max3(x6, y6, z6);
        Console.WriteLine("Максимальное число: " + result8);

        // Задание 7
        Console.Write("Задание 9. Введите первое число: ");
        int x7;
        while (!int.TryParse(Console.ReadLine(), out x7))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите второе число: ");
        int y7;
        while (!int.TryParse(Console.ReadLine(), out y7))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        int result9 = tasks.sum2(x7, y7);
        Console.WriteLine("Результат: " + result9);

        // Задание 9
        Console.Write("Задание 10. Введите номер дня недели: ");
        int x8;
        while (!int.TryParse(Console.ReadLine(), out x8))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        string result10 = tasks.day(x8);
        Console.WriteLine("День недели: " + result10);

        // ЦИКЛЫ

        // Задание 1
        Console.Write("Задание 11. Введите число: ");
        int x9;
        while (!int.TryParse(Console.ReadLine(), out x9))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        string result11 = tasks.listNums(x9);
        Console.WriteLine("Числа от 0 до x: " + result11);

        // Задание 3
        Console.Write("Задание 12. Введите число: ");
        int x10;
        while (!int.TryParse(Console.ReadLine(), out x10))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        string result12 = tasks.chet(x10);
        Console.WriteLine("Четные числа: " + result12);

        // Задание 5
        Console.Write("Задание 13. Введите число: ");
        long x11;
        while (!long.TryParse(Console.ReadLine(), out x11))
        {
            Console.Write("Ошибка! Введите целое число: ");
        }
        int result13 = tasks.numLen(x11);
        Console.WriteLine("Количество цифр: " + result13);

        // Задание 7
        Console.Write("Задание 14. Введите размер квадрата: ");
        int x12;
        while (
            !int.TryParse(Console.ReadLine(), out x12) || x12 < 0
        )
        {
            Console.Write(
                "Ошибка! Введите неотрицательное целое число: "
            );
        }
        Console.WriteLine("Квадрат:");
        tasks.square(x12);

        // Задание 9
        Console.Write(
            "Задание 15. Введите высоту треугольника: "
        );
        int x13;
        while (
            !int.TryParse(Console.ReadLine(), out x13) || x13 < 0
        )
        {
            Console.Write(
                "Ошибка! Введите неотрицательное целое число: "
            );
        }
        Console.WriteLine("Правый треугольник:");
        tasks.rightTriangle(x13);

        // МАССИВЫ

        // Задание 1
        Console.Write(
            "Задание 16. Введите кол-во элементов массива: "
        );
        int n1;
        while (
            !int.TryParse(Console.ReadLine(), out n1) || n1 <= 0
        )
        {
            Console.Write(
                "Ошибка! Введите положительное целое число: "
            );
        }
        int[] arr1 = new int[n1];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("Введите элемент [" + i + "]: ");
            while (
                !int.TryParse(Console.ReadLine(), out arr1[i])
            )
            {
                Console.Write(
                    "Ошибка! Введите целое число: "
                );
            }
        }
        Console.Write("Введите число для поиска: ");
        int search1;
        while (
            !int.TryParse(Console.ReadLine(), out search1)
        )
        {
            Console.Write(
                "Ошибка! Введите целое число: "
            );
        }
        int result14 = tasks.findFirst(arr1, search1);
        Console.WriteLine(
            "Индекс первого вхождения: " + result14
        );

        // Задание 3
        Console.Write(
            "Задание 17. Введите кол-во элементов массива: "
        );
        int n2;
        while (
            !int.TryParse(Console.ReadLine(), out n2) || n2 <= 0
        )
        {
            Console.Write(
                "Ошибка! Введите положительное целое число: "
            );
        }
        int[] arr2 = new int[n2];
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write("Введите элемент [" + i + "]: ");
            while (
                !int.TryParse(Console.ReadLine(), out arr2[i])
            )
            {
                Console.Write(
                    "Ошибка! Введите целое число: "
                );
            }
        }
        int result15 = tasks.maxAbs(arr2);
        Console.WriteLine(
            "Наибольшее по модулю значение: " + result15
        );

        // Задание 5
        Console.Write(
            "Задание 18. Введите кол-во элементов 1 массива:"
        );
        int n3;
        while (
            !int.TryParse(Console.ReadLine(), out n3) || n3 <= 0
        )
        {
            Console.Write(
                "Ошибка! Введите положительное целое число: "
            );
        }
        int[] arr3 = new int[n3];
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.Write(
                "Введите элемент первого массива [" + i + "]: "
            );
            while (
                !int.TryParse(Console.ReadLine(), out arr3[i])
            )
            {
                Console.Write(
                    "Ошибка! Введите целое число: "
                );
            }
        }
        Console.Write(
            "Введите количество элементов второго массива: "
        );
        int n4;
        while (
            !int.TryParse(Console.ReadLine(), out n4) || n4 <= 0
        )
        {
            Console.Write(
                "Ошибка! Введите положительное целое число: "
            );
        }
        int[] ins = new int[n4];
        for (int i = 0; i < ins.Length; i++)
        {
            Console.Write(
                "Введите элемент второго массива [" + i + "]: "
            );
            while (
                !int.TryParse(Console.ReadLine(), out ins[i])
            )
            {
                Console.Write(
                    "Ошибка! Введите целое число: "
                );
            }
        }
        Console.Write("Введите позицию вставки: ");
        int pos;
        while (
            !int.TryParse(Console.ReadLine(), out pos) ||
            pos < 0 || pos > arr3.Length
        )
        {
            Console.Write(
                "Введите позицию от 0 до " + arr3.Length + ": "
            );
        }
        int[] result16 = tasks.add(arr3, ins, pos);
        Console.Write("Новый массив: ");
        for (int i = 0; i < result16.Length; i++)
        {
            Console.Write(result16[i] + " ");
        }
        Console.WriteLine();

        // Задание 7
        Console.Write(
            "Задание 19. Введите кол-во элементов массива: "
        );
        int n5;
        while (
            !int.TryParse(Console.ReadLine(), out n5) || n5 <= 0
        )
        {
            Console.Write(
                "Ошибка! Введите положительное целое число: "
            );
        }
        int[] arr4 = new int[n5];
        for (int i = 0; i < arr4.Length; i++)
        {
            Console.Write("Введите элемент [" + i + "]: ");
            while (
                !int.TryParse(Console.ReadLine(), out arr4[i])
            )
            {
                Console.Write(
                    "Ошибка! Введите целое число: "
                );
            }
        }
        int[] result17 = tasks.reverseBack(arr4);
        Console.Write("Массив в обратном порядке: ");
        for (int i = 0; i < result17.Length; i++)
        {
            Console.Write(result17[i] + " ");
        }
        Console.WriteLine();

        // Задание 9
        Console.Write(
            "Задание 20. Введите кол-во элементов массива: "
        );
        int n6;
        while (
            !int.TryParse(Console.ReadLine(), out n6) || n6 <= 0
        )
        {
            Console.Write(
                "Ошибка! Введите положительное целое число: "
            );
        }
        int[] arr5 = new int[n6];
        for (int i = 0; i < arr5.Length; i++)
        {
            Console.Write("Введите элемент [" + i + "]: ");
            while (
                !int.TryParse(Console.ReadLine(), out arr5[i])
            )
            {
                Console.Write(
                    "Ошибка! Введите целое число: "
                );
            }
        }
        Console.Write("Введите число для поиска: ");
        int search2;
        while (
            !int.TryParse(Console.ReadLine(), out search2)
        )
        {
            Console.Write(
                "Ошибка! Введите целое число: "
            );
        }
        int[] result18 = tasks.findAll(arr5, search2);
        Console.Write("Индексы всех вхождений: ");
        for (int i = 0; i < result18.Length; i++)
        {
            Console.Write(result18[i] + " ");
        }
        Console.WriteLine();
    }
}
