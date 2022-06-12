using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    
    public partial class Login1 : System.Web.UI.Page
    {
       

        SqlConnection con =  new SqlConnection("Data Source=CESL-HF-L-343;Initial Catalog=Project;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.ClsDataLayer dobj = new DAL.ClsDataLayer();
            BLL.ClaBussLayer bll = new BLL.ClaBussLayer();
            bll.Username = TextBox1.Text;
            bll.Password = TextBox2.Text;
            dobj.CheckLogin(bll.Username, bll.Password);
            if (dobj.confirm)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Login1 values( '"+TextBox1.Text+"', '" +TextBox2.Text + "')", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }
                con.Close();
                Response.Redirect("LocationsHome.aspx");
            }

        }
    }
}