<%@ Page Language="C#" Inherits="BANK.HomePage" Debug="true" CodeFile="Businesslogic/HomePage.aspx.cs" %>
    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Mini Bank</title>
        <link rel="stylesheet" href="Styles/HomePage.css">
    </head>
    
    <body>
        <form runat="server">
            <center>
                <button><a href="./IndexPage.aspx">ADD</a></button>
                <button><a href="./TransactionScreenPage.aspx">TransactionType</a></button>
                <button><a href="./SearchPage.aspx">Search</a></button>

                <asp:Repeater ID="DataRepeater" runat="server">
                    <HeaderTemplate>
                        <h2>HOME PAGE</h2>
                        <table>
                            <tr>
                                <th>Customer Id</th>
                                <th>Customer Name</th>
                                <th>DOB</th>
                                <th>Address</th>
                                <th>Mobile</th>
                                <th>Profession</th>
                                <th>Interests</th>
                                <th>Designation</th>
                                <th>Company</th>
                                <th>Numberw_Of_Dependents</th>
                                <th>AccountNumber</th>
                                <th>Account_Type</th>
                                <th>Currenr_Balance</th>
                                <th colspan="2">ACTION</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("CustomerId") %>
                            </td>
                            <td>
                                <%# Eval("CustomerName") %>
                            </td>
                            <td>
                                <%# Eval("DOB","{0:yyyy-MM-dd}") %>
                            </td>
                            <td>
                                <%# Eval("Address") %>
                            </td>
                            <td>
                                <%# Eval("Mobile") %>
                            </td>
                            <td>
                                <%# Eval("Profession") %>
                            </td>
                            <td>
                                <%# Eval("Interests") %>
                            </td>
                            <td>
                                <%# Eval("Designation") %>
                            </td>
                            <td>
                                <%# Eval("Company") %>
                            </td>
                            <td>
                                <%# Eval("NumberOfDependents") %>
                            </td>
                            <td>
                                <%# Eval("AccountNumber") %>
                            </td>
                            <td>
                                <%# Eval("AccountType") %>
                            </td>
                            <td>
                                <%# Eval("CurrentBalance") %>
                            </td>

                            <td><asp:Button Text="Edit" runat="server" CommandArgument='<%#Eval("CustomerId")%>'
                                OnClick="Edit_Load"> </asp:Button></td>
                            <td>
                                <asp:Button Text="DELETE" runat="server" CommandArgument='<%#Eval("CustomerId")%>'
                                    onClientClick="return confirm('Are you sure to Delete the record')"
                                    OnClick="Delete_Load">
                                </asp:Button>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                <div id="NoDataDiv" runat=server></div>
                </asp:Repeater>
            </center>
        </form>
    </body>

    </html>