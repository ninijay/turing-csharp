﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalTuringMachine
{
    class CalcNotDefinedException : Exception
    {
        public CalcNotDefinedException(string message) : base(message)
        {
        }
    }
}
