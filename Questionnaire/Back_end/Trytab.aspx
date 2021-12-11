<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trytab.aspx.cs" Inherits="Questionnaire.Back_end.Trytab" %>
<%@ Register Src="~/Back_end/UserControl/ucPager.ascx" TagPrefix="uc1" TagName="ucPager" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
        <script>
        $(function () {
            $("#datepicker").datepicker();
            $("#datepicker2").datepicker();

        });
    </script>
    <form id="form1" runat="server">

        <nav>
            <div class="nav nav-tabs" id="nav-tab" role="tablist">
                <button class="nav-link active" id="nav-home-tab" data-bs-toggle="tab" data-bs-target="#nav-home" type="button" role="tab" aria-controls="nav-home" aria-selected="true">問卷</button>
                <button class="nav-link" id="nav-profile-tab" data-bs-toggle="tab" data-bs-target="#nav-profile" type="button" role="tab" aria-controls="nav-profile" aria-selected="false">問題</button>
                <button class="nav-link" id="nav-contact-tab" data-bs-toggle="tab" data-bs-target="#nav-contact" type="button" role="tab" aria-controls="nav-contact" aria-selected="false">填寫資料</button>
            </div>
        </nav>
        <div class="tab-content" id="nav-tabContent">
            <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab">
                問卷名稱:
                            <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox><br />
                <br />
                描述內容:
                            <asp:TextBox ID="txt_content" runat="server" Height="52px" Width="282px"></asp:TextBox><br />
                <br />
                開始時間:
                            <asp:TextBox ID="txt_stime" runat="server" ReadOnly="false"></asp:TextBox>
                <asp:ImageButton ID="imgBsdate" runat="server" src="../icon/Calendar.png" Height="20" OnClick="imgBsdate_Click" />
                <asp:Calendar ID="clsdate" runat="server" Visible="False" OnSelectionChanged="clsdate_SelectionChanged" Height="190px" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
                <br />
                <br />
                結束時間:
                            <asp:TextBox ID="txt_etime" runat="server"></asp:TextBox>
                <asp:ImageButton ID="imgBedate" runat="server" src="../icon/Calendar.png" Height="20" OnClick="imgBedate_Click" />
                <asp:Calendar ID="cledate" runat="server" Visible="False" OnSelectionChanged="cledate_SelectionChanged" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
                <br />
                <br />
                <asp:CheckBox ID="CBOnOff" runat="server" AutoPostBack="true" />
                已啟用&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="Cancel_btn1" runat="server" Text="取消" />&nbsp;&nbsp;
      <asp:Button ID="Nextstep_btn1" runat="server" Text="下一步" OnClick="Nextstep_btn1_Click" />

            </div>
            <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab">
                種類: 
                            <asp:DropDownList ID="DDqtype" runat="server" AutoPostBack="false">
                                <asp:ListItem Value="0">請選擇</asp:ListItem>
                                <asp:ListItem Value="1">自訂問題</asp:ListItem>
                                <asp:ListItem Value="2">常用問題1</asp:ListItem>
                                <asp:ListItem Value="3">常用問題2</asp:ListItem>
                            </asp:DropDownList>

                            <br />
                            問題:
                            <asp:TextBox ID="txt_question" runat="server"></asp:TextBox>&nbsp; 
            <asp:DropDownList ID="DDoption" runat="server">
                <asp:ListItem Value="0">提問方式</asp:ListItem>
                <asp:ListItem Value="1">單選方塊</asp:ListItem>
                <asp:ListItem Value="2">多選方塊</asp:ListItem>
                <asp:ListItem Value="3">問答</asp:ListItem>
            </asp:DropDownList>
                            &nbsp; 
          <asp:CheckBox ID="CBmust" runat="server" AutoPostBack="true" />
                            必填
                            <br />
                            加入選項:
                            <asp:TextBox ID="txt_answer" runat="server"></asp:TextBox>(各選項以逗號(,)隔開)&nbsp;&nbsp; 
      <asp:Button ID="Add_btn" runat="server" Text="加入" OnClick="Add_btn_Click" />
                            <br />
                    <asp:Label ID="lbMsg" runat="server" Visible="false"  ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="GVquestion" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" AutoGenerateColumns="False" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="GVquestion_SelectedIndexChanged">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField HeaderText="*" DataField="QuestionSort" SortExpression="QuestionSort" />
                                    <asp:BoundField DataField="Question" HeaderText="問題" SortExpression="Question" />
                                    <asp:BoundField DataField="TypeID" HeaderText="種類" SortExpression="TypeID" />
                                    <asp:BoundField DataField="Must" HeaderText="必填" SortExpression="Must" />
                                    <asp:CommandField DeleteText="" ShowEditButton="True" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <uc1:ucPager runat="server" ID="ucPagerQ" PageSize="10" Url="/Back_end/QuestionnaireManage.aspx" Visible="false" />


                            <asp:Button ID="Cancel_btn2" runat="server" Text="取消" OnClick="Cancel_btn2_Click" />
                            <asp:Button ID="Finish_btn" runat="server" Text="送出" OnClick="Finish_btn_Click" />

                            <br />
            </div>
            <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab">
                  <asp:GridView ID="GVreplier" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4"  ForeColor="Black" GridLines="Horizontal">
                                <Columns>
                                    <asp:BoundField DataField="Name" HeaderText="姓名" SortExpression="Name" />
                                    <asp:BoundField DataField="InputTime" HeaderText="填寫時間" SortExpression="InputTime" />
                                    <asp:ButtonField HeaderText="觀看細節" Text="前往" />
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
                            <uc1:ucPager runat="server" ID="ucPagerUserInfo" PageSize="10" Url="/Back_end/QuestionnaireManage.aspx" Visible="false" />

            </div>
        </div>
    </form>
</body>
</html>
