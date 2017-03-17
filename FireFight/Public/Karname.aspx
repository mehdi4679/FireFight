<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="Karname.aspx.cs" Inherits="FireFight.Public.Karname" %>
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
                <td><h1></h1><div align="center">کارنامه آزمون آتش نشانی</div></h1></td>
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
                 <td style="width:100px"></td>
                 <td style="width:100px">امتیاز</td>
                 <td style="width:100px">حد نصاب</td>

             </tr>
             
             <tr>
                 <td>1-آزمون عملی:</td>
                 <td><asp:Label runat="server" ID="lblemtiazAmali"></asp:Label></td>
                 <td><asp:Label runat="server" ID="lblHadNesabAmali"></asp:Label></td>

             </tr>
             
             <tr>
                 <td>2-آزمون کتبی:</td>
                 <td><asp:Label runat="server" ID="lblEmtiazKatbi"></asp:Label></td>
                 <td><asp:Label runat="server" ID="LblHadNesabKatbi"></asp:Label></td>

             </tr>
             
             <tr>
                 <td colspan="3">امتیاز نهایی:

  <asp:Label runat="server" id="lblEmtiazFinal"></asp:Label>
                 </td>
               
             </tr>
             
             <tr>
                 <td colspan="3">نتیجه نهایی:

 <asp:Label runat="server" id="lblfinalNatige"></asp:Label>
                 </td>
                

             </tr>
             
             <tr>
                 <td colspan="3">&nbsp;</td>

             </tr>
             
             </table>

     &nbsp;&nbsp;&nbsp;

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
