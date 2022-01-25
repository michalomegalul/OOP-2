using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2;

public class Matematic
{
    private int _pi;
    public Matematic(int pi)
    {
        this._pi = pi;
    }
    public void CircumferenceOfACircle()
    {
        Console.WriteLine($"Je to:{_pi * 3.14}");
    }

}

