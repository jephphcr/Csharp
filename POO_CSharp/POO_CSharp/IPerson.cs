﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address {get; set; }
        void Save();
        List<IPerson> Find();
        void Delete();

    }
}
