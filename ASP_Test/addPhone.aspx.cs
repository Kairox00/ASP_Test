using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Test
{
    public partial class addPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addMobile(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String mobile = mobileNumber.Text;
            int id = Int16.Parse(Session["user"].ToString());
            Response.Write(Session["user"]);

            SqlCommand addMobile = new SqlCommand("addMobile", conn);
            addMobile.CommandType = CommandType.StoredProcedure;
            addMobile.Parameters.Add(new SqlParameter("@id", id));
            addMobile.Parameters.Add(new SqlParameter("@mobile_number", mobile));

            conn.Open();
            addMobile.ExecuteNonQuery();
            conn.Close();
        }

    }
}