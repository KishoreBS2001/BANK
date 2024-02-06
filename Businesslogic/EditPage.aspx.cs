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
    public partial class EditPage : System.Web.UI.Page
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
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "select * from DD";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        ProfessionSelect.DataSource = reader;
                        ProfessionSelect.DataTextField = "Profession";
                        ProfessionSelect.DataValueField = "Profession";
                        ProfessionSelect.DataBind();
                    }
                    else
                    {
                        ProfessionSelect.DataSource = null;
                        ProfessionSelect.DataBind();

                    }
                    reader.Close();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        InterestsSelect.DataSource = reader;
                        InterestsSelect.DataTextField = "Interests";
                        InterestsSelect.DataValueField = "Interests";
                        InterestsSelect.DataBind();
                    }
                    else
                    {
                        InterestsSelect.DataSource = null;
                        InterestsSelect.DataBind();
                    }
                    reader.Close();
                }
                // string str_id = Request.QueryString["id"];
                // int id = int.Parse(str_id);
                string id=(string)Session["Num"];
                query = "select * from CUSTOMERS where CustomerId = " + id;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        NameTxt.Value = reader.GetValue(reader.GetOrdinal("CustomerName")).ToString();
                        DobTxt.Value = reader.GetDateTime(reader.GetOrdinal("DOB")).ToString("yyyy-MM-dd");
                        AddressTxt.Value = reader.GetValue(reader.GetOrdinal("Address")).ToString();
                        MobileTxt.Value = reader.GetValue(reader.GetOrdinal("Mobile")).ToString();
                        ProfessionSelect.SelectedValue = reader.GetValue(reader.GetOrdinal("Profession")).ToString();
                        InterestsSelect.SelectedValue = reader.GetValue(reader.GetOrdinal("Interests")).ToString();
                        DesignationTxt.Value = reader.GetValue(reader.GetOrdinal("Designation")).ToString();
                        CompanyTxt.Value = reader.GetValue(reader.GetOrdinal("Company")).ToString();
                        NumberOfDependentsTxt.Value = reader.GetValue(reader.GetOrdinal("NumberOfDependents")).ToString();
                        AccountNumberTxt.Value = reader.GetValue(reader.GetOrdinal("AccountNumber")).ToString();
                        AccountTypeTxt.Value = reader.GetValue(reader.GetOrdinal("AccountType")).ToString();
                        CurrentBalanceTxt.Value = reader.GetValue(reader.GetOrdinal("CurrentBalance")).ToString();
                    }
                    else
                    {
                        Response.Write("Data Not Found");
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }
        protected void Editing(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "update CUSTOMERS set CustomerName = @Value1,DOB = @Value2,Address = @Value3,Mobile = @Value4,Profession=@Value5,Interests=@Value6,Designation=@Value7,Company=@Value8,NumberOfDependents=@Value9,AccountType = @Value10,CurrentBalance=@Value11 where AccountNumber = @Value12";
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
                command.Parameters.AddWithValue("@Value10", Request.Form["AccountTypeTxt"]);
                command.Parameters.AddWithValue("@Value11", Request.Form["CurrentBalanceTxt"]);
                command.Parameters.AddWithValue("@Value12", Request.Form["AccountNumberTxt"]);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    Response.Write("Failed to Update record.");
                }
            }
            connection.Close();
        }
    }
}