using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2;

public class Factory
{
    private string _product;
    private int _numerosa;
    public Factory(string product, int numerosa)
    {
        this._product = product;
        this._numerosa = numerosa;
    }
    public void Product()
    {

        Console.WriteLine($"{_product}");
    }
    public void Productx()
    {
        for (int i = 0; i < _numerosa; i++)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.WriteLine($"{_product}");//co se koukam k patrikovy tak opisuje sadge 
        }

    }
}

