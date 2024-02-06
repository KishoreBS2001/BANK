<%@ Page Language="C#" Inherits="BANK.IndexPage" Debug="true" CodeFile="Businesslogic/IndexPage.aspx.cs" %>
    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Mini Banking 2023</title>
        <link rel="stylesheet" href="Styles/IndexPage.css">
        <script src="./Scripts/IndexPage.js"></script>
    </head>

    <body>
        <form runat="server">
            <h1>
                <center>Account Form </center>
            </h1>
            <div id="FormDiv">
                <table id="DataTable">
                    <tr>
                        <td><label>Customer Name: </label></td>
                        <td><input type="text" id="NameTxt" runat="server" maxlength="100"> <span id="NameErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>DOB: </label></td>
                        <td><input type="text" id="DobTxt" placeholder="YYYY-MM-DD" runat="server"> <span id="DateErr"></span></td>
                    </tr>
                    <tr>
                        <td><label>Address: </label></td>
                       <td><textarea name="add" id="AddressTxt" runat="server" cols="30" rows="10" ></textarea><span id="AddressErr"></span></td>
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
                        <td><input type="text" id="AccountNumberTxt" runat="server"> <span id="AccountNumberErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="Ts">
                            <label class="Ts1">Account Type: </label>
                            <asp:RadioButton ID="Savings" text="Savings" runat="server" GroupName="AccountType">
                            </asp:RadioButton>
                            <asp:RadioButton ID="Current" text="Current" runat="server" GroupName="AccountType">
                            </asp:RadioButton>
                        </td>

                    </tr>
                    <tr>
                        <td><label>CurrentBalance: </label></td>
                        <td><input type="text" id="CurrentBalanceTxt" runat="server"> <span
                                id="CurrentBalanceErr"></span></td>
                    </tr>


                </table>
                <input type="submit" id="SubmitButton" runat="server" onclick="return valid()"
                    onserverclick="Submit_Load">
                <input type="reset" id="ResetButton" runat="server">
            </div>
        </form>

    </body>

    </html>