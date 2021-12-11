<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionnaireDetail.aspx.cs" Inherits="Questionnaire.Back_end.QuestionnaireDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
       <h1>填寫資料</h1>
        姓名<asp:TextBox ID="Dtxt_name" runat="server"></asp:TextBox> &nbsp;&nbsp;
        手機<asp:TextBox ID="Dtxt_tel" runat="server"></asp:TextBox><br /><br />
        Email<asp:TextBox ID="Dtxt_mail" runat="server"></asp:TextBox>&nbsp;
        年齡 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
  
        <asp:Literal ID="ltl_inputtime" runat="server"></asp:Literal><br />

    </form>
</body>
</html>
