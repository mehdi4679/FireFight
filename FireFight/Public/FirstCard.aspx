<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="FirstCard.aspx.cs" Inherits="FireFight.Public.FirstCard" %>
 <asp:Content runat="server" id="mainhead" ContentPlaceHolderID="ContentPlaceHolderhead">
      
<style>
    .dTextbox {
    border:solid;
    padding-right:5px;
    height:25px;
    width:100px;
    }
    .tdwidthh {
    padding-right:100px;
    }
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
    </style>
   </asp:Content>

<asp:Content runat="server" id="maincontanct" ContentPlaceHolderID="MainContentPlaceHolder1">
    

    <div id="daccept" runat="server" visible="false" ><br /><br /><br /><br /><br /><br /><asp:Label runat="server" ID="lblAccept"></asp:Label><br /><br /><br /><br /><br /><br /></div>
    <br /> 
    <div runat="server" id="dprint"> 
            <a      id="aprint"  onclick="printDiv('dallPrint');">
        <fieldset> 
           چاپ <img src="/App_Themes/Theme1/Images/print.png" style=" margin-top:-40px" >
        </fieldset>
    </a>
        </div>
      <div id="dallPrint" class="dprint">
        
    <div id="aLLContetctt" runat="server" >
         
    <div>
        <asp:Label runat="server" ID="lblPersonalID" Visible="false" Text="0"></asp:Label>
        <table style="width: 100%; margin: 5px;" >
            <tr>
                <td style="width:150px"><img src="../App_Themes/Theme1/Images/FIRE.png" style="width: 150px;height:150px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;"/></td>
                <td><h1></h1><div align="center">کارت شرکت در آزمون عملی مرحله اول آتش نشانی<br />&quot;معاینات پزشکی اولیه&quot;</div></h1></td>
                <td style="width: 200px">  <img runat="server" style="width: 150px;height:150px; all: 150px; border-style: solid none solid solid; border-right: 5px none; border-radius: 15px; padding-left: 10px;"  id="img1"  class="ppiccme"   /> </td>
            </tr>

        </table>
    </div>
    <div align="center">
        <table style="border:solid;width:95%;margin:5px;padding:2px;font-size:11pt">
            <tr>
                <td style="width:100px">نام و نام خانوادگی:</td>
                <td style="text-align:right"><asp:Label runat="server" ID="txtName"></asp:Label></td>
            <td style="width:80px">شماره داوطلبی:</td>
                <td style="text-align:right"><asp:Label runat="server" ID="txtPesonalCode"></asp:Label></td>
             
                <td  style="width:40px">کد ملی:</td>
                <td style="text-align:right"><asp:Label runat="server" ID="txtNationalCode"></asp:Label></td>
            <td   style="width:40px">نام پدر:</td>
                <td style="text-align:right"><asp:Label runat="server" ID="txtFatherName"></asp:Label></td>
            </tr>
        </table>
    </div>
    <div id="dcontt" style="border:solid" >
        <div style="background-color:gray;margin:5px;">الف-اندازه گیری و ارزیابی بدنی:</div>
        <div >
            <table>
               <tr>
                   <td>1-قد:</td><td><div class="dTextbox"></div></td><td>سانتی متر </td>
                 </tr>
                <tr>  <td>2-BMI:</td><td><asp:RadioButton runat="server" ID="rdtayyid" Enabled="false" Text="تایید"/></td><td><asp:RadioButton Enabled="false" runat="server" ID="rdRad" Text="رد" /> </td>        </tr>

               <tr>    <td>3-وزن:</td><td><div class="dTextbox"></div></td><td>کیلو گرم  </td></tr>
                <tr>  <td>4-وضعیت اسکلتی-پوسچر-:</td><td  ><asp:RadioButton Enabled="false" runat="server" ID="RadioButton1"  Text="غیر طبیعی"/></td><td class="tdwidthh"><asp:RadioButton runat="server" ID="RadioButton2" Text="طبیعی"  Enabled="false"/> </td>        </tr>
                <tr>  <td>5-دامنه حرکتی مفاصل-:</td><td><asp:RadioButton Enabled="false" runat="server" ID="RadioButton3"  Text="غیر طبیعی"/></td><td class="tdwidthh"><asp:RadioButton runat="server" ID="RadioButton4" Text="طبیعی"  Enabled="false"/> </td>        </tr>
                <tr>  <td>6-نقص عضو-:</td><td><asp:RadioButton runat="server" Enabled="false"  ID="RadioButton52"  Text="دارد" /></td><td class="tdwidthh"><asp:RadioButton runat="server" ID="RadioButton6" Text="ندارد" Enabled="false" /> </td>        </tr>

            </table>
            <table>
               <tr>    <td>7-معاینه بینایی شامل کوررنگی,آستیگماتیک,دید دور(تک چشمی,دو چشمی,اصلاح شده و اصلاح نشده):</td><td><asp:RadioButton runat="server" ID="RadioButton7" Enabled="false"  Text="تایید"/></td><td><asp:RadioButton runat="server" ID="RadioButton8" Text="رد" Enabled="false" /> </td> </tr>
                
            </table>
            <table>
                                <tr>  <td>8-شنوایی :</td><td class="tdwidthh"><asp:RadioButton runat="server" ID="RadioButton9" Enabled="false"  Text="غیر طبیعی"/></td><td class="tdwidthh"><asp:RadioButton runat="server" ID="RadioButton10" Text="طبیعی" Enabled="false" /> </td>        </tr>
                <tr>  <td>9-لکنت زبان-:</td><td class="tdwidthh"><asp:RadioButton runat="server" Enabled="false" ID="RadioButton11"  Text="دارد"/></td><td class="tdwidthh"><asp:RadioButton runat="server" ID="RadioButton12" Text="ندارد" Enabled="false" /> </td>        </tr>

            </table>
        </div> 
         </div>
        <div id="dcontt2" style="border:solid;margin-top:5px">
        <div style="background-color:gray">ب-اندازه گیری و ارزیابی پزشکی:</div>
            <table>
                <tr>
                    <td>10-فشار خون سیستول:</td> 
                    <td>میلی متر جیوه</td>
                    <td><div class="dTextbox" >  </div></td>
                </tr>
                   <tr>
                    <td>11-فشار خون دیاستول:</td>
                    <td>میلی متر جیوه</td>
                    <td><div class="dTextbox" >  </div></td>
                </tr>
                          
                   <tr>
                    <td>12-ضربان نبض استراحت:</td>
                    <td>ضربه/دقیقه</td>
                    <td><div class="dTextbox" > </div></td>
                </tr>
            </table>
        
        </div>
        <div style="margin-top:0px;width:100%;font-family:Tahoma;font-size:9pt">
            <table>
                <tr><td colspan="100">نظریه نهایی:</td></tr>
                 <tr><td>حضور داوطلب درآزمون عملی آتش نشانی </td> 
                     <td ><asp:RadioButton Enabled="false" runat="server" ID="ch1" Text="مورد تایید است" /></td><td style="padding-right: 10px;"><asp:RadioButton Enabled="false" runat="server" ID="CheckBox2" Text="مورد تایید نمی باشد" /></td> 
                 <td class="tdwidthh"   >مهر و امضا پزشک</td></tr>
             </table>
        </div>
        <div id="dNotification" style="margin-top:0px;width:100%;font-family:Tahoma;font-size:9pt">
            <table>
                <tr><td>توجه:</td></tr>
                <tr>
                    <td>
                        <table>
              
                                       <tr><td>1-با در دست داشتن اصل کارت ملی یا شناسنامه و کارت شرکت در آزمون راس  <u><asp:Label runat="server" ID="HospitalDate"></asp:Label></u>  به درمانگاه
                                           سید الشهدا(ع) واقع در قم-&nbsp; خیابان هفتم تیر نبش کوی 16  جهت انجام معاینات پزشکی اولیه مراجعه نمایید.
                                           </td></tr>
                                        <tr>
                                            <td>2- در صورت موفقیت در آزمون عملی مرحله اول (معاینات اولیه پزشکی)حایز شرایط شرکت در آزمون عملی مرحله دوم خواهید شد که 
                                           , بلافاصله بعد از انجام معاینات 
                                                کارت ورود به آن آزمون در محل درمانگاه تحویل متقاضی خواهد شد.
                         بدیهی است عدم مراجعه در زمان مقرر به منزله انصراف تلقی خواهد شد
                                            </td>
                                        </tr>
                                        
                                    </table>
                    </td>
                   
                    <td style="margin-right:2px" >
                        <table style="border:solid"" >
                            <tr>
                                <td> کارت شرکت در آزمون عملی   آتش نشانی را دریافت نمودم</td>
                            </tr>
                            <tr>
                                <td style="margin-right:10px;text-align:center"><br />امضا</td>
                            </tr>
                        </table>
                    </td>
                </tr>

            </table>
            
        </div>
         
   
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
