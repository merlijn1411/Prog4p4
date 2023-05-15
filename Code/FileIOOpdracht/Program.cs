namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt");

            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
            
            string[] contentNew = new string[] { "Omg het werkt!!" };
            File.WriteAllText("C:\\Users\\merli\\Documents\\Mediacollege\\schooljaar 1\\periode 4\\Progp4\\Code\\FileIOOpdracht\\bin\\Debug\\net7.0\\output","nieuwe content");

            string[] Lijntje = new string[] {"nieuwtje 1 en nieuwtje 2" };
            File.AppendAllLines("C:\\Users\\merli\\Documents\\Mediacollege\\schooljaar 1\\periode 4\\Progp4\\Code\\FileIOOpdracht\\HetNieuweTextBestand.txt",Lijntje);

            Directory.CreateDirectory("output ");

        }
    }
}