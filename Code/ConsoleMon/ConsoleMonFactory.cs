using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMon
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lijntje = File.ReadAllLines("C:\\Users\\merli\\Documents\\Mediacollege\\schooljaar 1\\periode 4\\Progp4\\Code\\ConsoleMon\\monsterdata.txt");

            foreach(string line in lijntje)
            {
                string[] typesplit = line.Split('|');


                string[] consoleMonData = typesplit[0].Split(',');
                Console.WriteLine(line);
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.health = Convert.ToInt32(consoleMonData[2]);
                dataMon.energy = Convert.ToInt32(consoleMonData[4]);
                dataMon.weakness = (Element)Enum.Parse(typeof(Element), consoleMonData[6]);

                Console.WriteLine($"{dataMon.name} {dataMon.health} {dataMon.energy} {dataMon.weakness}");
            }
            Console.WriteLine(datafile);
             
        }
        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText("monsterdata.json");

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }
    }

}
