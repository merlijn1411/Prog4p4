using EnumOpdracht;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleMon
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TestSkillFunctions();
            Colors myMainThemeColor = Colors.green;
            Console.WriteLine("Hello, World!");

            if (myMainThemeColor == Colors.green)
            {
                Console.WriteLine("dat is mijn kleur!");
            }
        }
        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -150);

            Console.WriteLine(casterMon.energy == -20);
        }
    }
}