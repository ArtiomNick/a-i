using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        struct Square
        {
            public int sideLenght;
            public float nr;
            
        }

        public class Rectangle
        {
            public int lenght;
            public int widht;
            public string color;

        }


        static void Main(string[] args)
        {
            //Value types
            Square square = new Square();
            square.sideLenght = 1;
            square.nr = 304;
            int a = square.sideLenght;
            Console.WriteLine(a); //1 ...as a equals 1
            float b = 201;
            square.nr = b;
            Console.WriteLine(b); //201
            Console.WriteLine(square.nr); //201

            //Reference types
            Rectangle rectangle = new Rectangle();
            rectangle.lenght = 4;
            rectangle.widht = 2;
            Rectangle rect = rectangle;
            rect.lenght = 6;
            Console.WriteLine(rectangle.lenght); //6
            rectangle.color = null;
            Console.WriteLine(rectangle.color); //empty space

            //Boxing and Unboxing
            //
            //boxing
            int nr1 = 1, nr2 = 2;
            object obj = nr1;
            obj = (object)nr2;

            int nr3 = (int)obj; //unboxing

            //boxing
            List<object> dataList = new List<object>();
            dataList.Add(square.sideLenght);
            dataList.Add(square.nr);
            dataList.Add(rectangle.lenght);
            Console.WriteLine(String.Concat("Rectangle with lenght ", rectangle.lenght, ", width ", 2, " and has color - ", rectangle.color != null));

            //Parameter modifiers
            int nr = 3;
            func1(nr, rectangle, rect);
            Console.WriteLine(String.Concat("Results of func1: ", nr, ", ", rect.lenght, ", ", rectangle.lenght));//3,8,8
            func2(ref nr, ref rectangle, ref rect);
            Console.WriteLine("Results of func2: " + nr + " " + rect.lenght + " " + rectangle.lenght);//8 10 0
            func3(out nr, out rect);
            Console.WriteLine("Results of func2: " + nr + " " + rect.lenght);//3 0
            Console.ReadLine();
        }

        static void func1(int nr, Rectangle rectangle, Rectangle rect)
        {
            nr = rectangle.lenght; //6
            rect.lenght = 8;
            rectangle = new Rectangle();
        }

        static void func2(ref int nr, ref Rectangle rectangle, ref Rectangle rect)
        {
            nr = rectangle.lenght; //8
            rect.lenght = 10;
            rectangle = new Rectangle();
        }

        static void func3(out int nr, out Rectangle rect)
        {
            nr = 3;
            rect = new Rectangle();
        }

    }
}

