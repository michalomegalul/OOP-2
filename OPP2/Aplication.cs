using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2;

public class Aplication
{
    public void Run()
    {
       
        var chamName = new Chameleon("Sweet Pea","RED",3,4,5,0);
        var chamNameClass = new Chameleon("SLURP","void",0,0,0,0);//muzu udelat novou classu ale to semi nechce 
        var chamColor = new Chameleon("SLURP","s",0,0,0,ColorCh());
        chamName.Color();
        chamNameClass.Hunt();
        chamColor.ChangeColor();
        var product = new Factory("omegalul_prosimprimluvsenadvojku.exe", 10);
        product.Product();
        product.Productx();
        var circumferenceofacircle = new Matematic(32);
        circumferenceofacircle.CircumferenceOfACircle();



    }
    public int ColorCh()
    {
        Random rnd = new Random();
        int color = rnd.Next(1, 8);
        return color; //doufam ze je to ono
        
    }
            
}

