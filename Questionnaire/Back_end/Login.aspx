﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Questionnaire.Back_end.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>使用者登入</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <script src="../js/bootstrap.js"></script>
    <style>
        body {
            background-color:burlywood;
        }
        .btn-user {
            font-size:16px;
            border-radius:10rem;
            padding:.75rem 1rem;
        }
        .btn-block {
            display:block;
            width:100%;
        }
        .form-control-user{
            font-size:16px;
            border-radius:10rem;
            padding:.75rem 1rem;
        }
        .form-group2{margin-bottom:1rem}
        .form-group3{margin-bottom:.5rem}
    </style>
</head>
<body class="bg-gradient-primary">
    <form id="form1" runat="server">

        <div class="row justify-content-center">
            <div class="col-xl-10 col-lg-12 col-md-9">
                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-login-image">
                                <img src="../icon/QuestionnaireIcon.jpg" style="width:100%; height:auto;"/>
                            </div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">一同享受填問卷的樂趣吧！</h1>
                                    </div>
                                    <div class="form-group2">
                                        <asp:TextBox runat="server" CssClass="form-control form-control-user" ID="txtAccount" placeholder="請輸入帳號"></asp:TextBox>
                                    </div>
                                    <div class="form-group2">
                                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control form-control-user" TextMode="Password" placeholder="請輸入密碼"></asp:TextBox>
                                    </div>
                                    <div class="form-group2">
                                        <asp:Literal Text="" runat="server" ID="ltlMsg" />
                                    </div>
                                    <asp:Button runat="server" ID="btnLogin" Text="登入" OnClick="btnLogin_Click1" CssClass="btn btn-primary btn-user btn-block" />
                                    <hr/>
                                    <asp:Button runat="server" ID="btnForget" Text="忘記密碼" OnClick="btnForget_Click1" CssClass="btn btn-warning btn-user btn-block form-group3" />
                                    <asp:Button runat="server" ID="btnTraveler" Text="填寫問卷 Go!" OnClick="btnTraveler_Click1" CssClass="btn btn-secondary btn-user btn-block form-group3" />
                                    
                                    <div class="text-center">
                                        <!-- Button trigger modal -->
                                        <button type="button" class="btn btn-info btn-user btn-block" data-bs-toggle="modal" data-bs-target="#exampleModal">
                                          註冊
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <table>
            <tr>
                <td colspan ="2" align="center">
                    <!-- Modal -->
                    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                      <div class="modal-dialog">
                        <div class="modal-content">
                          <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">註冊</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                          </div>
                          <div class="modal-body">
                              帳戶：<asp:TextBox runat="server" ID="txtAccCreate"/>
                              <br />
                              密碼：<asp:TextBox runat="server" ID="txtPWCreate" TextMode="Password"/>
                              <br />
                              確認密碼：<asp:TextBox runat="server" ID="txtPWCheck" TextMode="Password"/>
                              <br />
                              稱呼：<asp:TextBox runat="server" ID="txtName"/>
                              <br />
                              信箱：<asp:TextBox runat="server" ID="txtMail" TextMode="Email"/>
                          </div>
                          <div class="modal-footer">
                            <asp:Button Text="確認送出" ID="btnSave" CssClass="btn btn-primary" runat="server" OnClick="btnSave_Click1"/>
                          </div>
                        </div>
                      </div>
                    </div>

                </td>
            </tr>
            
        </table>
    </form>
</body>
</html>
