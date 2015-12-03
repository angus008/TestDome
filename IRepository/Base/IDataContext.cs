using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRepository
{
    public interface IDataContext<T>
    {
        void Add<T>(T t);
        void Update<T>(T t);
        void Get<T>(T t);
        void Load<T>(T t);
        void Flush();
    }
}
