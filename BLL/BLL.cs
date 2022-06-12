using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
 
    public class ClaBussLayer
    {
        ClsDataLayer objDAL = new ClsDataLayer();
        private string _username = "";
        private string _password = "";

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public void InsertUser(string _username, string _email, string _password)
        {
            objDAL.InsertData(_username, _email, _password);
        }
      
    }
}
