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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM CUSTOMERS";
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
                        NoDataDiv.InnerHtml = "No Data Found!";
                    }
                    reader.Close();
                }
                connection.Close();

            }

        }
        protected void Edit_Load(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Session["Num"]=btn.CommandArgument;
            Response.Redirect("EditPage.aspx"); 
        }
        protected void Delete_Load(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.CommandArgument;
            string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM CUSTOMERS WHERE CustomerId = " + num;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    NoDataDiv.InnerHtml = "No Data Found!";
                }
            }
            connection.Close();
        }
    }
}