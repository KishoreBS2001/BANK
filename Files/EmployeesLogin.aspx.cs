using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace PROJECTERP
{
    public partial class EmployeesLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpPhonenum.Attributes["type"] = "number";
                        
        }

        protected void Insert_Emp(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "insert into employees_master VALUES (@Value1, @Value2,@Value3,@Value4,@Value5,@Value6,@Value7,@Value8)";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", Request.Form["Empidnum"]);
                        command.Parameters.AddWithValue("@Value2", Request.Form["EmpNameTxt"]);
                        command.Parameters.AddWithValue("@Value3", Request.Form["EmpPhonenum"]);
                        command.Parameters.AddWithValue("@Value4", Request.Form["EmpAddressTxt"]);
                        command.Parameters.AddWithValue("@Value5", Request.Form["EmpEmailtxt"]);
                        command.Parameters.AddWithValue("@Value6", Request.Form["EmpDOBTxt"]);
                        command.Parameters.AddWithValue("@Value7", Request.Form["EmpDOJtxt"]);
                        command.Parameters.AddWithValue("@Value8", Request.Form["roleid3Txt"]);









                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Response.Write("Registered Successfully");
                            Response.Redirect("EmployeesHomePage.aspx");
                        }
                        else
                        {
                            Response.Write("Failed to insert record.");
                        }
                    }
                }
                catch(Exception ex6)
            {
                string msg6 = ex6.Message;
                    if(msg6.Contains("PRIMARY KEY"))
                    {
                        Response.Write("<script>alert('Role_Id already exixst')</script>");

                    }
                    if(msg6.Contains("FOREIGN KEY"))
                    {
                        Response.Write("<script>alert('Role_ID cannot be found')</script>");

                    }



            }



                connection.Close();
            }

        }

    }
}