<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="Print.aspx.cs" Inherits="FireFight.Public.Print" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
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
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:Label runat="server" ID="lblPersonalID" Visible="false" Text="-566"></asp:Label>
    <br /><br />
      <a      id="aprint"  onclick="printDiv('dallPrint');">
        <fieldset> 
           چاپ <img src="/App_Themes/Theme1/Images/print.png" style=" margin-top:-40px" >
        </fieldset>
    </a>

    <div id="dallPrint" class="dprint">
    <div id="dpersonaliPic" style="position: absolute; width: 200px; height: 200px; z-index: 11; left: 0px; top:40px;text-align:center">
         
<asp:Image runat="server" id="img1" CssClass="ppiccme"   />
             <br />    
شماره داوطلب 
       <br />   
        <asp:Label runat="server" ID="lblPesonalCode"></asp:Label> 
             <br />
        کد رهگیری پرداخت  
        <br /><asp:Label runat="server" ID="lblEpayTracingCode" ></asp:Label>
        
       
        
    </div>


   

    
        <table><tr><td>شغل درخواستی:</td><td class="tpasokh"><asp:Label runat="server" ID="DDJobRequestID"></asp:Label></td>
            <td>شهر مورد تقاضا به ترتیب اولویت</td><td><asp:Label runat="server" ID="lbljobRequestCity"></asp:Label></td>
               </tr></table>
     
         <div id="maarefi">
           <div>
            <table>
                <tr>
                    <td>کد ملی</td>
                    <td class="tpasokh"> 
                        <asp:Label runat="server" ID="TXTNationalCode" data-rel="tooltip" title="فقط عدد و بدون خط تیره"></asp:Label></td>

                    <td>
                         </td>
                    <td>

                         
                    </td>
                    <td colspan="10">
                         </td>
                </tr>
            </table>
        </div>
                    
 
     
         
     
        <div>
            
         
        <table>


            <tr>
                <td>    نام </td>
                <td class="tpasokh">
                    <asp:Label runat="server" ID="TXTFirstName"  ></asp:Label>
                
                </td>
                <td>
                    
                </td>
                <td>
                      </td>
                <td>   نام خانوادگی</td>
                <td  class="tpasokh">
                    <asp:Label runat="server" ID="TXTLastName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:Label></td>
                <td>
                   
                </td>
                <td>
                   </td>
                <td>    نام پدر</td>
                <td class="tpasokh">
                    <asp:Label runat="server" ID="TXTFatherName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:Label></td>
                <td>
                     
                </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td>
                       تاریخ تولد
                </td>
                <td class="tpasokh">
                    <table>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="DDDayBithDate" Width=""></asp:Label></td>
                            <td>/</td>
                            <td>
                                <asp:Label Width="50px"  runat ="server" ID="DDMonthBithDate"></asp:Label></td>
                            <td>/</td>
                            <td>
                                <asp:Label runat="server" ID="TXTYearBirthDate" Width="40px"></asp:Label></td>
                        </tr>
                    </table></td>
                <td></td>
                <td></td>
                <td> استان محل تولد</td>
                <td class="tpasokh">
                    <asp:Label runat="server" ID="DDBitrhPalceState" data-rel="tooltip" title="استان محل تولد را انتخاب نمایید"></asp:Label>
                <td></td>
                <td></td>
                <td>  شهر محل تولد
                    </td>

                </td>
                <td class="tpasokh">
                    <asp:Label runat="server" ID="TXTBirthPlaceCity" data-rel="tooltip" title="محل تولد خود را بادقت تایپ نمایید"></asp:Label>
                    </td>
                <td>
                     
                </td>
                <td></td>
            </tr>

            </table>
       
      <table>
            <tr>
                <td>تلفن منزل</td>
                <td class="tpasokh">
                    <asp:Label MaxLength="8" runat="server" ID="TXTHomePhone" data-rel="tooltip" title="فقط عدد وارد کنید"></asp:Label></td>
                <td>
                    
                </td>
                <td></td>
                <td>  تلفن همراه </td>
                <td class="tpasokh">
                    <asp:Label MaxLength="11" runat="server" ID="TXTMobile" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید"></asp:Label></td>
                <td>

                  

                </td>
                <td>
                   

                </td>
                <td>تلفن همراه&nbsp; اضطراری</td>
                <td class="tpasokh">
                    <asp:Label MaxLength="11" runat="server" ID="TXTEmergencyMobile" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید"></asp:Label></td>
                <td>
                    


                </td>
                <td></td>
            </tr>
          </table>
          <table> 
            <tr>
                <td class="auto-style1">وضعیت نظام و ظیفه</td>
                <td class="auto-style1   tpasokh ">
                    <asp:Label runat="server" ID="DDMilitaryStatusID" data-rel="tooltip" title="متقاضیان معافیت پزشکی مجوز ثیت نام در سایت را ندارند"></asp:Label></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1">   </td>
                <td colspan="100" class="auto-style1 tpasokh">
                    <table style="display:none">
                        <tr class="tpasokh">
                            <td>&nbsp;</td>
                            <td>
                                <asp:Label runat="server" ID="DDMilitaryYearLong">
                                   
                                </asp:Label>سال و </td>
                            <td>
                                <asp:Label runat="server" ID="DDMilitaryMonthLong">
                                     
                                </asp:Label></td>
                            <td>ماه</td>
                        </tr>

                    </table>
                </td>
            </tr>
            <tr>
                <td>گواهینامه رانندگی</td>
                <td colspan="10" class="tpasokh">
                    <asp:Label runat="server" ID="DDDriversLicenseID" ></asp:Label></td>
            </tr>
        </table>
 <asp:CheckBox Enabled="false" Text=" فرزند کارکنان از کار افتاده کلی,دائم ,فوت شده و در حین خدمت در شهرداری قم و سازمانهای وابسته به آن" runat="server" ID="chIsChildOfShahdari" />

     
