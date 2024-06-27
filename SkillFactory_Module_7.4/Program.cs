using System;
using SFML.Learning;

    class Program : Game
    {
        static void Main(string[] args)
        {

        InitWindow(800, 600);

        while (true)
        {
            //1. Расчёт
            DispatchEvents();

            //Игровая логика


            //2.Очистка буфера и окно


            //3.Отрисовка буфера на окне

            //Вывод методов отрсовки объектов
            DisplayWindow();

            // 4. Ожидание
            Delay(1);
        }


        Console.ReadLine();
        
        }
    }

