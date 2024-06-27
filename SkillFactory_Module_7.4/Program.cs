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
            ClearWindow(Color.Green);

            //3.Отрисовка буфера на окне
            SetFillColor(Color.Cyan);

            DrawLine(0, 0, 100, 100);

            FillCircle(200, 200, 100);

            SetFillColor(0, 50, 100);

            FillRectangle(200, 400, 200, 40);
            //Вывод методов отрсовки объектов
            DisplayWindow();

            // 4. Ожидание
            Delay(1);
        }


        Console.ReadLine();
        
        }
    }

