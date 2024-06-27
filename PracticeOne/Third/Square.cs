using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Third;

public class Square : Difference
{
    public override double Calculate(int a, int b)
    {
        double difference = base.Calculate(a, b);
        return Math.Sqrt(difference);
    }
}
