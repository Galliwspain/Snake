using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()//КОНСТРУКТОР!!! всегда задан неявно, по умолч ничего не возвращает
        { 
        }

        public Point(int _x, int _y, char _sym) //создаем конструктор для упрощения подачи значений
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        //ключевое слово void указывает что функция ничего не возвращает
        public void Draw() {        
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
