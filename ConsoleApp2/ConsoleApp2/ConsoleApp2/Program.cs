using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            // file();
            // cos();
            // xor();
            //ravenstvo();
            // ifelse();
            // switchh ();
            // ternarnay_operation();
            // seriesfor(); //цикл for
            // seriesdo(); //цикл do
            // serieswhile(); // цикл while
            array();
            // OperatingSystem os = System.Environment.OSVersion; // вывод информации о системе, интересный класс Enviroment


        }
        static void file() {
            //StreamWriter creat = new StreamWriter(new FileStream("text.txt", FileMode.Create, FileAccess.ReadWrite));
            StreamWriter fileOut = new StreamWriter("t.txt", true);
            // StreamWriter open = new StreamWriter(new FileStream("text.txt", FileMode.Open, FileAccess.ReadWrite));
            Console.WriteLine("Введите значение x");

            fileOut.WriteLine("asd");

        }

        static bool ravenstvo()
        {
            int a = 10;
            int b = 15;
            bool c = a == b;
            Console.WriteLine($"{c}");
            return c;

        }

        static void ifelse() // блок условия 
        {
            Console.Write("Введите значение x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine($"значение {x} > {y}");
            }
            else if (x < y)
            {
                Console.WriteLine($"значение {x} < {y}");
            }
            else
            {
                Console.WriteLine($"значение {x} = {y}");
            }
        }

        static void switchh() // алтеранативный вариант условия
        {
            Console.WriteLine("Нажмите Y и N");
            string x = Console.ReadLine();
            switch (x)
            {
                case "Y":
                    Console.WriteLine("Вы согласились");
                    break; // Альтернативные варианты закрытия блока goto case (№ или название элемента к которому перейти), return, throw
                case "N":
                    Console.WriteLine("Вы отказались");
                    break;
                default:
                    Console.WriteLine("Правильно выберите");
                    break;

                    // Применение оператора return позволит выйти не только из блока case, но и из вызывающего метода. 
                    // То есть, если в методе Main после конструкции switch..case, в которой используется оператор return, идут какие-либо операторы и выражения, 
                    // то они выполняться не будут, а метод Main завершит работу.

            }
        }

        static void ternarnay_operation()
        {
            Console.Write("Введите значение x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какую математическую операцию выполнить: + или - ? \n");
            Console.Write("Выбранный знак: ");
            string selection = Console.ReadLine();
            int z = selection == "+" ? (x + y) : (x - y);
            Console.WriteLine("Результат: " + z);
            // Тернарная операция имеет следующий синтаксис:[первый операнд -условие] ? [второй операнд] : [третий операнд].
            // Здесь сразу три операнда.В зависимости от условия тернарная операция возвращает второй или третий операнд: если условие равно true, то возвращается второй операнд; 
            // если условие равно false, то третий.
        }

        static void seriesfor() //использование цикла for
        {
        a: Console.Write("Введите значение x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                x++;
                Console.WriteLine($"Квадрат числа {x} равен {x * x}");
                if (x == 5) // если x = 5, ход пропускается 
                    continue;
                if (x == 1) // если x = 1, цикл закончится
                    break; 
            }
            Console.Write("Для выхода нажмите Enter \n");
            Console.Write("Для продолжения введите любую клавишу ");
            string p = Console.ReadLine();
            if (p != "") goto a; // запуск цикла заново
        }

        static void seriesdo () // Но важно отметить, что цикл do гарантирует хотя бы единократное выполнение действий, 
                                // даже если условие в инструкции while не будет истинно.
        {
        a: Console.Write("Введите значение x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(x);
                x--;
            }
            while (x > 0);
            Console.Write("Для выхода нажмите Enter \n");
            Console.Write("Для продолжения введите любую клавишу ");
            string p = Console.ReadLine();
            if (p != "") goto a; // запуск цикла заново
        }

        static void serieswhile() // В отличие от цикла do цикл while сразу проверяет истинность некоторого условия, 
                                 // и если условие истинно, то код цикла выполняется
        {
        a: Console.Write("Введите значение x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.Write("Для выхода нажмите Enter \n");
            Console.Write("Для продолжения введите любую клавишу ");
            string p = Console.ReadLine();
            if (p != "") goto a; // запуск цикла заново
        }
        static int xor() // шифрование при помощи логического исключающего ИЛИ
        {
            Console.Write("Введите значение x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение key = ");
            int key = Convert.ToInt32(Console.ReadLine());
            int encrypt = x ^ key;
            Console.WriteLine("Зашифрованное число: " + encrypt);
            int decrypt = encrypt ^ key; 
            Console.WriteLine("Расшифрованное число: " + decrypt);
            return decrypt;
        }

        static double cos()
        {
            Console.Write("Введите значение x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double A = Math.Sqrt(Math.Log10(4/3 + x) + 9 / 7) - Math.Exp(-Math.Sin(1.3 * x - 0.7));
            //double cos = Math.Cos(Math.PI * x) / (1 + Math.Pow(x,2));
            Console.WriteLine($"Результат при x = {x}, A = {A:f3}"); //$ - для вывода значений, f3 - определяет количество символов после запятой (здесь 3)
            return A;
            
        }

        static void array()// Здесь вначале мы объявили массив nums, который будет хранить данные типа int. Далее используя операцию new, мы выделили память для 4 элементов массива: new int[5].
                           // Число 4 еще называется длиной массива. При таком определении все элементы получают значение по умолчанию, которое предусмотренно для их типа. Для типа int значение по умолчанию -0.
                           // в {} перечисляются элементы массива
        {
            int[] nums = new int[5] {1,2,3,4,5};
            Console.Write("введите парядковый номер элемента массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write($"значение элемента массива под номером {x} равно = ");
            Console.WriteLine(nums[x]);
           
        }
    }
}
