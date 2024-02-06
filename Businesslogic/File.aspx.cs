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
    public partial class File : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void filesubmit(object sender, EventArgs e)
        {
            // string savePath = @"C:\Users\HP\Desktop\BANK\Files\";
            // if (myfile.HasFile)
            // {
            //     string fileName = myfile.FileName;
            //     savePath += fileName;
            //     myfile.SaveAs(savePath);
                
            // }




            string savePath = @"C:\Users\HP\Desktop\BANK\Files\";
            if (myfile.HasFile)
            {
                
                    int fileSize = myfile.PostedFile.ContentLength;
                    string fileName = Server.HtmlEncode(myfile.FileName);
                    string extension = System.IO.Path.GetExtension(fileName);
                    if (fileSize < 2097152)
                    {
                        if((extension==".doc")||(extension==".txt")||(extension==".xlsx"))
                        {
                            savePath += fileName;
		                    myfile.SaveAs(savePath);
                            Response.Write("Successfully Uploaded");
                        }
                        else{
                            Response.Write("Invalid Extension");
                        }
                        
                    }
                    else
                    {
                        Response.Write("File Too Large");
                    }
            }
        }
    }
 }




    



