using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointDemo();
            ColorDemo();
            WindowDemo();
        }

        private static void WindowDemo()
        {
            Window window = new Window();
            Console.WriteLine(window);

            window.Title = "Window";
            window.Label = "w1";
            window.TopLeft = new Point(1, 1);
            window.BottomRight = new Point(10, 10);
            window.Color=new Color (0,255,255);
            window.IsActive = true;
            Console.WriteLine(window);

            Console.WriteLine($"Width: {window.Width()}");
            Console.WriteLine($"Height: {window.Height()}");

            Console.WriteLine("Area: {0}", window.Area());
            Console.WriteLine("Perimeter: {0}", window.Perimeter());
            window.DrawFill();
            window.DrawBorder();

            Window window2=new Window("Window2","w2", new Point(10, 10), new Point(20,15), new Color(255,0,0), true);
            Console.WriteLine(window2);

            Window window3 = new Window("Window3");
            Console.WriteLine(window3);



        }

        private static void ColorDemo()
        {
            Color color= new Color (0,255,0);
            Console.WriteLine(color);
        }

        private static void PointDemo()
        {
            Point point=new Point(1,2);
            Console.WriteLine(point);
        }
    }
}
