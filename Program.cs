using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ado_dot_net_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data source=BLT10111\\SQLEXPRESS; Initial Catalog=university; Integrated Security=True ";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select e.eid, s.sname, c.cname from student s inner join enrollment e on e.stid = s.stid inner join course c on c.cid = e.cid";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Enrollment_data> Arr = new List<Enrollment_data>();
          

            while(reader.Read())
            {
                
                string Eid = reader[0].ToString();
                string Sname = reader[1].ToString();
                string Cname = reader[2].ToString();
                Enrollment_data obj = new Enrollment_data();
                obj.eid=Eid;
                obj.sname = Sname;
                obj.cname = Cname;
                Arr.Add(obj);
                
            }
            foreach(Enrollment_data ed in Arr)
            {
                Console.WriteLine(ed.sname);
            }

            con.Close();
            Console.WriteLine("Enter sorting choice:");
            string opt=Console.ReadLine();
            if (opt=="1")
            {
                Arr.Sort(new Cnamecomparer());
            }
            else
            {
                Arr.Sort(new Snamecomparer());
            }
            foreach(Enrollment_data ed in Arr)
            {
                Console.WriteLine(ed.eid + " " + ed.sname + " " + ed.cname);
            }
        }
    }
}
