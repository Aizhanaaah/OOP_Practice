using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Team
    {
        static int[] ptf;
        static public Player[] AllPlayers;
        static Random R;
        static string filename = "players.txt";
        public Player[] StartingLineUp { get; set; }
        public int NumberOfPlayers { get; set; }

        bool Done()
        {
            return StartingLineUp.Length == NumberOfPlayers;
        }
        bool IsOnTeam(Player player)
        {
            int i = 0;
            while (i < StartingLineUp.Length && StartingLineUp[i] == player)
            {
                i++;
            }
            return i < StartingLineUp.Length;
        }
        bool PositionAvailable(Player player)
        {
            return ptf[(int)player.P] > 0;
        }

        static Team()
        {
            R = new Random();
            ptf = new int[5] { 1, 1, 1, 1, 1 };
            int np = NumberOfLines(filename);
            AllPlayers = new Player[np];
            StreamReader f = new StreamReader(filename);
            for (int i = 0; i < np; i++)
            {
                string[] line = f.ReadLine().Split(";");
                AllPlayers[i] = new Player(line[0], (Position)Enum.Parse(typeof(Position), line[1]));
            }
            f.Close();
        }

        static int NumberOfLines(string filename)
        {
            int count = 0;
            StreamReader f = new StreamReader(filename);
            while (f.ReadLine() != null)
            {
                count++;
            }
            f.Close();
            return count;
        }

        public Team()
        {
            StartingLineUp = new Player[5];
            NumberOfPlayers = 0;
        }

        public void FillItUp()
        {
            do
            {
                int nexttry = R.Next(0, AllPlayers.Length);
                Player player = AllPlayers[nexttry];
                if (!IsOnTeam(player) && PositionAvailable(player))
                {
                    StartingLineUp[NumberOfPlayers] = player;
                    NumberOfPlayers++;
                    ptf[(int)player.P]--;
                }
            } while (!Done());
        }

        public void AddPlayer(Player player)
        {
            if (!IsOnTeam(player) && PositionAvailable(player))
            {
                StartingLineUp[NumberOfPlayers] = player;
                NumberOfPlayers++;
                ptf[(int)player.P]--;
            }
        }
    }
}
