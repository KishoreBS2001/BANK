<%@ Page Language="C#" Inherits="BANK.LoginPage" Debug="true" CodeFile="Businesslogic/LoginPage.aspx.cs" %>

    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Document</title>
        <script src="./JQuery/jquery-3.5.1.js"></script>
        <script src="./Scripts/LoginPage.js"></script>
    </head>

    <body>
        <center>
        <form runat="server" onsubmit="return lval()">
            <h1>
                Login Form 
            </h1>
            <div id="FormDiv">
                <table id="DataTable">
                    <tr>
                        <td><label>Username: </label></td>
                        <td><input type="text" id="userName" runat="server"> <span id="unErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td><label>Password: </label></td>
                        <td><input type="text" id="passWordtxt" runat="server"> <span id="passErr"></span></td>
                    </tr>
                    <tr>
                        <td><input type="submit" id="Sbtn" runat="server" onserverclick="clickbtn"></td>
                    </tr>
                </table>
        </form>
    </center>
    </body>

    </html>