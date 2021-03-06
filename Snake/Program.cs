﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //вместо нижеописанного задействуем класс point

            Point p1 = new Point();//создаем экземпляр класса(объект)
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            //Draw(p1.x, p1.y, p1.sym); вместо этого, можно в классе указать работу с функцией
            p1.Draw();


           /* int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            
            Draw(x1, y1, sym1);//теперь мы можем использовать функцию
            */
            //Console.SetCursorPosition(x1, y1);//установить курсор на позицию
            //Console.Write(sym1);

            //аналогично делаем со второй точкой

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            Draw(p2.x, p2.y, p2.sym);

            /*int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);
            */
           //Console.SetCursorPosition(x2, y2);//установить курсор на позицию
            //Write(sym2);

            Console.ReadLine();
        }
            static void Draw(int x, int y, char sym){

                Console.SetCursorPosition(x, y);//установить курсор на позицию
                Console.Write(sym);

            }
        
    }
}
