using System;
using SFML.Learning;
using SFML.Graphics;

    class Program : Game
    {
        static void Main(string[] args)
        {

        InitWindow(800, 600, "Meow");
           

            while (true)
            {
            //1. Расчёт
            DispatchEvents();

            //Игровая логика


            //2.Очистка буфера и окно
            ClearWindow();

            //3.Отрисовка буфера на окне

            if (GetKey(SFML.Window.Keyboard.Key.F) == true)
            {
                Console.WriteLine("Mewo");
            }

            
            DisplayWindow();

            // 4. Ожидание
            Delay(1);
            }

        
        }
    }

