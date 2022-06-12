using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    public partial class TripDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=CESL-HF-L-343;Initial Catalog=Project;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into BookData values( '" + TextBox1.Text + "', '" + TextBox2.Text + "', '"+TextBox3.Text+"')", con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
            if(TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text== "")
            {
                Response.Write("<script>alert('please enter details');</script>");
            }
            else
            {
                Response.Redirect("ThankYou.aspx");
            }
        }
    }
}