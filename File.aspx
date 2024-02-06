<%@ Page Language="C#" Inherits="BANK.File" Debug="true" CodeFile="Businesslogic/File.aspx.cs" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <form runat="server">

        <p>Upload File :</p>
        <asp:FileUpload id="myfile" runat="server"></asp:FileUpload><br>
        <input type="submit" runat="server" onserverclick="filesubmit">
    </form>
    
</body>
</html>