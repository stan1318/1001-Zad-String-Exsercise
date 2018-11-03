using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001_Zad_String_Exsercise
{
    class Program
    {//The point of this program is to remove all equal numbers inputted due to keyboard or else,Example Input:1122888889 Output:1289
        static void Main(string[] args)
        {string thestring ;
       
        Console.WriteLine("Type in you sequence of numbers which you want: ");
             thestring = Console.ReadLine();
             char[] thechars = new char[thestring.Length];
             StringReader sr = new StringReader(thestring);
             sr.Read(thechars,0,thestring.Length);
             for (int i = 0; i < thechars.Length; i++)
             {
                 if (i + 1 == thechars.Length)
                 {
                     Console.Write(thechars[i]);
                 }
                 else
                 {
                     if (thechars[i] != thechars[i + 1])
                     {
                         Console.Write(thechars[i]);
                     }
                 }
             }
            
       
       


        }
    }
}
