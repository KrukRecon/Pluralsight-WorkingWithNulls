using System;

namespace GameConsole
{
    public static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("There is no name specified");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            int days = player.DaysSinceLastLogin ?? -1;
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            //int days = player.DaysSinceLastLogin.GetValueOrDefault();
            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);
            //}
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}
            Console.WriteLine($"{days} since last login");

            if (player.DateOfBirth.HasValue)
            {
                Console.WriteLine(player.DateOfBirth.Value);
            }
            else
            {
                Console.WriteLine("No date of birth specified");
            }

            if (player.IsNew is null)
            {
                Console.WriteLine("Player new status is unknown");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is new to the game");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
