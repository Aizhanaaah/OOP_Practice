namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
            int lnAnimals = NumOfLines("animal.txt");
            int lnCare = NumOfLines("care.txt");

            void ListOfAnimals()
            {
                StreamReader f = new StreamReader("animal.txt");
                Animal[] animals = new Animal[lnAnimals];
                for (int i = 0; i < lnAnimals; i++)
                {
                    animals[i] = new Animal(f.ReadLine());
                    Console.WriteLine(animals[i].showInfo());
                }
                f.Close();
            }
            void ListOfCare()
            {
                StreamReader f = new StreamReader("care.txt");
                Care[] cares = new Care[lnCare];
                for (int i = 0; i < lnCare; i++)
                {
                    cares[i] = new Care(f.ReadLine());
                    Console.WriteLine(cares[i].showInfo());
                }
                f.Close();
            }

            void ModifyCareType()
            {
                Console.Write("which year's care type you want to change: ");
                string date = Console.ReadLine();
                StreamReader f = new StreamReader("care.txt");
                Care[] cares = new Care[lnCare];
                for (int i = 0; i < lnCare; i++)
                {
                    cares[i] = new Care(f.ReadLine());
                    if (cares[i].CareDate == DateTime.Parse(date))
                    {
                        Console.WriteLine("current care type is: {0}", cares[i].CareType);
                        Console.Write("your change: ");
                        string change = Console.ReadLine();
                        cares[i].CareType = change;
                        Console.WriteLine("changed as {0}", cares[i].CareType);
                    }
                }
                f.Close();
                StreamWriter fw = new StreamWriter("care", false);
                foreach (Care c in cares)
                {
                    fw.WriteLine($"{c.Animal};{c.CareType};{c.CareDate}");
                }
                fw.Close();
            }

            void AddNewAnimal()
            {
                Console.Write("New animal name:");
                string newName = Console.ReadLine();
                Console.Write("New animal type:");
                string newType = Console.ReadLine();
                Console.Write("New birth-date:");
                DateTime newDate = DateTime.Parse(Console.ReadLine());
                Console.Write("New care taker:");
                string newCaretaker = Console.ReadLine();
                StreamWriter f = new StreamWriter("animal.txt", true);
                string line = $"{newName};{newType};{newDate};{newCaretaker}";
                f.WriteLine(line);
                f.Close();
                Animal[] animals = new Animal[lnAnimals];
                StreamWriter fw = new StreamWriter("animal.txt", false);
                foreach (Animal a in animals)
                {
                    fw.WriteLine($"{a.Name};{a.Species};{a.BirthDate};{a.Caretaker}");
                }
                fw.Close();
            }

            void AddNewCare()
            {
                Console.Write("New animal name for care:");
                string newName = Console.ReadLine();
                Console.Write("New caring type:");
                string newType = Console.ReadLine();
                Console.Write("New care date:");
                DateTime newDate = DateTime.Parse(Console.ReadLine());
                StreamWriter f = new StreamWriter("care.txt", true);
                string line = $"{newName};{newType};{newDate}";
                f.WriteLine(line);
                f.Close();
                Care[] cares = new Care[lnCare];
                StreamWriter fw = new StreamWriter("care.txt", false);
                foreach (Care c in cares)
                {
                    fw.WriteLine($"{c.Animal};{c.CareType};{c.CareDate}");
                }
                fw.Close();
            }

        }
    }
}
