﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate

    {
        public Private()
        {

        }

        public double Salary { get; }
    }
}
