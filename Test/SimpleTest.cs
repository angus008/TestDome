using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RepositoryContainer;
using IRepository;
using Repository;
using NHibernate;
using Domain;
using NUnit.Framework;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;
namespace Test
{
    [TestFixture]
    public class SimpleTest
    {
        [Test]
        public void Text1()
        {
            Container con = new Container();
            IUserInfoRepository userinfo = con.Resolve<IUserInfoRepository>();


            UserInfo ui = new UserInfo();
            ui.Name = "zhangdi";
            ui.RowCreateDate = DateTime.Now;

            userinfo.Add(ui);
            userinfo.Flush();
          
         
        }

    }
}
