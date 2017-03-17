<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="LoginGetCard.aspx.cs" Inherits="FireFight.LoginGetCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderhead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder1" runat="server">
     <div runat="server" id="dDescc" visible="false">
        متقاضی گرامی لطفا جهت اطلاع از وضعیت ثبت نام و دریافت کارت ورود به آزمون عملی 
شماره داوطلبی و سریال 12 رقمی خود را وارد نمایید
    <br />
                                        <a href="News.aspx">جدول زمانبندی حضور واجدین شرایط آزمون استخدامی در مرحله اول آزمون عملی</a>
    </div>
    <div class="col-sm-10 col-sm-offset-1">
                    <div class="login-container">
                         

                        <div class="space-6"></div>

                        <div class="position-relative">
                            <div id="login-box" class="login-box visible widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header blue lighter bigger">
                                            <i class="ace-icon fa fa-coffee green"></i>
                                             لطفا   شماره داوطلبی و سریال 12 رقمی خرید الکترونیک ثبت نام را جهت دریافت کارت  وارد نمایید
                                        </h4>
                                        
                                        <div  >

                                        
                                        </div>
                                        <div class="space-6"></div>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="text" runat="server" ID="txtUserName" class="form-control" data-rel="tooltip" title="شماره داوطلب" placeholder="شماره داوطلب" />
                                                    <i class="ace-icon fa fa fa-folder-open"></i>
                                                </span>
                                            </label>

                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="text" data-rel="tooltip" title="سریال 12 رقمی خرید"   class="form-control"  ID="txtPass"  runat="server" placeholder="سریال 12 رقمی خرید" />
                                                    <i class="ace-icon fa fa-credit-card"></i>
                                                </span>
                                            </label>

                                            <div class="space"></div>

                                            <div class="clearfix">
                                            <asp:Button runat="server" ID="btnLogin" Text="ورود "  Width="300px"
                                                    class="  pull-right btn btn-sm btn-primary bigger-110 ace-icon fa fa-key" 
                                                    onclick="btnLogin_Click"   />
                           
                                      <asp:Label runat="server" ID="lblmsg" ForeColor="Red" ></asp:Label>
                                               <br />
                                               
                                                    <input type="checkbox" class="ace" />
                                                
                                            </div>

                                            <div class="space-4"></div>
                                        </fieldset>
                                        <div class="space-6"></div>
                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar clearfix">
                                        <div style="width:400px">
                                            <a href="login.html#" data-target="#forgot-box" class="forgot-password-link">
                                                <i class="ace-icon fa fa-arrow-left"></i>
                                                 سریال12رقمی خرید الکترونیک و شماره داوطلبی را فراموش کرده ام
                                            </a>
                                        </div>
                                    </div>
                         <div id="reg">  
                             <a href="/Public/RegPerson.aspx">
                                  

                             </a>

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
                                            فراموش کرده ام
                                        </h4>

                                        <div class="space-6"></div>
                                        <p>
                                            شماره تلفن همراه خود را وارد کنید تا  سریال 12 رقمی خرید الکترونیک و شماره داوطلبی  برایتان ارسال شود
                                        </p>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input  type="text" runat="server" id="txtmobile" CssClass="form-control " placeholder="شماره تلفن همراه" />
                                                    <i class="ace-icon fa fa-mobile large"></i>
                                                </span>
                                            </label>
 
                                            <div class="clearfix">
                                                <asp:Button Text="ارسال  " runat="server" ID="btnSendEmail" CssClass="width-35 pull-right btn btn-sm btn-danger ace-icon fa fa-lightbulb-o" OnClick="btnSendEmail_Click"
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
