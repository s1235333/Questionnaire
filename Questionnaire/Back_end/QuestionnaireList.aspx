<%@ Page Title="" Language="C#" MasterPageFile="~/Back_end/BackMaster.Master" AutoEventWireup="true" CodeBehind="QuestionnaireList.aspx.cs" Inherits="Questionnaire.Back_end.QuestionnaireList" %>

<%@ Register Src="~/Back_end/UserControl/ucPager.ascx" TagPrefix="uc1" TagName="ucPager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    請選擇問卷搜尋方式：<br />
    <asp:RadioButton ID="rdTitle" runat="server" Text="依照問卷標題查詢" Checked="false" OnCheckedChanged="rdTitle_CheckedChanged" AutoPostBack="true" />
    <asp:RadioButton ID="rdDate" runat="server" Text="依照時間範圍查詢" Checked="false" OnCheckedChanged="rdDate_CheckedChanged" AutoPostBack="true" />

    <br />


    <asp:PlaceHolder ID="plTitle" runat="server" Visible="false">問卷標題:
        <asp:TextBox ID="title" runat="server" Width="406px"></asp:TextBox><br />
        <br />

    </asp:PlaceHolder>


    <asp:PlaceHolder ID="plDate" runat="server" Visible="false">開始時間/結束時間:  
            <br />
        <asp:TextBox ID="txtbgn_time" runat="server" ReadOnly="true"></asp:TextBox>
        &nbsp;
    <asp:ImageButton ID="imgBsdate" runat="server" src="../icon/Calendar.png" Height="20"
        OnClick="imgBsdate_Click" />
        <asp:Calendar ID="clsdate" runat="server" Visible="false" OnSelectionChanged="clsdate_SelectionChanged" Height="70"></asp:Calendar>
        <br />
        <asp:TextBox ID="txtend_time" runat="server" ReadOnly="true"></asp:TextBox>
        &nbsp;
        <asp:ImageButton ID="imgBedate" runat="server" src="../icon/Calendar.png" Height="20" OnClick="imgBedate_Click" />
        <asp:Calendar ID="cledate" runat="server" Visible="false" OnSelectionChanged="cledate_SelectionChanged" Height="70"></asp:Calendar>

    </asp:PlaceHolder>

    <br />
    <asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="搜尋" Visible="false" /><br />
<asp:Label ID="lbMsg" runat="server" Visible="false" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <br />

    

    <asp:Button ID="btn_delete" runat="server" Text="刪除" OnClick="btn_delete_Click" />&nbsp;
        <asp:Button ID="btn_add" runat="server" Text="新增" OnClick="btn_add_Click" /><br />

    <asp:GridView ID="gvSurveyList" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="survey_ID" HeaderText="#" ReadOnly="True" SortExpression="survey_ID" />
            <asp:BoundField DataField="Title" HeaderText="問卷名稱" SortExpression="Title" />
            <asp:BoundField DataField="Condition" HeaderText="狀態" SortExpression="Condition" />
            <asp:BoundField DataField="Stime" HeaderText="開始時間" SortExpression="Stime" />
            <asp:BoundField DataField="Etime" HeaderText="結束時間" SortExpression="Etime" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>

    <uc1:ucPager runat="server" ID="ucPager1" PageSize="10" Url="/Back_end/QuestionnaireList.aspx" Visible="false" />

</asp:Content>
