namespace oop3
{
    internal class Program
    {
        class Student
        {
            string name, neptun_code, status;
            double year_of_birth;


            public string Name 
            {
                get { return name; } 
                set { name = value; }
            }

            public string Neptun_code
            {
                get { return neptun_code; }
                set { neptun_code = value; }
            }

            public string Status
            {
                get { return status; }
                set { if (value == "active" || value == "passive")
                    status = value; 
                }
            }

            public double Age
            {
                get { return 2025-year_of_birth; }
            }

            public Student(string name, string status, double year_of_birth, string neptun_code)
            {
                this.name = name;
                this.status = status;
                this.year_of_birth = year_of_birth;
                this.neptun_code = neptun_code;
            }

            public Student(string name, string status, double year_of_birth)
            {
                this.name = name;
                this.status = status;
                this.year_of_birth = year_of_birth;
                neptun_code = Gen_Nep();
            }


            string Gen_Nep()
            {
                Random random = new Random();
                string code = "";
                for (int i = 0; i < 6; i++)
                {
                    if (random.Next(1, 101) > 71)
                    {
                        code += (char)random.Next('A', 'Z' + 1);
                    }
                    else
                    {
                        code += (char)random.Next('0', '9' +1);
                    }
                }
                return code;
            }

            public string State()
            {
                string state = $"Name: {name}, Neptun code: {neptun_code}, Age: {Age}, Status: {status}";
                return state;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
