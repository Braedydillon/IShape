using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{
    
        interface IShape
        {
            void Draw();
        }

        class Circle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
        class Square: IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Square");
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle();
            IShape shape2 = new Square();

            shape1.Draw();//Calls Cricles Draw
            shape2.Draw();//Calls Squares Draw
        }
    }
}
