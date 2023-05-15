namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\merli\Documents\Mediacollege\schooljaar 1\periode 4\Progp4\Code");

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }


            foreach (DirectoryInfo dirs in dir.GetDirectories())
            {
                Console.WriteLine(dirs.Name);
            }
        }
    }
}