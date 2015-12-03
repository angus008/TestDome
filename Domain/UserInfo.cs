using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class UserInfo
    {
        public virtual int? ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Dec { get; set; }
        public virtual DateTime? RowCreateDate { get; set; }
    }
}
