namespace oop
{

    internal class Program
    {
        
        class Cat
        {
            string name;
            double mass;
            bool hungry;
            

            public Cat(string name, double mass, bool hungry)
            {
                this.name = name;
                this.mass = mass;
                this.hungry = hungry;
                
            }

            public Cat()
            {
                Console.Write("Enter name of the cat: ");
                name = Console.ReadLine();
                Console.Write("Enter mass of the cat: ");
                mass = double.Parse(Console.ReadLine());
                hungry = true;
            }

            public bool Eats() => hungry;
            

            public double Feed(double foodAmount)
            {
                
                if (hungry)
                {
                    Console.WriteLine("Do you want to feed her?");
                    Console.WriteLine("y/n");
                    string y = "y";
                    string n = "n";
                    string userFood = Console.ReadLine();
                    if (userFood == y)
                    {
                        mass += foodAmount;
                        hungry = false;
                        Console.WriteLine($"{name} ate {foodAmount} kg of food.");
                        return mass;
                    }
                    else if (userFood == "n")
                    {
                        Console.WriteLine("Ahm... Okay, but would be nice if you did so");
                        return mass;
                    }
                    else
                    {
                        Console.WriteLine("so what? yes or no?");
                        return mass;
                    }
                }
                else
                {
                    Console.WriteLine($"{name} is not hungry.");
                    return mass;
                }
            }


          
            public bool RunsAround()
            {
                if (mass >= 4)
                {
                    Console.WriteLine("The cat is running around!");
                    mass -= 0.1;
                    if (mass <= 0)
                    {
                        mass = 0;
                        hungry = true;
                        Console.WriteLine("Cat has stopped running around... no enery");
                    }
                    return true;
                }
                else 
                {
                    Console.WriteLine("Unfortunately the cat cannot run around...");
                    return false; 
                }
            }





            public string State()
            {
                string hun = "";
                if (Eats())
                {
                    hun = "hungry";
                }
                else
                {
                    hun = "not hungry";
                }
                string currentState = $"The name of the cat is {name}, the current mass is {mass}, and the cat is {hun}";
                return currentState;
            }

        }

        


        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Feed(1);
            cat1.RunsAround();
            Cat cat2 = new Cat();
            cat2.Feed(1);
            cat2.RunsAround();
            cat1.State();
            cat2.State();
        }
    }
}
