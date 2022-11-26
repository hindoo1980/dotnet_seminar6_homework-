// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

 void findIntersection ()

     {
        int b1;
        int b2;
        int k1;
        int k2;

        float x;
        float y;


        string tmp = string.Empty;

        Console.WriteLine("введите целое число b1 :");

        tmp =  Console.ReadLine();

        bool check = int.TryParse(tmp, out b1);

        if (check == false)
        {
            Console.WriteLine("вы ввели не целое число");
            return;
        }


        tmp = string.Empty;

        Console.WriteLine("введите целое число k1 :");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out k1);

        if (check == false)
        {
            Console.WriteLine("вы ввели не целое число");
            return;
        }


        tmp = string.Empty;

        Console.WriteLine("введите целое число b2 :");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out b2);

        if (check == false)
        {
            Console.WriteLine("вы ввели не целое число");
            return;
        }


        tmp = string.Empty;

        Console.WriteLine("введите целое число k2 :");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out k2);

        if (check == false)
        {
            Console.WriteLine("вы ввели не целое число");
            return;
        }

        if (k1 - k2 == 0 || (k1 - k2) + b1 == 0)
        {
            Console.WriteLine("доделаю такое решение когда нибудь потом");
        }

        else 

        {

            x = (float)(b2-b1)/(float)(k1-k2);

            y = (float)k1*(float)(b2-b1)/(float)(k1-k2)+(float)b1;

            string xPrint = x.ToString("N7");

            string yPrint = y.ToString("N7");

            Console.WriteLine($"координата x точки пересечения прямых - {x} ; y - {y}");

        }

     }

     findIntersection();