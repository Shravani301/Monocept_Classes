﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal interface IState
    {
        void GetBenefits();
        bool IsInRange(double balance);
    }
}
