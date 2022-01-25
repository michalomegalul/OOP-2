using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2;

public class Matematic
{
    private double _pi;
    public Matematic(double pi)
    {
        this._pi = pi;
    }
    public void CircumferenceOfACircle()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"obvod:{_pi * 3.14}");
        Console.WriteLine($"obsah:{(_pi * _pi) * 3.14}");
    }

}

