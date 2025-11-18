namespace GuestHouse
{
    internal class Program
    {
        static Room[] ForRent(string filename)
        {
            string[] rooms = File.ReadAllLines(filename);
            Room[] apartments = new Room[rooms.Length];
            for (int i = 0; i < rooms.Length; i++)
            {
                int beds = int.Parse(rooms[i]);
                if (beds == 1)
                {
                    apartments[i] = new OneBedroom();
                }
                else if (beds == 2)
                {
                    apartments[i] = new TwoBedroom();
                }
                else
                {
                    apartments[i] = new Suite(beds);
                }
            }
            return apartments;
        }
        static void Rented(Room[] apartments)
        {
            for(int i = 0; i < apartments.Length; i++)
            {
                Console.WriteLine(apartments[i].ShowIt());
            }
        }
        static void Main(string[] args)
        {
            Room[] apartments = ForRent("guesthouses.txt");
            Rented(apartments);
            Console.ReadKey();
            Console.WriteLine("\nOne leaves...\n");
            int i = 0;
            while (apartments[i].Beds != 2)
            {
                i++;
            }
            apartments[i].Leaves(1);
            apartments[i].RentCalc();
            Rented(apartments);
            Console.WriteLine("\nOne moves...\n");
            int j = 0;
            while (apartments[j].Beds != 1)
            {
                j++;
            }
            apartments[j].Moves(apartments[i], 1);
            Rented(apartments);
        }
    }
}
