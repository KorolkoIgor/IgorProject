﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
   public interface ICalories:IGiftItem
   {
       double Calories { get; }
       string GetTypeConsuption();
    }
}