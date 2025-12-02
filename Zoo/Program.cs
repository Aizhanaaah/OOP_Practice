namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method to count number of lines in a file to prepare for reading it:
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

            //methods to read and list all animals and care data from the file:

            void ListOfAnimals()
            {
                int lnAnimals = NumOfLines("animal.txt");
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
                int lnCare = NumOfLines("care.txt");
                StreamReader f = new StreamReader("care.txt");
                Care[] cares = new Care[lnCare];
                for (int i = 0; i < lnCare; i++)
                {
                    cares[i] = new Care(f.ReadLine());
                    Console.WriteLine(cares[i].showInfo());
                }
                f.Close();
            }
            //methods to modify caretaker of an animal and care type of a care record:

            void ModifyCareTaker()
            {
                Console.Write("which animal's caretaker you want to change: ");
                string name = Console.ReadLine();
                StreamReader f = new StreamReader("animal.txt");
                Animal[] animals = new Animal[lnAnimals];
                for (int i = 0; i < lnAnimals; i++)
                {
                    animals[i] = new Animal(f.ReadLine());
                    if (animals[i].Name == name)
                    {
                        Console.WriteLine("current care taker is: {0}", animals[i].Caretaker);
                        Console.Write("your change: ");
                        string change = Console.ReadLine();
                        animals[i].Caretaker = change;
                        Console.WriteLine("changed as {0}", animals[i].Caretaker);
                    }
                }
                f.Close();
                StreamWriter fw = new StreamWriter("animal.txt", false);
                foreach (Animal a in animals)
                {
                    fw.WriteLine($"{a.Name};{a.Species};{a.BirthDate}:{a.Caretaker}");
                }
                fw.Close();
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
                StreamWriter fw = new StreamWriter("care.txt", false);
                foreach (Care c in cares)
                {
                    fw.WriteLine($"{c.Animal};{c.CareType};{c.CareDate}");
                }
                fw.Close();
            }

            //methods to add new animal and care records to the file:
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
            }
            //user interface:
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1. List the animals");
            Console.WriteLine("2. List the care");
            Console.WriteLine("3. Append a new animal");
            Console.WriteLine("4. Append a new care");
            Console.WriteLine("5. Change the caretaker of an animal");
            Console.WriteLine("6. Modify the care type");
            while (true)
            {
                Console.Write("choose one task:");
                int taskNum = int.Parse(Console.ReadLine());

                switch (taskNum)
                {
                    case 1:
                        ListOfAnimals();
                        break;
                    case 2:
                        ListOfCare();
                        break;
                    case 3:
                        AddNewAnimal();
                        break;
                    case 4:
                        AddNewCare();
                        break;
                    case 5:
                        ModifyCareTaker();
                        break;
                    case 6:
                        ModifyCareType();
                        break;
                    default: break;
                    case 0: break;
                }
            }
        }
    }
}
