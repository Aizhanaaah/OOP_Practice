using System.Linq;

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

            public bool Eats()
            {
                if (mass <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public double Feed(double foodAmount)
            {

                if (hungry)
                {
                    Console.WriteLine($"Do you want to feed {name}?");
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



            public double GetMass()
            {
                return mass;
            }



            public bool RunsAround()
            {
                if (mass >= 1)
                {
                    Console.WriteLine($"The fattest cat, {name} is running around!");
                    mass -= 1;
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
                if (hungry)
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
                Cat[] cats = new Cat[3];
                for (int i = 0; i < cats.Length; i++)
                {
                    cats[i] = new Cat();
                }
                Console.WriteLine("Lets feed these cats: ");
                double fattestCat = cats[0].GetMass();
                for (int i = 0; i < cats.Length; i++)
                {
                    if (cats[i].Eats())
                    {
                        Console.WriteLine(cats[i].State());
                        cats[i].Feed(1);
                    }
                    if (cats[i].GetMass() > fattestCat)
                    {
                        fattestCat = cats[i].GetMass();
                    }
                }
                

                for (int i = 0; i < cats.Length; i++)
                {
                    if (cats[i].GetMass() == fattestCat)
                    { 
                        cats[i].RunsAround();
                        Console.WriteLine($"The mass of the cat now is {cats[i].GetMass()}");
                    }
                }
                
            }
    }
}
