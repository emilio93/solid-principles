﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    public interface IRegularEmployee : IEmployeeBase
    {
        string GetEmployeeDetails(int employeeId);
    }
}
