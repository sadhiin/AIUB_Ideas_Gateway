﻿using DLL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    public interface ICV< MODELCLASS, NUMBER, LOGIC, OTHERS>
    {
        bool Create(MODELCLASS obj);
        List<MODELCLASS> GetAll();
        MODELCLASS GetById(int id);
        List<MODELCLASS> GetByCVID(int id);
        LOGIC Delete(NUMBER id);
        bool Update(MODELCLASS obj);
    }
}
