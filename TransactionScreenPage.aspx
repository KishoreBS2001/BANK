<%@ Page Language="C#" Inherits="BANK.TransactionScreenPage" Debug="true"
    CodeFile="Businesslogic/TransactionScreenPage.aspx.cs" %>
    <!DOCTYPE html>
    <html>

    <head>
        <title>Transaction Details</title>
        <!-- <script src="Scripts/TransactionScreenPage.js"></script> -->
    </head>

    <body>
        <div class="form1">
            <h1>Transaction Form</h1>
            <form runat="server">
                <label><b>Account Number:</b></label>
                <input type="text" id="AccountNumberTxt" runat="server" placeholder="Number"><span id="accnam"></span>
                <br>
                <label><b>Transaction Type:</b></label>
                <asp:RadioButton id="Deposit" runat="server" text="Deposit" GroupName="trans"></asp:RadioButton>
                <asp:RadioButton id="Withdraw" runat="server" text="Withdraw" GroupName="trans"></asp:RadioButton>
                <br>
                <label><b>Amount:</b></label>
                <input type="text" id="AmountTxt" runat="server" placeholder="Amount"><span id="amt"></span>
                <br>
                <label><b>Comment:</b></label>
                <input type="text" id="CommentTxt" runat="server" placeholder="Comment">
                <br>
                <label><b>Transaction Date:</b></label>
                <input type="text" id="DateTxt" runat="server" placeholder="Date"><span id="date"></span>
                <br>
                <input type="submit" id="SubmitButton" runat="server" onserverclick="Submit_Click">
                <input type="reset" id="ResetButton" runat="server">
                <div>
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
                </div>
                <div id="NoDataDiv" runat=server></div>
                </asp:Repeater>





            </form>
        </div>
    </body>

    </html>