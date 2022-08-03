using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    class Window
    {
        public string Title { get; set; }
        public string Label { get; set; }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Color Color { get; set; }
        public bool IsActive { get; set; }

        public Window (string title)=> Title = title;
        public Window():this("Window1")
        {
            TopLeft = new Point(0,0);
            BottomRight = new Point(85,25);
        }
        public Window(string title, Point topLeft, Point bottomRight, Color color):this(title)
        {
            TopLeft=topLeft;
            BottomRight=bottomRight;
            Color = color;
        }

        public Window(string title, string label, Point topLeft, Point bottomRight, Color color, bool isActive) : this(title, topLeft, bottomRight, color)
        {
            Label = label;
            IsActive = isActive;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Label: {Label}, TopLeft: {TopLeft}, BottomRight: {BottomRight}, Color: {Color}, Active: {(IsActive ? "yes" : "no")}";
        }

        public int Width()=>Math.Abs(TopLeft.X-BottomRight.X);
        public int Height()=>Math.Abs(TopLeft.Y-BottomRight.Y);
        public int Area() => Width() * Height();
        public int Perimeter() => 2*(Width() + Height());

        public void DrawFill()
        {
            for (int i = 0; i < Height(); i++)
            {
                for (int j = 0; j < Width(); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void DrawBorder()
        {
            for (int i = 0; i < Height(); i++)
            {
                for (int j = 0; j < Width(); j++)
                {
                    if (i==0||i==Height()-1||j==0||j==Width()-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
