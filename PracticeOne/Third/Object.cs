using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Third;

public class ObjectTable
{
    private double _height;
    private double _lentgh;
    private string _color;
    private string _material;
    public ObjectTable(double height, double lentgh, string color, string material)
    {
        Material = material;
        Color = color;
        Height = height;
        Lentgh = lentgh;
    }

    public string Material
    {
        get { return _material; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Материл не может быть пустым");
            }
            _material = value;
        }
    }

    public string Color
    {
        get { return _color; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Цвет не может бвть пустым");
            }
            _color = value;
        }
    }

    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Высота не может быть меньше или равно 0");
            }
            _height = value;
        }
    }

    public double Lentgh
    {
        get { return _lentgh; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Длина не может быть меньше или равно 0");
            }
            _lentgh = value;
        }
    }


    public override string ToString()
    {
        return "Материал : " + _material + " " +
            "Цвет : " + Color + " " +
            "Высота : " + Height + " " +
            "Длина : " + Lentgh;
    }
}
