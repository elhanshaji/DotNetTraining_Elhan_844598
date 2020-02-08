using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_dot_net_exercise
{
    public class Enrollment_data
    {
        public string eid;
        public string sname;
        public string cname;
    }
    public class Snamecomparer:IComparer<Enrollment_data>
    {
        public int Compare(Enrollment_data x, Enrollment_data y)
        {
            return x.sname.CompareTo(y.sname);
        }
    }
    public class Cnamecomparer : IComparer<Enrollment_data>
    {
        public int Compare(Enrollment_data x, Enrollment_data y)
        {
            return x.cname.CompareTo(y.cname);
        }
    }
}
