namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("how much money are you depositing?");
            var deposit = double.Parse(Console.ReadLine());

            Console.WriteLine("this is how much money is your account");
            account.Deposit(deposit);
            double final = account.GetBalance();
            account.GetBalance();
        }
    }
}
