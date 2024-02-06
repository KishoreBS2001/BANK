<%@ Page Language="C#" Inherits="PROJECTERP.EmployeesLogin" Debug="true" CodeFile="BusinessLogic/EmployeesLogin.aspx.cs"
    %>
    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>EmpLogin</title>
        
    </head>

    <body>
        <form runat="server">
            <h1>

                <center>Login</center>

            </h1>
            <div id="empform"><center>

               
                <table>

                    <tr>
                        <td><label>Employee ID: </label></td>
                        <td><input type="text" id="Empidnum" runat="server"> <span id="EmpIdErr"></span></td>
                    </tr>

                    <tr>
                        <td><label>Employee Name: </label></td>
                        <td><input type="text" id="EmpNameTxt" runat="server"> <span id="EmpNameErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Employee Phone: </label></td>
                        <td><input type="text" id="EmpPhonenum" runat="server"> <span id="EmpPhoneIdErr"></span></td>
                    </tr>

                    <tr>
                        <td><label>Employee Address:</label></td>
                        <td><input type="text" id="EmpAddressTxt" runat="server"> <span id="EmpAddressErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Employee Email:</label></td>
                        <td><input type="text" id="EmpEmailtxt" runat="server"> <span id="EmpEmailErr"></span></td>
                    </tr>

                    <tr>
                        <td><label>Employee DOB :</label></td>
                        <td><input type="text" id="EmpDOBTxt" runat="server"> <span id="EmpDOBErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Employee DOJ: </label></td>
                        <td><input type="text" id="EmpDOJtxt" runat="server"> <span id="EmpDOJErr"></span></td>
                    </tr>

                    <tr>
                        <td><label>Role_Id </label></td>
                        <td><input type="text" id="roleid3Txt" runat="server"> <span id="RoleId3Err"></span></td>
                    </tr>
                    <tr>
                        <td> <input type="submit" id="Submitbtn1" runat="server" 
                                onserverclick="Insert_Emp"></td>
                        <td><input type="reset" id="ResetButton1" runat="server"></td>

                    </tr>
                </table>
            </div></center>
        </form>
    </body>

    </html>