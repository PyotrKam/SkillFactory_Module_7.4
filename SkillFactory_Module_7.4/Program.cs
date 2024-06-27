using System;
using SFML.Learning;
using SFML.Graphics;

    class Program : Game
    {
        static void Main(string[] args)
        {

        InitWindow(800, 600, "Meow");
        int x = 200;
        int y = 150;
        int speed = 8;
        int dir = 1;

            while (true)
            {
            //1. Расчёт
            DispatchEvents();

            //Игровая логика


            //2.Очистка буфера и окно
            ClearWindow();

            //3.Отрисовка буфера на окне
            if (x > 550) dir *= -1;
            if (x < 100) dir *= -1;

            x += dir * speed;
            
            

            FillCircle(x, y, 100);
            
            DisplayWindow();

            // 4. Ожидание
            Delay(1);
            }

        
        }
    }