<table style=" ">

            <tr>
                <td class="tdaddress">کد پستی محل سکونت</td>
                <td class="tdaddress">
                    <asp:Label runat="server" ID="txtcodePosti" data-rel="tooltip" title="کد پستی را بدون خط تیره و فقط عدد وارد نمایید"></asp:Label></td>
                </tr><tr>
                <td class="tdaddress">آدرس محل سکونت</td>
                <td>
                    <asp:Label ID="TXTOwnerAddress" runat="server" data-rel="tooltip" title="آدرس را به ترتیب استان.شهر.محله و کاملا دقیق وارد نمایید" TextMode="MultiLine" CssClass="addresscsss"></asp:Label>

                </td>
                <td>&nbsp;</td>
                <td rowspan="3">&nbsp;</td>
            </tr>

            
        </table>
            <br /><br /><br />

            <table>
                <tr>
                    <td>
                        وضعیت ایثارگری:
                    </td>
                    <td class="tpasokh">
                        <asp:Label runat="server" ID="lblFinalySacrificeID" Text="FinalySacrificeIDName"></asp:Label>
                    </td>
                </tr>
            </table>
 
            <table>
                <tr>
                   <td>وضعیت بومی</td>
                    <td class="tpasokh"><asp:Label runat="server" ID="lblFinalyNativeIDName"></asp:Label></td>
                </tr>
            </table>
        
                 
             
         

         </div>
            
        
         
    
    
        <table>
         <tr><td>فعالیت فعلی</td><td class="tpasokh">
             <asp:Label runat="server" ID="DDCurrentJobIDName" CssClass="selecttt"></asp:Label></td>

             </tr>
            </table>

        
              <table><tr><td>سابقه اشتغال  </td><td>
                <asp:Label runat="server" ID="txtEmmloyeYearLong" MaxLength="2" Width="30px"></asp:Label>
            </td>
            <td>سال و</td>
            <td>
                <asp:Label runat="server" ID="DDEmploymentLong">
                     
                </asp:Label>
            </td>
            <td>ماه</td></tr></table>
             <table>
                 <tr>
                     <td>محل خدمت</td>
                     <td><asp:Label runat="server" ID="lblOfficeJobName" ></asp:Label></td>
                 </tr>
             </table>
              
        
         <div>
               
         </div>
       

     
        <table>
            <tr><td>آخرین مقطع تحصیلی</td><td class="tpasokh"><asp:Label runat="server" ID="DDEducationLevelName"   ></asp:Label></td><td>
</td>
                <td> رشته داوطلب</td>
                <td class="tpasokh">
                   <asp:Label runat="server" ID="lblStudyName"  ></asp:Label> 
                   

                </td>
                </tr>
            </table>
            <table>
                <tr><td>تاریخ چاپ اطلاعات</td><td><asp:Label runat="server" ID="lblPrintViewDate"></asp:Label></td></tr>
            </table>
    
         

         

     


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
