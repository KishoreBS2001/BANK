<%@ Page Language="C#" Inherits="BANK.SearchPage" Debug="true" CodeFile="Businesslogic/SearchPage.aspx.cs" %>
    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Mini Banking 2023</title>
    </head>

    <body>
        <form runat="server" method="get">
            <center>
                <table id="DataTable">
                    <tr>
                        <td><label>AccountNumber: </label></td>
                        <td><input id="AccountNumberTxt" type="text" runat="server"><span id="AccountNumberErr"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="submit" runat="server"  onserverclick="Search">
                        </td>
                    </tr>
                </table>
                </div>

                <asp:Repeater ID="DataRepeater" runat="server">
                    <HeaderTemplate>
                        <h2>Transaction | 2023</h2>
                        <table id="DataTable">
                            <tr>
                                <th>Account Number</th>
                                <th>Transaction Type</th>
                                <th>Amount</th>
                                <th>Comment</th>
                                <th>Transaction Date</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
    
                            <td>
                                <%# Eval("AccountNumber") %>
                            </td>
                            <td>
                                <%# Eval("T_Type") %>
                            </td>
                            <td>
                                <%# Eval("Amount") %>
                            </td>
                            <td>
                                <%# Eval("Comment") %>
                            </td>
                            <td>
                                <%# Eval("TransactionDate","{0:yyyy-MM-dd}") %>
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