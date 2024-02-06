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
    public partial class TransactionScreenPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
           

                if(IsPostBack){

                
                string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string transactionType = Request.Form["trans"];

                    if (transactionType == "Deposit" || transactionType == "Withdraw")
                    {
                        int accountNumber = Convert.ToInt32(Request.Form["AccountNumberTxt"]);
                        Response.Write(accountNumber);
                        decimal amount = Convert.ToDecimal(Request.Form["AmountTxt"]);
                        Response.Write(amount);
                        decimal currentBalance = 0;
                        string balanceQuery = "SELECT CurrentBalance FROM CUSTOMERS WHERE AccountNumber = @AccountNumber";

                        using (SqlCommand balanceCommand = new SqlCommand(balanceQuery, connection))
                        {
                            balanceCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                            using (SqlDataReader balanceReader = balanceCommand.ExecuteReader())
                            {
                                if (balanceReader.Read())
                                {
                                    // currentBalance = balanceReader.GetOrdinal(0);
                                    currentBalance = balanceReader.GetDecimal(balanceReader.GetOrdinal("CurrentBalance"));
                                    // CurrentBalanceTxt.Value = reader.GetValue(reader.GetOrdinal("CurrentBalance"));

                                }
                            }
                        }
                        if (transactionType == "Withdraw" && amount > currentBalance)
                        {
                            Response.Write("<script>alert('Insufficient funds... Please enter a valid amount.');</script>");
                        }
                        else
                        {
                            string updateQuery = "";

                            if (transactionType == "Deposit")
                            {
                                updateQuery = "UPDATE Customers SET CurrentBalance = CurrentBalance + @Amount WHERE AccountNumber = @AccountNumber";
                            }
                            if (transactionType == "Withdraw")
                            {
                                updateQuery = "UPDATE Customers SET CurrentBalance = CurrentBalance - @Amount WHERE AccountNumber = @AccountNumber";
                            }

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Amount", amount);
                                updateCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                                updateCommand.ExecuteNonQuery();
                            }

                            string insertQuery = "INSERT INTO Transactions (AccountNumber, T_Type, Amount, Comment,TransactionDate) VALUES (@AccountNumber, @TransactionType, @Amount, @Comment,@dt)";
                            Response.Write(insertQuery);
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);
                                insertCommand.Parameters.AddWithValue("@TransactionType", transactionType);
                                insertCommand.Parameters.AddWithValue("@Amount", amount);
                                insertCommand.Parameters.AddWithValue("@Comment", Request.Form["CommentTxt"]);
                                insertCommand.Parameters.AddWithValue("@dt",Request.Form["DateTxt"]);
                                insertCommand.ExecuteNonQuery();
                            }

                            string query = "SELECT * FROM Transactions WHERE AccountNumber = @AccountNumber order by TransactionDate desc";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                                SqlDataReader reader = command.ExecuteReader();

                                DataRepeater.DataSource = reader;
                                DataRepeater.DataBind();
                            }
                            Response.Write("<h2 style='background-color: green;'>Transaction Successful</h2>");
                            Response.Redirect("HomePage.aspx");
                            
                        }
                    }
                    else
                    {
                        Response.Write("<h2 style='background-color: red;'>Invalid Transaction</h2>");
                    }

                    connection.Close();
                }
                }
            }
        }
    }

























































































































































// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Web;
// using System.Web.UI;
// using System.Web.UI.WebControls;
// using System.Configuration;
// using System.Data.SqlClient; 

// namespace BANK
// {
//     public partial class TransactionScreenPage:System.Web.UI.Page
//     {
    
//         protected void Submit_Click(object sender,EventArgs e)
//         {
       
//             string connectionString = ConfigurationManager.AppSettings["LocalDatabase"];

//             SqlConnection connection = new SqlConnection(connectionString);
//             connection.Open();

//             string query = "INSERT INTO TRANSACTIONS VALUES(@Value1,@Value2,@Value3,@Value4,@Value5)";
//             using(SqlCommand command = new SqlCommand(query, connection))
//             {
//                 command.Parameters.AddWithValue("@Value1", Request.Form["AccTxt"]);
//                 command.Parameters.AddWithValue("@Value2", Request.Form["trans"]);
//                 command.Parameters.AddWithValue("@Value3", Request.Form["AmtTxt"]);
//                 command.Parameters.AddWithValue("@Value4", Request.Form["CommTxt"]);
//                 command.Parameters.AddWithValue("@Value5", Request.Form["DateTxt"]);


            
//                 int rowsAffected = command.ExecuteNonQuery();
//                 if (rowsAffected > 0)
//                 {
                    
//                     Response.Write("<h2 style='background-color: green;'>Registered Successfully</h2>");
//                     Response.Redirect("TransactionDisplay.aspx");
                   
//                 }
//                 else
//                 {
//                     Response.Write("Failed to insert record.");
//                 }
//             }
//             connection.Close();
//         }
// }
// }