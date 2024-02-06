<%@ Page Language="C#" Inherits="BANK.TransactionDisplay" Debug="true"
    CodeFile="Businesslogic/TransactionDisplay.aspx.cs" %>
    <!DOCTYPE html>
    <html lang="en">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Mini Bank</title>
        <link rel="stylesheet" href="./Styles/TransactionDisplay.css">
    </head>

    <body>
        <form runat="server">
            <center>
                <asp:Repeater ID="DataRepeater" runat="server">
                    <HeaderTemplate>
                        <h2>Customers Details</h2>
                        <table>
                            <tr>
                                <th>AccountNumber</th>
                                <th>T_Type</th>
                                <th>Amount</th>
                                <th>TransactionDate</th>
                                <th>Comment</th>
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
                                <%# Eval("TransactionDate") %>
                            </td>
                            <td>
                                <%# Eval("Comment") %>
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