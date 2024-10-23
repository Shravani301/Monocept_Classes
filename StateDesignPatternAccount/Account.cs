using StateDesignPatternAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class Account
    {
        private IState _currentState;
        private readonly StateTransitionTable _stateTransitionTable;
        public double Balance { get; private set; }

        public Account(double balance)
        {
            Balance = balance;
            _stateTransitionTable = new StateTransitionTable();
            Evaluate(); 
        }

        public void Evaluate()
        {
            _currentState = _stateTransitionTable.GetState(Balance);
        }

        public void GetBenefits()
        {
            _currentState.GetBenefits();
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Evaluate();
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Evaluate();
        }
    }
}