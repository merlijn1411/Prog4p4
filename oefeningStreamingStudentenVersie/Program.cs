using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace oefeningStreamingStudentenVersie
{
    internal class Program
    {
        private string file;
        private int levelSize = 10;
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.ReadLevel();
        }

        private void ReadLevel()
        {
            //gebruik een StreamReader om de regels 1 voor 1 te lezen

            //lees 10 regels, en zet die op het scherm

            
            using (StreamReader reader = new StreamReader(file))
            {
                string horizontaleRegel;
                int Lijntjes = 10;
                for (int i = 0; i < Lijntjes; i++)
                {
                    horizontaleRegel = reader.ReadLine();

                    Console.WriteLine(horizontaleRegel);
                }

            }
        }

        private Program()
        {
            file = Path.Combine(new FileInfo(typeof(Program).Assembly.Location).Directory.FullName, "testworld.txt");

            WorldMaker maker = new WorldMaker(file, levelSize);
            maker.RollWorld();
        }

    }
}