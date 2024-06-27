using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Third;

public abstract class Figure
{
    public abstract double Width { get; set; }
    public abstract double Height { get; set; }

    public int x;
    public int y;
    public Figure(double width, double height)
    {
        Random rnd = new Random();
        x = rnd.Next(0, 100);
        y = rnd.Next(0, 100);
        Width = width;
        Height = height;
    }

    public abstract double Area();

    public abstract double Perimeter();
}
