using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IRepository;
using NHibernate;

namespace Repository
{
    public class DataContext<T>:IDataContext<T>,IDisposable
    {
        private static ISession Session;

        public DataContext()
        {
            var cfg = new NHibernate.Cfg.Configuration().Configure("xml/hibernate.cfg.xml");
            Session = cfg.BuildSessionFactory().OpenSession();
        }

        public void Add<T>(T t)
        {
            Session.Save(t);
        }

        public void Update<T>(T t)
        {
            Session.Update(t);
        }

        public void Get<T>(T t)
        {
            Session.Get<T>(t);
        }

        public void Load<T>(T t)
        {
            Session.Load<T>(t);
        }

        public void Dispose()
        {
            Session.Dispose();
        }

        public void Flush()
        {
           Session.Flush();
        }
    }
}
