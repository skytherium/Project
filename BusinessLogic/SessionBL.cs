using BusinessLogic.core;
using BusinessLogic.Interface;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class SessionBL : User, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            throw new NotImplementedException();
        }
    }
}
