namespace Bank_Account
{
    internal class Program
    {

        class Bank_Account
        {
            private string accountNum;
            private string name;
            private double balance;

            public double Balance
            {
                get { return balance; }
                set {if (value >= 0)
                    balance = value; }
            }
            public string AccountNum
            {
                get { return accountNum; }
                set { if (value.Length == 17 && value[8] == '-' && value.Substring(0, 8).All(char.IsDigit) && value.Substring(9).All(char.IsDigit))
                    { accountNum = value; }
                    else {
                        throw new ArgumentException("Invalid account number format. Expected NNNNNNNN-NNNNNNNN.");
                    }
                }
            }
            public Bank_Account(string accountNum, string name, double balance)
            {
                this.AccountNum = accountNum;
                this.name = name;
                this.balance = balance;
            }

            public Bank_Account(string name, double balance)
            {
                this.name =name;
                this.balance = balance;
                accountNum = Gen_Acc();
            }

            string Gen_Acc()
            {
                int splitIndex = 8;
                Random random = new Random();
                string acc_num = "";
                for (int i = 0; i < 16; i++)
                {
                    if (random.Next(1, 101) > 71)
                    {
                        acc_num += (char)random.Next('0', '9' + 1);
                    }
                }
                string part1 = acc_num.Substring(0, splitIndex);
                string part2 = acc_num.Substring(splitIndex);
                string result = part1 + "-" + part2;
                return result;
            }

            public string ShowIt()
            {
                return $"Name: {name}, Account number: {accountNum}, balance: {balance}";
            }

            bool Pay(double sum)
            {
                if (balance > 0)
                {
                    Decrease(sum);
                    return true;
                }
                else { return false; }
            }

            void Increase(double sum)
            {
                balance += sum;
            }
            void Decrease(double sum)
            {
                balance -= sum;
            }
            void Interest(double percent)
            {
                balance += (balance * percent) / 100;
            }
        }

        static void Main(string[] args)
        {
            Bank_Account person1 = new Bank_Account("12345678-12345678", "Aizhan Amanova", 150000);
            Console.WriteLine(person1.ShowIt());
        }
    }
}
