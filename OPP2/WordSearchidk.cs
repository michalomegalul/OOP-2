using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2;

public class WordSearchidk
{
    /// <summary>
    /// OOP vol 2 Uprimne si nejsem jist jestli jste to myslel takto. 
    /// </summary>

    public void Run()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        string[] word = { "sd", "ls", "dt", "po", "qw" };
        int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 1 };
        if (word.Contains("ls") == true)
        {
            Console.WriteLine("ano");
        }
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == "ls")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i - 1}: To prvni idk");
            }
        }
        if (number.Contains(100) == true)
        {
            Console.WriteLine("jo");
        }
        else
        {
            Console.WriteLine("ne");
        }
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == 3)
            {
                Console.WriteLine($"{i-1} : todle je to cislo cisla vol4");
            }
            
        }




    }
}



