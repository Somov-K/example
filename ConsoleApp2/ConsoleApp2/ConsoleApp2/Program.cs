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
            
            // cos();
            // xor();
            //ravenstvo();
            //ifelse();
            // switchh ();
           // ternarnay_operation ();
             // OperatingSystem os = System.Environment.OSVersion; // вывод информации о системе, интересный класс Enviroment
            // file();


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

        static bool ravenstvo()
        {
            int a = 10;
            int b = 15;
            bool c = a == b;
            Console.WriteLine($"{c}");
            return c;

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
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Какое математическое значение выполнить: + или - ?");
        string selection = (Console.ReadLine());
        int z = selection== "+"? (x+y) : (x-y);
        Console.WriteLine(z);
        }
        
        static void file() {
            //StreamWriter creat = new StreamWriter(new FileStream("text.txt", FileMode.Create, FileAccess.ReadWrite));
            StreamWriter fileOut = new StreamWriter("t.txt", true);
            // StreamWriter open = new StreamWriter(new FileStream("text.txt", FileMode.Open, FileAccess.ReadWrite));
            Console.WriteLine("Введите значение x");

            fileOut.WriteLine("asd");

        }
        

    }
}
