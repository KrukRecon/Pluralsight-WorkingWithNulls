using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = null;

            int days = player?.DaysSinceLastLogin ?? -1;
            Console.WriteLine(days);
        }
    }
}
