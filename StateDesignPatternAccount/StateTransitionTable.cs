using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class StateTransitionTable
    {
        private readonly List<IState> _states;

        public StateTransitionTable()
        {
            _states = new List<IState>
        {
            new SilverState(),
            new GoldState(),
            new PlatinumState()
        };
        }

        public IState GetState(double balance)
        {
           return _states.FirstOrDefault(state => state.IsInRange(balance))
                ?? throw new Exception("No state found for the given balance");
        }
    }
}
