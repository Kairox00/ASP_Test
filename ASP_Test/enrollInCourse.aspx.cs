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
    public partial class enrollInCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void enroll(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Session["user"].ToString());
            int cid = Int16.Parse(courseID.Text);
            int instid = Int16.Parse(InstructorID.Text);

            SqlCommand enrollInCourse = new SqlCommand("enrollInCourse", conn);
            enrollInCourse.CommandType = CommandType.StoredProcedure;
            enrollInCourse.Parameters.Add(new SqlParameter("@sid",id));
            enrollInCourse.Parameters.Add(new SqlParameter("@cid",cid));
            enrollInCourse.Parameters.Add(new SqlParameter("@instr",instid));

            conn.Open();
            enrollInCourse.ExecuteNonQuery();
            conn.Close();
        }
    }
}