using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    public class SimCardAccount
    {
        private double balance;
        public SimCardAccount()
        {

        }
        public SimCardAccount(double balance)
        {
            this.balance = balance;
        }
        public double Balance
        {
            get { return balance; }
        }

        public void Recharge(double amount)
        {
            if(amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
        }

        public void BuyData(double amount)
        {
            if(amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(balance));
            }
            balance -= amount;
        }

        public bool BorrowAirTime(double amount)
        {
            if(balance != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeductAirtime(double amount)
        {
            if(amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance -= amount;
        }

        public void TransferToFriends(SimCardAccount otherSim, double amount)
        {
            if (otherSim is null)
            {
                throw new ArgumentOutOfRangeException(nameof(otherSim));
            }
            DeductAirtime(amount);
            otherSim.Recharge(amount);
        }

        public bool AirTimeBalanceIsLow()
        {
            if(Balance < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
