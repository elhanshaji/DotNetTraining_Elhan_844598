using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspExercise_11_2_20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userrequestEntities ctx = new userrequestEntities();
            userdetail f = new userdetail();
            f.fname = fname.Text;
            f.age = int.Parse(age.Text);
            f.lgnname = lgn.Text;
            f.pwd = pwd.Text;
            f.experience = int.Parse(exp.Text);
            f.salexp = double.Parse(sal.Text);
            ctx.userdetails.Add(f);
            ctx.SaveChanges();


            string strFname = lgn.Text;
            Label1.Text = "User Created: " + strFname;
        }
    }
}