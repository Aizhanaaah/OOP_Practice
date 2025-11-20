namespace Motorcycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int NumOfLines(string filename)
            {
                StreamReader f = new StreamReader(filename);
                int ln = 0;
                while (!f.EndOfStream)
                {
                    f.ReadLine();
                    ln++;
                }
                f.Close();
                return ln;
           }
           int ln = NumOfLines("motor.txt");


            void ListOfMotor()
            {
                StreamReader f = new StreamReader("motor.txt");
                Motor[] motors = new Motor[ln];
                for (int i = 0; i < ln; i++)
                {
                    motors[i] = new Motor(f.ReadLine());
                    Console.WriteLine(motors[i].ShowIt());
                }
                f.Close();
            }

            void ChangeYear()
            {
                Console.Write("name of the motorcycle you want to change the year of: ");
                string name = Console.ReadLine();
                StreamReader f = new StreamReader ("motor.txt");
                Motor[] motors = new Motor[ln];
                for (int i = 0; i < ln; i++)
                {
                    motors[i] = new Motor(f.ReadLine());
                    if (motors[i].Brand == name)
                    {
                        Console.WriteLine("current year is: {0}", motors[i].Year);
                        Console.Write("your change: ");
                        int change = int.Parse(Console.ReadLine());
                        motors[i].Year = change;
                        Console.WriteLine("changed as {0}", motors[i].Year);
                    }
                }
                f.Close();

                StreamWriter fw = new StreamWriter("motor.txt", false);
                foreach (Motor m in motors)
                {
                    fw.WriteLine($"{m.Brand}:{m.Price}:{m.Year}");
                }
                fw.Close();
            }
            void ChangePrice()
            {
                Console.Write("name of the motorcycle you want to change the price of: ");
                string name = Console.ReadLine();
                StreamReader f = new StreamReader("motor.txt");
                Motor[] motors = new Motor[ln];
                for (int i = 0; i < ln; i++)
                {
                    motors[i] = new Motor(f.ReadLine());
                    if (motors[i].Brand == name)
                    {
                        Console.WriteLine("current price is: {0}", motors[i].Price);
                        Console.Write("your change: ");
                        int change = int.Parse(Console.ReadLine());
                        motors[i].Price = motors[i].PriceChange(change);
                        Console.WriteLine("changed as {0}", motors[i].Price);
                    }
                }
                f.Close();

                StreamWriter fw = new StreamWriter("motor.txt", false);
                foreach (Motor m in motors)
                {
                    fw.WriteLine($"{m.Brand}:{m.Price}:{m.Year}");
                }
                fw.Close();
            }

            void AddNewMotor()
            {
                Console.Write("New motor brand name:");
                string newBrand = Console.ReadLine();
                Console.Write("Price of that motorcycle:");
                int newPrice = int.Parse(Console.ReadLine());
                Console.Write("Year of that motorcycle:");
                int newYear = int.Parse(Console.ReadLine());
                StreamWriter f = new StreamWriter("motor.txt", true);
                string line = $"{newBrand}:{newPrice}:{newYear}";
                f.WriteLine(line);
                f.Close();
                Motor[] motors = new Motor[ln];
                StreamWriter fw = new StreamWriter("motor.txt", false);
                foreach (Motor m in motors)
                {
                    fw.WriteLine($"{m.Brand}:{m.Price}:{m.Year}");
                }
                fw.Close();
            }

            Console.WriteLine("1. Provide a list of motorcycles");
            Console.WriteLine("2. Change the year");
            Console.WriteLine("3. Change the price");
            Console.WriteLine("4. Add a new motorcycle");
            Console.Write("choose one task:");
            int taskNum = int.Parse(Console.ReadLine());

            switch (taskNum)
            {
                case 1:ListOfMotor();
                    break;
                case 2: ChangeYear();
                    break;
                case 3: ChangePrice();
                    break;
                case 4: AddNewMotor();
                    break;
                default: break;
                case 0: break;
            }
        }
        
    }
}
