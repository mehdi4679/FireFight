<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="SecondCard.aspx.cs" Inherits="FireFight.Public.SecondCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderhead" runat="server">
    <style>
        .PesonalPic {
        position:absolute;
        left:10px;
        top:10px;
        z-index:10;
        border-radius:8px;
        border-style:solid;

        }
        .dprint{
            position:relative;
        }
        .ppiccme {
       width: 200px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;
        
        }
        tr {
        height:0px;
        
        }
        td{
            height:0px;

        }
            .tpasokh {
        padding-left:20px;
        padding-right:20px;
        }
        .tdwidthh {
        width:100px
        
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder1" runat="server">
     <div id="daccept" runat="server" visible="false" ><br /><br /><br /><br /><br /><br /><asp:Label runat="server" ID="lblAccept"></asp:Label><br /><br /><br /><br /><br /><br /></div>
    <br />  
            <a      id="aprint"  onclick="printDiv('dallPrint');">
        <fieldset> 
           چاپ <img src="/App_Themes/Theme1/Images/print.png" style=" margin-top:-40px" >
        </fieldset>
    </a>
      <div id="dallPrint" class="dprint">
        
    <div id="aLLContetctt" runat="server" >
         
    <div>
        <asp:Label runat="server" ID="lblPersonalID" Visible="false" Text="0"></asp:Label>
        <table style="width: 100%; margin: 5px;" >
            <tr>
                <td style="width:150px"><img src="../App_Themes/Theme1/Images/FIRE.png" style="width: 150px;height:150px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;"/></td>
                <td><h1></h1><div align="center">کارت شرکت در آزمون (تجدید شده) عملی مرحله دوم&nbsp; آتش نشانی<br />&quot;ارزیابی آمادگی جسمانی&quot;</div></h1></td>
                <td style="width: 200px">  <img runat="server" style="width: 150px;height:150px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;"  id="img1"  class="ppiccme"   /> </td>
            </tr>

        </table>
    </div>
    <div align="center">
        <table style="border:solid;width:80%;margin:5px">
            <tr>
                <td>نام و نام خانوادگی</td>
                <td><asp:Label runat="server" ID="txtName"></asp:Label></td>
            <td>شماره داوطلبی</td>
                <td><asp:Label runat="server" ID="txtPesonalCode"></asp:Label></td>
            </tr>
            <tr>
                <td>کد ملی:</td>
                <td><asp:Label runat="server" ID="txtNationalCode"></asp:Label></td>
            <td>نام پدر</td>
                <td><asp:Label runat="server" ID="txtFatherName"></asp:Label></td>
            </tr>
        </table>
    </div>
     <div id="dccc" style="">
         <table style="text-align:right;width:95%;border:solid;margin-top:5px" border="1">
             <tr>
                 <td></td>
                 <td style="width:100px">رکورد</td>
                 <td style="width:100px">امتیاز داوطلب</td>
                 <td style="width:150px">نام و نام خانوادگی داور</td>
                 <td style="width:100px">امضا</td>

             </tr>
             
             <tr>
                 <td>1-پرش طول:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>2-دوی 4*9 متر:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>3-دوی 45 متر:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>4-دوی 540 متر:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>5-دراز نشست:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>6-بارفیکس یا کشش از میله:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>7-حمل دو لوله نواری دو و نیم اینچی:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>8-حمل خاموش کننده:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td>9-حمل یک عدد نردبان 3 متری تا شو:</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>

             </tr>
             
             <tr>
                 <td colspan="10">جمع امتیاز کسب شده:</td>
                  

             </tr>
             
         </table>

     &nbsp;&nbsp;&nbsp;

     </div>
        <div id="dNotification" style="width:95%;font-family:Tahoma;font-size:9pt">
            <table>
                <tr><td> <b>توجه:</b></td></tr>
               <tr><td> 1-
                   با در دست داشتن کارت ملی یا شناسنامه وکارت شرکت در آزمون راس ساعت  <asp:Label runat="server" ID="lblExamDate"></asp:Label> با همراه داشتن لباس و کفش 
                   ورزشی مناسب  به سالن ورزشی مرکز مدیریت بحران استان قم واقع در بلوار شهید خدا کرم جنب دانشگاه صنعتی قم مراجعه نمایید
                   </td></tr>
                <tr>
                    <td>
                        2- عدم مراجعه در زمان مقرر به منزله انصراف تلقی خواهد شد..
                         
                    </td>
                </tr>
                <tr><td>3-این کارت با توجه به تصمیم کمیته نظارت بر برگزاری آزمون آتش نشانی و به جهت  شرایط آب و هوایی نامناسب صرفا جهت متقاضیانی که در روز شنبه مورخ 5 اردیبهشت سال 94 در آزمون عملی مرحله دوم شرکت کرده اند صادر گردیده است. </td></tr>
            </table>
        </div>
        <div style="margin:5px">
             آزمون ارزیابی آمادگی جسمانی با حضور اعضای کمیته برگزاری آزمون در   ساعت .....روز..........مورخه .........
            در محل ............. بر اساس مفاد دستور العمل ابلاغی برگزار و نتیجه آن مورد تایید می باشد.
            <br />
            محل امضا اعضا کمیته برگزاری آزمون
            <br />
            <table style="width:100%">
                <tr>
                    <td class="tdwidthh1">1-</td>
                    <td class="tdwidthh1">2-</td>
                    <td class="tdwidthh1">3-</td>
                    <td class="tdwidthh1">4-</td>
                    <td class="tdwidthh1">5-</td>

                </tr>
            </table>
        </div>
        
        <%--<div id="dend" style="position:absolute;bottom:10px;left:10px;width:170px;height:150px;border:solid">
            کارت شرکت در آزمون عملی آزمون آتش نشانی را دریافت کردم
            <br /><br />
            امضا
            
             

        </div>--%>
   
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
