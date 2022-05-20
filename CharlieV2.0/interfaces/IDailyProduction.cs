﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.interfaces
{
    public interface IDailyProduction
    {
        int ChocosPerDay { get; set; }
        List<IChocolate> Create();
       
    }
}
