using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2;

public class Chameleon
{
    
    private string _name;
    private string _color;
    private int _height;
    private int _weight;
    private int _lenght;

    private int _colorNumber;
    public Chameleon(string name, string color, int height,int weight,int lenght, int colorNumber)
    {
        this._name = name;
        this._color = color;
        this._height = height;
        this._weight = weight;
        this._lenght = lenght;
        this._colorNumber = colorNumber;
    }
    public void Color()
    {
        Console.WriteLine($"Tento Chameleon:{_name}barva: {_color} vyska:{_height} delka:{_lenght} vaha:{_weight}");
    }
    public void Hunt()
    {
        Console.WriteLine($"{ _name}");
    }
    public void ChangeColor()
    {
        int color = _colorNumber;
        Console.ForegroundColor = (ConsoleColor)color;
        Console.WriteLine($"Jmenosbarvou xoxoxox:{_name}");
    }
    
    
}

