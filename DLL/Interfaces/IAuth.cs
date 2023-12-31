﻿using DLL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    public interface IAuth
    {
        User Authenticate(string username, string password);
        User GetByEmail(string email);
        User GetByUsername(string username);
    }
}
