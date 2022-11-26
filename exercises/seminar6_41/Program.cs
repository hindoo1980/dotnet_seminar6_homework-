// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

 void evenCounter ()

     {

        string inp = string.Empty;

        float readings;

        int counter = 0;


            while ( inp != "stop")
            {
            Console.WriteLine("введите число или \"stop\" для выхода:");
            inp =  Console.ReadLine();

                if (inp == "stop")
                {
                    break;
                }
                else
                {
                    bool check = float.TryParse(inp, out readings);

                    if (check && readings > 0 )
                    {
                        counter++;
                    }
                    
                }


            }

            Console.WriteLine($"количество введенных положительных чисел равно {counter}");

         
        }

    evenCounter ();

   
    