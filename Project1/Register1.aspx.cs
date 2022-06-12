using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Project1
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClaBussLayer objBLL = new ClaBussLayer();
            objBLL.InsertUser(TextBox1.Text, TextBox2.Text, TextBox3.Text);
            Label1.Text = "Register succussful";
        }
    }
}