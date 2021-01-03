using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace ASP_Test
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(username.Text);
            String pass = password.Text;


            SqlCommand loginproc = new SqlCommand("userLogin",conn);
            loginproc.CommandType = System.Data.CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.AddWithValue("@password", pass);
            
            

            SqlParameter success = loginproc.Parameters.Add("@success", System.Data.SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", System.Data.SqlDbType.Int);
            success.Direction = System.Data.ParameterDirection.Output;
            type.Direction = System.Data.ParameterDirection.Output;
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if(success.Value.ToString() == "1")
            {
                Session["user"] = id;
                Response.Write("Hello Brazar");
                if(type.Value.ToString() == "2")
                {
                    Response.Redirect("StudentPortal.aspx");
                }

            }
            else
            {
                Response.Write("Bye Brazar");
            }
        }

    }
}