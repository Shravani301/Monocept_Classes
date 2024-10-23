using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class State
    {
        private readonly Dictionary<IState, (double min, double max)> _stateTransitions;

        public State()
        {
            _stateTransitions = new Dictionary<IState, (double, double)> {
            { new SilverState(), (0, 9999) },
            { new GoldState(), (10000, 24999) },
            { new PlatinumState(), (25000, 49999) },
            
        };
        }

        public IState GetState(double balance)
        {
            return _stateTransitions.FirstOrDefault
                (s => balance >= s.Value.min && balance <= s.Value.max).Key;
        }
    }
}
