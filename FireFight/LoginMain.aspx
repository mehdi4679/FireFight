<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="LoginMain.aspx.cs" Inherits="FireFight.LoginMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
   
     <div class="col-sm-10 col-sm-offset-1  ">
                    <div class="login-container">
                       <%-- <div class="center">
                            <h2>
                                <i class="ace-icon fa  fa-fire red"></i>
                                <span class="red">سامانه استخدامی آتش نشانی  </span>
                            </h2>
                            <h4 class="green" id="id-company-text">استان  قم</h4>
                        </div>--%>

                        <div class="space-12"></div>

                        <div class="position-relative">
                            <div id="login-box" class="login-box visible widget-box no-border" >
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header blue lighter ">
                                            <i class="red"></i>
                                            لطفا سریال 12رقمی خرید الکترونیک  را وارد کنید
                                        </h4>
                                        <div  >

                                         
                                        </div>
                                        <div class="space-6"></div>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="text" runat="server" ID="txtUserName" class="form-control" data-rel="tooltip" title="  سریال 12 رقمی ثبت نام" placeholder="سریال 12 رقمی ثبت نام" />
                                                    <i class="ace-icon fa fa-credit-card"></i>
                                                </span>
                                            </label>

                                            <label class="block clearfix" style="visibility:hidden">
                                                <span class="block input-icon input-icon-right">
                                                    <input  type="password" class="form-control"  ID="txtPass"  runat="server" placeholder="عبارت امنیتی" />
                                                    <i class="ace-icon fa fa-lock"></i>
                                                </span>
                                            </label>

                                            <div class="space"></div>

                                            <div class="clearfix">
                                            <asp:Button runat="server" ID="btnLogin" Text="  ثبت نام  " style="width:300px"
                                                    class="  pull-right btn btn-sm btn-primary bigger-110 ace-icon fa fa-key" 
                                                    onclick="btnLogin_Click"   />
                           
                                      <asp:Label runat="server" ID="lblmsg" ForeColor="Red" ></asp:Label>
                                               <br />
                                               
                                                     
                                                
                                            </div>

                                            <div class="space-4"></div>
                                        </fieldset>
                                        <div class="space-6"></div>
                                    </div>
                                    <!-- /.widget-main -->

                                                                     <div class="toolbar clearfix">
                                        <div style="width:auto">
                                            <a href="login.html#" data-target="#forgot-box" class="forgot-password-link">
                                                <i class="ace-icon fa fa-arrow-left"></i>
                                               سریال 12 رقمی را فراموش کرده ام
                                            </a>
                                        </div>
                                    </div>
                          

                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.login-box -->

                             <div id="forgot-box" class="forgot-box widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header red lighter bigger">
                                            <i class="ace-icon fa fa-key"></i>
                                            باز نشانی سریال 12 رقمی خرید الکترونیک
                                        </h4>

                                        <div class="space-6"></div>
                                        <p>
                                            شماره تلفن همراه خود را وارد کنید تاسریال خربد برایتان ارسال شود
                                        </p>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input  type="text" runat="server" id="txtmobile" CssClass="form-control " placeholder="شماره تلفن همراه" />
                                                    <i class="ace-icon fa fa-mobile large"></i>
                                                </span>
                                            </label>
 
                                            <div class="clearfix">
                                                <asp:Button Text="ارسال سریال" runat="server"    ID="btnSendEmail" CssClass="width-35 pull-right btn btn-sm btn-danger ace-icon fa fa-lightbulb-o" OnClick="btnSendEmail_Click"
                  />
                                            </div>
                                        </fieldset>
                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar center">
                                        <a href="login.html#" data-target="#login-box" class="back-to-login-link">بازگشت به صفحه ورود به سامانه
												<i class="ace-icon fa fa-arrow-right"></i>
                                        </a>
                                    </div>
                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.forgot-box -->
                        </div>
                        <!-- /.position-relative -->
                    </div>
                </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('body').attr('class', 'login-layout light-login');
            $('#id-company-text').attr('class', 'blue');
        });

        jQuery(function ($) {
            $(document).on('click', '.toolbar a[data-target]', function (e) {
                e.preventDefault();
                var target = $(this).data('target');
                $('.widget-box.visible').removeClass('visible'); //hide others
                $(target).addClass('visible'); //show target
            });
        });
    </script>
</asp:Content>
