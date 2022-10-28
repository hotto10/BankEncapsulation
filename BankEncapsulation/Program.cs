namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount(100);
            Console.WriteLine($"Your current balance is: {myAccount.GetBalance()}");

            Console.WriteLine("Enter the amount you wish to deposit");
            double depAmount = int.Parse(Console.ReadLine());
            myAccount.Deposit(depAmount);
            Console.WriteLine($"Your new balance is: {myAccount.GetBalance()}");
        }
    }
}
