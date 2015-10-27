﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydrologyCore.Logger
{
    public interface ILogger
    {
        void Log(string msg);
        void Error(string msg);
    }
}
