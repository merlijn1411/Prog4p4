namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Birds = new List<string> {"uil","kraai","hond","papegaai" };

            List<string> Birds2 = new List<string> {"meeuw","duif" };

            Birds.AddRange(Birds2);
            Birds.RemoveAt(2);

            foreach (string birds in Birds)
            {
                Console.WriteLine(birds);
            }
        }
        
        

           
    }
}