<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="EnterExamCard.aspx.cs" Inherits="FireFight.Public.EnterExamCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderhead" runat="server">
    <style>
        .textright {
        text-align:right;
        
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder1" runat="server">
       <div runat="server" id="dprint"> 
            <a      id="aprint"  onclick="printDiv('dallPrint');">
        <fieldset> 
           چاپ <img src="/App_Themes/Theme1/Images/print.png" style=" margin-top:-40px" >
        </fieldset>
    </a>
        </div>
    <div id="dallPrint" class="dprint">
            <div runat="server" id="aLLContetctt">
        <asp:Label runat="server" ID="lblPersonalID" Visible="false" Text="0"></asp:Label>
                <div><h1></h1></div>
        <table style="width: 100%; margin: 5px;" >
            <tr>
                <td style="width:150px"><img src="../App_Themes/Theme1/Images/arm2.png" style="width: 150px;height:150px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;"/></td>
                <td style="text-align:center "><h1>شهرداری قم</h1><div align="center">کارت ورود به جلسه آزمون تخصصی<br />استخدامی آتش نشانی (کتبی) <br />شهرداریهای استان قم</div></h1></td>
                <td style="width: 200px">  <img runat="server" style="width: 150px;height:150px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;"  id="img1"  class="ppiccme"   /> </td>
            </tr>

        </table>
<table>
    <tr>
        <td>شماره صندلی:</td>
        <td><asp:Label runat="server" ID="lblChairNumber"></asp:Label></td>

        <td>کد داوطلبی:</td>
        <td><asp:Label runat="server" ID="LblPersonalCode"></asp:Label></td>

    </tr>
    <tr>
        <td>نام:</td>
        <td class="textright"><asp:Label runat="server" ID="lblName"></asp:Label></td>
        <td>نام خانوادگی:</td>
        <td><asp:Label runat="server" ID="lbLastName"></asp:Label></td>
    </tr>
    <tr>
        <td>کد ملی:</td>
        <td><asp:Label runat="server" ID="LblMelliCode"></asp:Label></td>
        <td>شغل انتخابی:</td>
        <td><asp:Label runat="server" ID="lblJobRequest"></asp:Label></td>
    </tr>
    <tr>
        <td>تاریخ برگزاری آزمون:</td>
        <td>1394/03/08</td>
        <td>ساعت برگزاری آزمون:</td>
        <td>8 صبح</td>
    </tr>
    <tr><td colspan="3">محل برگزاری آزمون:قم-بلوار کارگر ساختمان شهید باکری مرکز علمی کاربردی شهرداری قم</td>
     <td>محل انگشت</td></tr>
</table>
<table>
    <tr><td>تذکرات مهم:</td></tr>
    <tr><td>1. همراه داشتن کارت شرکت در آزمون بانضمام اصل کارت ملی و یا شناسنامه برای ورود به جلسه آزمون الزامی می باشد.
</td></tr>
    <tr><td>2.همراه داشتن هرگونه وسیله ارتباط الکترونیکی از قبیل تلفن همراه و غیره در جلسه آزمون ممنوع می باشد.
</td></tr>
    <tr><td>3. حضور داوطلب نیم ساعت قبل از شروع جلسه آزمون در محل برگزاری آزمون الزامی است.
</td></tr>
    <tr><td>4. همراه داشتن مداد سیاه، پاکن و مداد تراش (جهت پاسخگویی به سوالات) و همچنین خودکار آبی الزامی می باشد</td></tr>
</table>

    </div>
        </div>
    <script language="javascript" type="text/javascript">
        var t = document.getElementById('dallPrint').innerHTML;


        function printDiv(divID) {
            //Get the HTML of div
            var divElements = document.getElementById(divID).innerHTML;
            //Get the HTML of whole page
            var oldPage = document.body.innerHTML;

            //Reset the page's HTML with div's HTML only
            document.body.innerHTML =
              "<html><head><title></title></head><body>" +
              divElements + "</body>";

            //Print Page
            window.print();

            //Restore orignal HTML
            document.body.innerHTML = oldPage;

            return true;
        }
    </script>
</asp:Content>
