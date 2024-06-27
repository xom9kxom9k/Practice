using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Third;

public class Cyrcle : Figure
{
    public override double Width { get; set; }
    public override double Height { get ; set ; }
    public Cyrcle(double width, double height) : base(width, height) { }

    public override double Area()
    {
        return Math.PI * Width;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Width / 2;
    }
    public void Draw(PictureBox pb, Figure figure)
    {
        Random rnd = new Random();
        Pen penDefault = new Pen(Color.Black, 2);
        SolidBrush brushDefault = new SolidBrush(Color.Black);
        Bitmap bmp = new Bitmap(pb.Width, pb.Height);
        Graphics g = Graphics.FromImage(bmp);
        int x = figure.x;
        int y = figure.y;
        g.FillEllipse(brushDefault, x, y, (int)figure.Width, (int)figure.Height);
        pb.Image = bmp;
    }
}
