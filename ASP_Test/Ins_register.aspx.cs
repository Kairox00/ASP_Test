using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Test
{
    public partial class Ins_register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit_btn_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String first_name = f_name.Value;
            String last_name = l_name.Value;
            String password = pass.Value;
            String email = mail.Value;
            int gender = Int16.Parse(gndr.Value);
            String address = adrs.Value;

            SqlCommand InstructorRegister = new SqlCommand("InstructorRegister", conn);
            InstructorRegister.CommandType = CommandType.StoredProcedure;
            InstructorRegister.Parameters.Add(new SqlParameter("@first_name", first_name));
            InstructorRegister.Parameters.Add(new SqlParameter("@last_name", last_name));
            InstructorRegister.Parameters.Add(new SqlParameter("@password", password));
            InstructorRegister.Parameters.Add(new SqlParameter("@email", email));
            InstructorRegister.Parameters.Add(new SqlParameter("@gender", gender));
            InstructorRegister.Parameters.Add(new SqlParameter("@address", address));

            conn.Open();
            InstructorRegister.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Login.aspx");

        }
    }
}