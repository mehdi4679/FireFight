<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FireFight.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <%--    <br />
   داوطلب گرامی لطفا ضمن مطالعه کامل متن آگهی استخدام,نسبت به خرید کارت شرکت در آزمون از طریق <a href="/Order.aspx">منو مربوطه</a> اقدام نموده و سپس نسبت به آغاز فرآیند ثبت نام اقدام نمایید 
    <br />  --%>
<%--   <div style="margin-top:30px"></div> <i class="ace-icon fa fa-circle green"></i><b>مهلت ثبت نام تا ساعت 24 روز جمعه مورخه 29 اسفند 1393 میباشد.</b>--%>
      
    </br>
    <i class="bigger-110 ace-icon fa fa-angle-down" data-icon-hide="ace-icon fa fa-angle-down" data-icon-show="ace-icon fa fa-angle-right"></i>
    
  <div class="panel-body">
       <a href="/Order.aspx" ><span class="fa fa-credit-card  fa-2x green"></span> خرید کارت ثبت نام آزمون</a>
       <br />
     <a href=""><span class="fa fa-download fa-2x green"></span>دانلود آگهی استخدام</a>

       </div>
<%-- 
										  
        <div><asp:CheckBox runat="server" ID="chAgree" Text="کلیه شرایط مندرج در آگهی استخدام را مطالعه نموده و قبول دارم"/></div>

    <center>
        <div>
        <a runat="server" id="anextstep" onserverclick="anextstep_ServerClick" class="btn btn-primary  " style="width:400px">  مرحله بعد    </a>
        </div>--%>

    </center>
</asp:Content>
