﻿using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface  ISession
    {
        ULoginResp UserLogin(ULoginData data);
      
    }
}
