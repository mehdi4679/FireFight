<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="AfterPurches.aspx.cs" Inherits="FireFight.AfterPurches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <asp:Label runat="server" ID="txtResult"></asp:Label>
    <asp:Label runat="server" ID="lblPricde" Visible="false"></asp:Label>
    <br /><br />
     
      <a onclick="printDiv('dContent');" href="#" style="margin:50px">
  
        <fieldset> 
           چاپ <img src="/App_Themes/Theme1/Images/print.png" style=" margin-top:-40px">
              
        </fieldset>
 

    </a>
    <div id="dContent">
        <center>
         <fieldset style="margin-bottom: 30px;">
             <legend>توجه:</legend>
             <ul class="list-unstyled spaced2">
                
                <li>
                <i class="ace-icon fa fa-circle green"></i>
             :داوطلب گرامی  
                    با&nbsp; سریال 12رقمی خرید الکترونیک ذیل, شما میتوانید اقدام به ثبت نام نمایید.جهت ثبت نام <a href="/index.aspx">اینجا</a> کلیک نمایید. 
                </li>

                 </ul>
             
         </fieldset>
            </center>
    <center>
    <fieldset>
         

        <legend >عملیات خرید</legend>
        <table style="margin-top:50px;margin-right:100px">
            <tr>
                <td>
                    <span>سریال 12رقمی خرید الکترونیک</span>:
                </td>
                <td>
 <asp:label runat="server" id="lblRacCode" ></asp:label>
                </td>
            </tr>
             
         
            <tr>
                <td>
                    تاریخ خرید:
                </td>
              <td>  <asp:Label runat="server" ID="lblDateNow"></asp:Label>  </td>

            </tr>
            <tr runat="server" visible="false">
                <td>شماره بانک</td>
                <td><asp:Label runat="server" ID="lblref"></asp:Label></td>
            </tr>
           
        </table>
       
     


    <asp:Label runat="server" ID="lblmsg" ></asp:Label>
        <br />
        <div>
            <asp:Button runat="server" ID="btnReBuy" Text="رفتن به صفحه  شروع ثبت نام" OnClick="btnReBuy_Click" />

        </div>
    </fieldset>
</center>
</div>

    <script language="javascript" type="text/javascript">
        // printDiv('dContent');
        var t = document.getElementById('dContent').innerHTML;
        //var printwindow = window.open('', '', 'fullScreen=no');
        //printwindow.document.write('ggggggggggggggggg');
        //printwindow.onload = printwindow.print;


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

            return false;
        }
    </script>
</asp:Content>
