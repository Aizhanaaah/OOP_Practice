namespace oop2
{
    internal class Program
    {
        class Student
        {
            string neptun_code;
            int year, credit;


            public Student(string neptun_code, int year, int credit)
            {
                this.neptun_code = neptun_code;
                this.year = year;
                this.credit = credit;
            }

            public Student()
            {
                Console.WriteLine("Enter neptun code: ");
                neptun_code = Console.ReadLine();
                year = 1;
                credit = 0;
            }

            public int subjectChosen(int subjectCredit)
            {
                return credit += subjectCredit;
            }

            public string textState()
            {
                string text = $"Neptun code: {neptun_code}, year: {year}, credit: {credit}";
                return text;
            }

        }

        static void Main(string[] args)
        {
            
            Student[] students = new Student[5];
            int math = 5;
            int physics = 4;
            int history = 3;
            int politics = 6;
            int literature = 4;

            int[] subjectCredit = {math, physics, history, politics, literature };
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].subjectChosen(subjectCredit[i]);
                Console.WriteLine(students[i].textState());
            }
        }
    }
}
