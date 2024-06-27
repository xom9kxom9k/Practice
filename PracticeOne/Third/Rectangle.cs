using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Third;

public class Rectangle : Figure
{
    public Rectangle(double width, double height) : base(width, height) { }
    public override double Width { get; set; }
    public override double Height { get; set; }
    

    public override double Area()
    {
        return Width * Height;
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
    public void Draw(PictureBox pb, Figure figure)
    {
        Random rnd = new Random();
        Pen penDefault = new Pen(Color.Black, 2);
        Bitmap bmp = new Bitmap(pb.Width, pb.Height);
        Graphics g = Graphics.FromImage(bmp);
        int x = figure.x;
        int y = figure.y;
        g.DrawRectangle(penDefault, x, y, (int)figure.Width, (int)figure.Height);
        pb.Image = bmp;
    }
}
