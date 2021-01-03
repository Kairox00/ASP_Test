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
    public partial class StudentProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Session["user"].ToString());

            SqlCommand viewMyProfile = new SqlCommand("viewMyProfile", conn);
            viewMyProfile.CommandType = CommandType.StoredProcedure;
            viewMyProfile.Parameters.Add(new SqlParameter("@id", id));

            conn.Open();
            SqlDataReader rdr = viewMyProfile.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String fname = rdr.GetString(rdr.GetOrdinal("first_name"));
                String lname = rdr.GetString(rdr.GetOrdinal("last_name"));
                Decimal gpa = rdr.GetDecimal(rdr.GetOrdinal("gpa"));
                String pass = rdr.GetString(rdr.GetOrdinal("password"));
                byte[] gender1 = (byte[])rdr.GetSqlBinary(rdr.GetOrdinal("gender"));
                String email = rdr.GetString(rdr.GetOrdinal("email"));
                String address = rdr.GetString(rdr.GetOrdinal("address"));

                byte gender = gender1[0];

                Label first_name = new Label();
                Label last_name = new Label();
                Label GPA = new Label();
                Label password = new Label();
                Label Gender = new Label();
                Label Email = new Label();
                Label Address = new Label();
                Label ID = new Label();

                first_name.Text ="First Name: " + fname + "<br>";
                last_name.Text ="Last Name: " + lname + "<br>";
                GPA.Text ="GPA: " + gpa + "<br>";
                password.Text = "Password: " + pass + "<br>";
                Gender.Text = "Gender: " + gender + "<br>";
                Email.Text = "Email: " + email + "<br>";
                Address.Text = "Address: " + address + "<br>";
                ID.Text = "ID: " + fname + "<br>";

                form1.Controls.Add(ID);
                form1.Controls.Add(first_name);
                form1.Controls.Add(last_name);
                form1.Controls.Add(GPA);
                form1.Controls.Add(password);
                form1.Controls.Add(Gender);
                form1.Controls.Add(Email);
                form1.Controls.Add(Address);
            }
            
            


        }
    }
}