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
    public partial class viewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void viewAssign(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int sid = Int16.Parse(Session["user"].ToString());
            int cID = Int16.Parse(courseId.Text);

            SqlCommand viewAssign = new SqlCommand("viewAssign", conn);
            viewAssign.CommandType = CommandType.StoredProcedure;
            viewAssign.Parameters.Add(new SqlParameter("@Sid", sid));
            viewAssign.Parameters.Add(new SqlParameter("@courseId", cID));

            conn.Open();
            SqlDataReader rdr = viewAssign.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int courseID = rdr.GetInt32(rdr.GetOrdinal("cid"));
                int number = rdr.GetInt32(rdr.GetOrdinal("number"));
                String type = rdr.GetString(rdr.GetOrdinal("type"));
                int fullGrade = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                Decimal weight = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                DateTime deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                String content = rdr.GetString(rdr.GetOrdinal("content"));

                Label cid = new Label();
                Label num = new Label();
                Label Type = new Label();
                Label full_grade = new Label();
                Label Weight = new Label();
                Label DeadLine = new Label();
                Label Content = new Label();

                cid.Text = "Course ID: " + courseID + "<br>";
                num.Text = "Assignment Number: " + number + "<br>";
                Type.Text = "Type: " + type + "<br>";
                full_grade.Text = "Full Grade: " + fullGrade + "<br>";
                Weight.Text = "Weight: " + weight + "%<br>";
                DeadLine.Text = "Deadline: " + deadline + "<br>";
                Content.Text = "Content: " + content + "<br><br>";

                form1.Controls.Add(cid);
                form1.Controls.Add(num);
                form1.Controls.Add(Type);
                form1.Controls.Add(full_grade);
                form1.Controls.Add(Weight);
                form1.Controls.Add(DeadLine);
                form1.Controls.Add(Content);


            }
        }
    }
    
}