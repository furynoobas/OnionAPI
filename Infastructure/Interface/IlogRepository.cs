﻿using Infastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Interface
{
   public  interface IlogRepository
    {
        void Insert(ReqestLogEntry entry);
    }
}
