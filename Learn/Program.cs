using System;
using System.Formats.Asn1;
using System.Text;

namespace Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Урок 1
            Console.WriteLine("Hello, World!"); // Вывод сообщения в консоль
            Console.ReadKey(); // Нажать любую клавишу в консоли для продолжения

            // Основные целочисленные типы данных
            byte b; // от 0 до 255
            sbyte sb; // от -128 до 127
            short s; // от -32768 до 32767
            ushort us; // от 0 до 65535
            int i; // от -2147483648 до 2147483647
            uint ui; // от 0 до 4294672295
            long l = long.MaxValue;   // Для просмотра максимального значения переменной
            ulong ul = ulong.MinValue; // Для просмотра минимального значения переменной 

            // Основные численные типы данных с плавающей запятой
            float f = 3.2f; // Приравнивать переменную float без f в конце не получится, он думает - что это double
            double d = 4.5; // double точнее float по знакам после запятой

            // Основные символьные типы данных 
            char c = 'a'; // char хранит только один символ, не более
            string str = "string"; // string является строковым типом, может хранить множество символьных типов

            // основные логические типы данных 
            bool bl; // bool может принимать значение только true и false

            // основные типы данных для использования - int | float | char | string | bool

            // Простая инициализация 
            int age;
            float floating;
            age = 27; // age равно 27
            age = 10; // age больше не равно 27, сейчас оно равно 10

            /* Арифметические операторы
            сложение - +
            вычитание - -
            умножение - *
            деление - /
            деление с остатком - %
            */

            // для деления с остатком нужно, что одно из чисел было с точкой, например 2.0
            floating = Convert.ToSingle(3) / 2; //преобразование решения целых чисел в переменную с точкой

            // 7 % 5 = 2 -- это будет остаток от деления, в семёрку помещается одна 5, а два осталось в остатке

            int cool = 12;
            cool++; // прибавление к числу 1
            cool += 2;// автодобавление к числу 2, также можно -=, *=, /=

            // умножение и деление имеет приоритет

            // Логические операторы == != > >= <= <


            // Конкатенация - сложение двух или более строк

            string greeting = "Hi";
            string name = "Mike";
            string message = greeting +", " + name;
            Console.WriteLine(message + ", nice to meet you!");
            // Интерполяция
            Console.WriteLine($"{message}, nice to meet you!");
            message = "1";
            // Конвертация
            age = Convert.ToInt32(message); // Преобразование типа стринг в инт
                                            // При конвертации в булевое значение 1 - true, a 0 - false, отсальное ошибка

            // Работа с консолью
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode; // Для работы полноценного русского языка
            Console.WriteLine();// вывод в консоль
            Console.ReadKey(); // нажать любую кнопку для продолжения
            Console.ReadLine(); //ввод в переменную через консоль
            Console.Write("");// вывод в консоль на той же строчке

            // условный оператор if
            age = 18;
            if (age == 18)
            {
                Console.WriteLine("hi");
            }
            else if (age > 18)
            {
                Console.WriteLine("hii");
            } 
            else
            {
                Console.WriteLine("by");
            }

            // && - логическое И
            // || - логическое ИЛИ

            // Оператор swith
            switch (age) 
            {
                case >=18:
                case >1:
                    Console.WriteLine("hi");
                    break;
                case <18:
                    Console.WriteLine("by");
                    break;
                default:
                    Console.WriteLine("WTF"); // когда нет такой переменной в case
                    break;
            }

            // Цикл while
            age = 2;
            while (age-- > 0) // столько раз, сколько укажем age пока он не станет меньше 0
            {
                Console.WriteLine("d");
                if (age == 5)
                {
                    break; // так можно прервать цикл
                    continue; // а так можно переступить через одну ступень цикла
                }
            }

            // Цикл for
            for(int p = 0; p < 10; p++)
            {
                Console.WriteLine(p);
            }
            

            //  RANDOM 
            Random rand = new Random();

            while (false)
            {
                int value = rand.Next(0, 10); //10 не учитывается
                Console.WriteLine(value);
            }

            //--

            Random random = new Random();
            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine(rand.Next(0, 5));
            }

            //Угадай число
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"от {lower} до {higher}, {triesCount} попыток");

            while (triesCount -- > 0) 
            {
                Console.Write("");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Yes");
                    break;
                }
                else
                {
                    if(userInput > number) 
                    {
                        Console.WriteLine("Ниже");
                    }
                    else 
                    {
                        Console.WriteLine("Выше");
                    }
                }
            }
            if (triesCount < 0)
            {
                Console.WriteLine("" + number);
            }

            // \n - перенос строки
            // \b - удаление последнего символа

            // Массивы
            int[] cucumbers = new int[10] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            int[] tomate = { 1, 2, 3, 4 };

            for(int r = 0; r < cucumbers.Length; r++)
            {
                cucumbers[r] = r + 2;
            }
            //Матрицы
            int[,] array = new int[5,2]; // Обьявление матрицы
            int[,] array2 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] array3 = new int[2, 3] { 
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            };

            for (int h = 0; h < array2.GetLength(0); h++)//Обращение к строкам матрицы
            {
                for (int j = 0; j < array2.GetLength(1); j++)//Обращение к столбцам матрицы
                {
                    Console.WriteLine(array2[h, j] + " ");
                }
                Console.WriteLine();
            }

            int[] oneArray = new int[3];
            int[] twoArray = new int[5];

            twoArray = oneArray;

            oneArray[0] = 5;
            Console.WriteLine(twoArray[0]);//3:50 
        }
    }
}