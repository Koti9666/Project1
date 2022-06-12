using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

   
    public class DAL
    {
    }
    
    public class ClsDataLayer
    {
        public bool confirm;
        SqlConnection con = new SqlConnection("Data Source=CESL-HF-L-343;Initial Catalog=Project;Integrated Security=True");
        public void InsertData(string _username, string _email, string _password)
        {
            SqlDataAdapter adp = new SqlDataAdapter("insert into Register1 values('" + _username + "' , '" + _email + "' , '" + _password + "')", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

        }
        public void CheckLogin(string _username, string _password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Register1 where Username='" + _username + "'  and Password='" + _password + "'", con);
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    confirm = true;
                }
            }
            con.Close();
        }
    }
}
