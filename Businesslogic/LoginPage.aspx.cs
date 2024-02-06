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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passWordtxt.Attributes["type"] = "number";
        }
        protected void clickbtn(object sender, EventArgs e)
        {
            // string uname=Request.QueryString["userName"];
            string uname=Request.Form["userName"];
            string pd=Request.Form["passWordtxt"];
            string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string tr="select * from Loginpage where username= "+"'" + uname +"'" ;
                using(SqlCommand command = new SqlCommand(tr,connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string PWD=reader.GetValue(reader.GetOrdinal("pwd")).ToString();
                        reader.Close();
                         if(PWD!=pd)
                        {
                            Response.Write("Invalid Password");
                        }
                        else{
                            Response.Redirect("HomePage.aspx");
                            
                        }
                    }
                    else{
                        Response.Write("No Data Found");
                    }
                }
                // Response.Write(tr);
                connection.Close();
            }
        }
    }
 }




    



