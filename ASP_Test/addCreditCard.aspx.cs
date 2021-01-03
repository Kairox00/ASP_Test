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
    public partial class addCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addCard(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["connStr"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Session["user"].ToString());
            String number = cardNumber.Text;
            String name = card_holder_name.Text;
            String cvv = cvv_box.Text;
            DateTime expiry_date = expiry_calendar.SelectedDate;

            SqlCommand addCreditCard = new SqlCommand("addCreditCard", conn);
            addCreditCard.CommandType = CommandType.StoredProcedure;
            addCreditCard.Parameters.Add(new SqlParameter("@sid", id));
            addCreditCard.Parameters.Add(new SqlParameter("@number", number));
            addCreditCard.Parameters.Add(new SqlParameter("@cvv", cvv));
            addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName", name));
            addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", expiry_date));

            conn.Open();
            addCreditCard.ExecuteNonQuery();
            conn.Close();


        }
    }
}