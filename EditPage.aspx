<%@ Page Language="C#" Inherits="BANK.EditPage" Debug="true"CodeFile="Businesslogic/EditPage.aspx.cs" %>
    <html>

    <head>
        <title>EditPage</title>
        <link rel="stylesheet" href="./Styles/EditPage.css">
        <script src="./Scripts/EditPage.js"></script>
    </head>

    <body>
        <form runat="server">
            <h1>
                <center>Edit Form</center>
            </h1>
            <div id="FormDiv">
                <table id="DataTable">
                    <tr>
                        <td><label>CustomerName: </label></td>
                        <td><input type="text" id="NameTxt" runat="server"> <span id="NameErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>DOB: </label></td>
                        <td><input type="text" id="DobTxt" placeholder="YYYY-MM-DD" runat="server"> <span id="DateErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Address: </label></td>
                        <td><input type="text" id="AddressTxt" runat="server"> <span id="AddressErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Mobile: </label></td>
                        <td><input type="text" id="MobileTxt" runat="server"> <span id="MobileErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Profession: </label></td>
                        <td>
                            <asp:DropDownList ID="ProfessionSelect" runat="server"></asp:DropDownList> <span
                                id="ProfessionErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td><label>Interests: </label></td>
                        <td>
                            <asp:DropDownList ID="InterestsSelect" runat="server"></asp:DropDownList> <span
                                id="InterestsErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td><label>Designation: </label></td>
                        <td><input type="text" id="DesignationTxt" runat="server"> <span id="DesignationErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td><label>Company: </label></td>
                        <td><input type="text" id="CompanyTxt" runat="server"> <span id="CompanyErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>NumberOfDependents: </label></td>
                        <td><input type="text" id="NumberOfDependentsTxt" runat="server"> <span
                                id="NumberOfDependentsErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>AccountNumber: </label></td>
                        <td><input type="text" id="AccountNumberTxt" runat="server" readonly> <span
                                id="AccountNumberErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>AccountType: </label></td>
                        <td><input type="text" id="AccountTypeTxt" runat="server"> <span id="AccountTypeErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td><label>CurrentBalance: </label></td>
                        <td><input type="text" id="CurrentBalanceTxt" runat="server"> <span
                                id="CurrentBalanceErr"></span></td>
                    </tr>


                </table>
                <input type="submit" id="SubmitButton" runat="server" onclick="return indexvalid()"  onserverclick="Editing">
                <input type="reset" id="ResetButton" runat="server">
            </div>
        </form>
    </body>

    </html>