using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class Card
    {
        private string _cardNumber;
        private string _cardholderName;
        private string _expiryDate;
        private int _pin;
        private decimal _creditLimit;
        private decimal _balance;

        public event EventHandler<decimal> AccountReplenishment;
        public event EventHandler<decimal> MoneyWithdrawal;
        public event EventHandler<decimal> CreditStart;
        public event EventHandler<decimal> CreditLimitReached;
        public event EventHandler<int> PinChanged;

        public Card(string cardNumber, string cardholderName, string expiryDate, int pin, decimal creditLimit, decimal initialBalance)
        {
            _cardNumber = cardNumber;
            _cardholderName = cardholderName;
            _expiryDate = expiryDate;
            _pin = pin;
            _creditLimit = creditLimit;
            _balance = initialBalance;
        }

        public decimal Balance => _balance;
        public decimal CreditAmount { get; private set; }
        public decimal CreditLimit => _creditLimit;

        public void ReplenishAccount(decimal amount)
        {
            _balance += amount;
            AccountReplenishment?.Invoke(this, amount);
        }

        public void WithdrawMoney(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                MoneyWithdrawal?.Invoke(this, amount);
            }
            else if (_balance + _creditLimit >= amount)
            {
                decimal remainingAmount = amount - _balance;
                _balance = 0;
                _creditLimit -= remainingAmount;
                CreditAmount += remainingAmount;
                MoneyWithdrawal?.Invoke(this, amount);
                if (_creditLimit <= 0)
                {
                    CreditLimitReached?.Invoke(this, _creditLimit);
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void StartCredit(decimal amount)
        {
            _creditLimit -= amount;
            CreditAmount += amount;
            CreditStart?.Invoke(this, amount);
        }

        public void ChangePin(int newPin)
        {
            _pin = newPin;
            PinChanged?.Invoke(this, newPin);
        }
    }
}