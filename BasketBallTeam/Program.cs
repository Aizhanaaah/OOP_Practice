namespace Players
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < Team.AllPlayers.Length; i++)
            {
                Console.WriteLine(@"# " + (i + 1) + " " + Team.AllPlayers[i].Name + ", " + Team.AllPlayers[i].P);
            }

            Team bteam = new Team();

            do
            {
                Console.WriteLine();
                Console.WriteLine("The number of the player:");
                int number = int.Parse(Console.ReadLine());
                bteam.AddPlayer(Team.AllPlayers[number - 1]);

                for (int i = 0; i < bteam.NumberOfPlayers; i++)
                {
                    Console.WriteLine(bteam.StartingLineUp[i].Name + ", " + bteam.StartingLineUp[i].P);
                }

            } while (bteam.StartingLineUp.Length != bteam.NumberOfPlayers);

            for (int i = 0; i < bteam.StartingLineUp.Length; i++)
            {
                Console.WriteLine(bteam.StartingLineUp[i].Name + ", " + bteam.StartingLineUp[i].P);
            }
        }
    }
}
