using CreditCard;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Card creditCard = new Card("1234 5678 9012 3456", "John Doe", "12/24", 1234, 5000, 2000);

            creditCard.AccountReplenishment += (sender, amount) =>
            {
                Console.WriteLine($"Account replenished by {amount}. Current balance: {creditCard.Balance}");
            };
            creditCard.MoneyWithdrawal += (sender, amount) =>
            {
                Console.WriteLine($"Money withdrawn: {amount}. Current balance: {creditCard.Balance}");
            };
            creditCard.CreditStart += (sender, amount) =>
            {
                Console.WriteLine($"Credit started. Current credit amount: {creditCard.CreditAmount}");
            };
            creditCard.CreditLimitReached += (sender, amount) =>
            {
                Console.WriteLine($"Credit limit reached: {creditCard.CreditLimit}. Current credit amount: {creditCard.CreditAmount}");
            };
            creditCard.PinChanged += (sender, newPin) =>
            {
                Console.WriteLine($"PIN changed. New PIN: {newPin}");
            };

            creditCard.ReplenishAccount(1000);
            creditCard.WithdrawMoney(500);
            creditCard.StartCredit(1500);
            creditCard.WithdrawMoney(4000);
            creditCard.ChangePin(4321);

            Console.ReadKey();
        }
    }
}