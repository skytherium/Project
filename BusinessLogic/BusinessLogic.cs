﻿using BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSesionBL()
        {
            return new SessionBL();
        }
    }
}
