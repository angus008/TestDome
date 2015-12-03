using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IRepository;
using Domain;

namespace Repository
{
    public class UserInfoRepository:DataContext<UserInfo>,IUserInfoRepository
    {
        
    }
}
