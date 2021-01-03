using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ASP_Test
{
    public partial class viewPromos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Session["user"].ToString());

            SqlCommand viewPromocode = new SqlCommand("viewPromocode", conn);
            viewPromocode.CommandType = CommandType.StoredProcedure;
            viewPromocode.Parameters.Add(new SqlParameter("@sid", id));

            conn.Open();
            SqlDataReader rdr = viewPromocode.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String promocode = rdr.GetString(rdr.GetOrdinal("code"));
                Label code = new Label();
                code.Text = promocode + "<br>";
                form1.Controls.Add(code);
            }
        }
    }
}