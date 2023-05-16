using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lijntje = File.ReadAllLines("C:\\Users\\merli\\Documents\\Mediacollege\\schooljaar 1\\periode 4\\Progp4\\Code\\ConsoleMon\\monsterdata.txt");
            Console.WriteLine(datafile,lijntje);

            
        }
    }

}
