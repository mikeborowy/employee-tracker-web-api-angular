﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracker.Services.Common
{
    public interface IConnection
    {
        string ConnectionString { get; }
    }
}
