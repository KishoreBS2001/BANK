using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace BANK
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void Search(object sender, EventArgs e)
        {

            // if (IsPostBack)
            // {
                string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM TRANSACTIONS WHERE AccountNumber = " + Request.QueryString["AccountNumberTxt"]+"ORDER BY TransactionDate DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows == true)
                    {

                        DataRepeater.DataSource = reader;
                        DataRepeater.DataBind();
                    }
                    else
                    {
                        DataRepeater.DataSource = null;
                        DataRepeater.DataBind();
                        Response.Write("<h2>No Data Found</h2>");
                    }
                    reader.Close();
                }
                connection.Close();
            }

        // }
    }
}
