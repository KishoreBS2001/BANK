using System;
using System.Data.SqlClient;
using System.Configuration;

namespace BANK
{
    public partial class IndexPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MobileTxt.Attributes["type"] = "number";
            NumberOfDependentsTxt.Attributes["type"] = "number";
            AccountNumberTxt.Attributes["type"] = "number";
            CurrentBalanceTxt.Attributes["type"] = "number";
            DobTxt.Attributes["type"]="date";
            
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];
        
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string query = "SELECT * FROM DD";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            ProfessionSelect.DataSource = reader;
                            ProfessionSelect.DataTextField = "Profession";
                            ProfessionSelect.DataValueField = "Profession";
                            ProfessionSelect.DataBind();
                        }
                        else
                        {
                            ProfessionSelect.Items.Clear();
                        }
                        reader.Close();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            InterestsSelect.DataSource = reader;
                            InterestsSelect.DataTextField = "Interests";
                            InterestsSelect.DataValueField = "Interests";
                            InterestsSelect.DataBind();
                        }
                        else
                        {
                            InterestsSelect.Items.Clear();
                        }
                        reader.Close();
                    }
                  

                    connection.Close();
                }

                
               

 
            }
        }

        protected void Submit_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO CUSTOMERS VALUES (@Value1, @Value2, @Value3, @Value4, @Value5,@Value6,@Value7,@Value8,@Value9,@Value10,@Value11,@Value12)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", Request.Form["NameTxt"]);
                    command.Parameters.AddWithValue("@Value2", Request.Form["DobTxt"]);
                    command.Parameters.AddWithValue("@Value3", Request.Form["AddressTxt"]);
                    command.Parameters.AddWithValue("@Value4", Request.Form["MobileTxt"]);                    
                    command.Parameters.AddWithValue("@Value5", ProfessionSelect.SelectedValue);
                    command.Parameters.AddWithValue("@Value6", InterestsSelect.SelectedValue);
                    command.Parameters.AddWithValue("@Value7", Request.Form["DesignationTxt"]);
                    command.Parameters.AddWithValue("@Value8", Request.Form["CompanyTxt"]);
                    command.Parameters.AddWithValue("@Value9", Request.Form["NumberOfDependentsTxt"]);
                    command.Parameters.AddWithValue("@Value10", Request.Form["AccountNumberTxt"]);
                    command.Parameters.AddWithValue("@Value11", Request.Form["AccountType"]);
                    command.Parameters.AddWithValue("@Value12", Request.Form["CurrentBalanceTxt"]);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Response.Write("<h2 style='background-color: green;'>Registered Successfully</h2>");
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                    {
                        Response.Write("Failed to insert record.");
                    }
                }
            }
        }
    }
}
        