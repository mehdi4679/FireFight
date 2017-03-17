<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="FirstInfo.aspx.cs" Inherits="FireFight.Public.FirstInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    <style>
        textarea {
            width: 80%;
            height: 50px;
        }

        .tdaddress {
            width: 170px;
        }
        .tprio {
        width:450px;height:150px;padding-right:20px;display:none        
        }
        .TXTOwnerAddress {
            
            width:auto;
                height:70px;
                
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:Label runat="server" ID="lblPersonalID" Visible="false" Text="-88"></asp:Label>
     <fieldset class="fieldsetP">
       <legend>شماره  داوطلب</legend>
        <center>
            <h1>
            <table style="margin-top: -40px;"><tr ><td><span class="fa  fa-folder-open"></span>  شماره داوطلبی: </td><td><blink><asp:Label runat="server" ID="lblPesonalCode"></asp:Label></blink></td></tr></table>
                </h1>
         </center>
    </fieldset>
    <fieldset class="fieldsetP">
        <legend>شغل و شهر مورد تقاضای داوطلب</legend>
        <center>   
            <table>
                <tr>
                    <td>شغل درخواستی:</td>
                    <td> <span class="clrequir">*</span>
                        <asp:DropDownList CssClass="selecttt" runat="server" ID="DDJobRequestID" data-rel="tooltip" title="توجه:برای تصدی شغل راننده وسائل سنگین داشتن گواهینامه پایه یک الزامی است"> 
                        </asp:DropDownList>
                    </td>
                   <td>
                       <asp:RequiredFieldValidator InitialValue="0" ID="RequiredJobRequestID" Display="Dynamic" 
    ValidationGroup="RVTbl_Personal" runat="server" ControlToValidate="DDJobRequestID"
    Text="انتخاب شغل درخواستی الزامی است" ErrorMessage="انتخاب شغل درخواستی الزامی است "></asp:RequiredFieldValidator>
                   </td>
                    <td>
                        <div id="dcj2" class="tprio">
                            <table>
                                <tr><td>شهر درخواستی</td><td>اولویت اول</td><td><asp:DropDownList Width="150px" runat="server" AutoPostBack="true"  ID="ddCity1" OnSelectedIndexChanged="ddCity1_SelectedIndexChanged"></asp:DropDownList></td></tr>
                                <tr><td>شهر درخواستی</td><td>اولویت دوم</td><td><asp:DropDownList  Width="150px" runat="server" ID="ddCity2" AutoPostBack="True" OnSelectedIndexChanged="ddCity2_SelectedIndexChanged"></asp:DropDownList></td></tr>
                                <tr>  <td>شهر درخواستی</td><td>اولویت سوم</td> <td><asp:DropDownList  Width="150px" runat="server" ID="ddCity3"  ></asp:DropDownList></td></tr>
                                
                            </table>

                        </div>
                        <div id="dcj" class="tprio" style="height:30px"> شهر درخواستی:<u>فقط قم</u>  </div>
                    </td>
                </tr>

            </table>

        </center>
    </fieldset>
    <fieldset class="fieldsetP">
        <legend>مشخصات فردی</legend>
        <div>
            <table>
                <tr>
                    <td>کد ملی</td>
                    <td><span class="clrequir">*</span>
                        <asp:TextBox runat="server" ID="TXTNationalCode" data-rel="tooltip" title="فقط عدد و بدون خط تیره"></asp:TextBox></td>

                    <td>
                        <asp:RegularExpressionValidator ID="RVNationalCode" runat="server"
                            ControlToValidate="txtNationalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                            ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                            ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator></td>
                    <td>

                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TXTNationalCode"
                            Display="Dynamic" ErrorMessage="کد ملی نامعتبر است" ClientValidationFunction="checkMelliCode"
                            SetFocusOnError="True" ValidateEmptyText="false" ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"
                            Width="128px"></asp:CustomValidator>
                    </td>
                    <td colspan="10">
                        <asp:RequiredFieldValidator ID="RqNationalCode" runat="server"
                            ControlToValidate="txtNationalCode" ErrorMessage="الزامی"
                            ValidationGroup="RVTbl_Personal" ForeColor="Red">
                        </asp:RequiredFieldValidator></td>
                </tr>
            </table>
        </div>
        <table>


            <tr>
                <td><span class="clrequir">*</span>   نام </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTFirstName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RVFirstName" runat="server"
                        ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="فقط حروف فارسی"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                    
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqFirstName" runat="server"
                        ControlToValidate="txtFirstName" ErrorMessage="الزامی"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator></td>
                <td><span class="clrequir">*</span>  نام خانوادگی</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTLastName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RVLastName" runat="server"
                        ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="فقط حروف فارسی"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqLastName" runat="server"
                        ControlToValidate="txtLastName" ErrorMessage="الزامی"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator></td>
                <td><span class="clrequir">*</span>  نام پدر</td>
                <td>
                    <asp:TextBox runat="server" ID="TXTFatherName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RVFatherName" runat="server"
                        ControlToValidate="txtFatherName" Display="Dynamic" ErrorMessage="فقط حروف فارسی "
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RqFatherName" runat="server"
                        ControlToValidate="txtFatherName" ErrorMessage="الزامی"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <span class="clrequir">*</span>  تاریخ تولد
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:DropDownList runat="server" ID="DDDayBithDate" Width=""></asp:DropDownList></td>
                            <td>/</td>
                            <td>
                                <asp:DropDownList runat="server" ID="DDMonthBithDate"></asp:DropDownList></td>
                            <td>/</td>
                            <td>
                                <asp:TextBox runat="server" ID="TXTYearBirthDate" Width="40px" MaxLength="4" placeholder="1300" data-rel="tooltip" title="چهار رقمی و بیشتر از 1300"></asp:TextBox></td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator44" runat="server"
                        ControlToValidate="TXTYearBirthDate" ErrorMessage="الزامی"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator> 
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator322" runat="server"
                        ControlToValidate="TXTYearBirthDate" Display="Dynamic" ErrorMessage="سال را 4 رقمی وارد نمایید "
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                                 
                            </td>
                        </tr>
                    </table></td>
                <td></td>
                <td></td>
                <td><span class="clrequir">*</span> استان محل تولد</td>
                <td>
                    <asp:DropDownList runat="server" ID="DDBitrhPalceState" data-rel="tooltip" title="استان محل تولد را انتخاب نمایید"></asp:DropDownList>
                <td>

                    <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic" 
    ValidationGroup="RVTbl_Personal" runat="server" ControlToValidate="DDBitrhPalceState"
    Text="استان محل تولد را انتخاب نمایید" ErrorMessage="استان محل تولد را انتخاب نمایید"></asp:RequiredFieldValidator>

</td>
                <td></td>
                <td><%--مدت اقامت به سال--%><span class="clrequir">*</span> شهر محل تولد
                    </td>

                </td>
                <td>
                    <asp:TextBox runat="server" ID="TXTBirthPlaceCity" data-rel="tooltip" title="محل تولد خود را بادقت تایپ نمایید"></asp:TextBox>
                    </td>
                <td>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="TXTBirthPlaceCity" ErrorMessage="الزامی"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator> 
                </td>
                <td></td>
            </tr>

            </table>
        <br />
      <table>
            <tr>
  
                 
                <td><span class="clrequir">*</span> تلفن همراه </td>
                <td>
                    <asp:TextBox MaxLength="11" runat="server" ID="TXTMobile" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید" placeholder="09xxxxxxxxx"></asp:TextBox></td>
                <td>

                     <asp:RegularExpressionValidator ID="TXTMobilesdfsvf" runat="server"
                        ControlToValidate="TXTMobile" Display="Dynamic" ErrorMessage="شماره موبایل را 11 رقمی و صحیح وارد نمایید "
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>

                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtMobile" ErrorMessage="الزامی"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </td>
                <td>تلفن همراه&nbsp; اضطراری</td>
                <td>
                    <asp:TextBox MaxLength="11" runat="server" ID="TXTEmergencyMobile" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید"></asp:TextBox></td>
                <td>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                        ControlToValidate="TXTEmergencyMobile" Display="Dynamic" ErrorMessage="شماره موبایل را 11 رقمی و صحیح وارد نمایید "
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                     


                </td>
                <td></td>
            </tr>
          </table><table>
            <tr>
                <td class="auto-style1"><span class="clrequir">*</span> وضعیت نظام و ظیفه</td>
                <td class="auto-style1">
                    <asp:DropDownList runat="server" ID="DDMilitaryStatusID" data-rel="tooltip" title="متقاضیان معافیت پزشکی مجوز ثیت نام در سایت را ندارند"></asp:DropDownList></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID" Display="Dynamic" 
    ValidationGroup="RVTbl_Personal" runat="server" ControlToValidate="DDMilitaryStatusID"
    Text="وضعیت نظام وظیفه را انتخاب نمایید" ErrorMessage="وضعیت نظام وظیفه را انتخاب نمایید"></asp:RequiredFieldValidator>

                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1">   </td>
                <td colspan="100" class="auto-style1">
                    <table style="visibility:hidden">
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:DropDownList runat="server" ID="DDMilitaryYearLong">
                                    <asp:ListItem>0</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                </asp:DropDownList>سال و </td>
                            <td>
                                <asp:DropDownList runat="server" ID="DDMilitaryMonthLong">
                                    <asp:ListItem>0</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                </asp:DropDownList></td>
                            <td>ماه</td>
                        </tr>

                    </table>
                </td>
            </tr>
              </table><table>
            <tr>
                <td><span class="clrequir">*</span> گواهینامه رانندگی</td>
                <td colspan="10">
                    <asp:DropDownList runat="server" ID="DDDriversLicenseID" ></asp:DropDownList></td>
                <td>
                    <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID2" Display="Dynamic" 
    ValidationGroup="RVTbl_Personal" runat="server" ControlToValidate="DDDriversLicenseID"
    Text="گواهینامه رانندگی را انتخاب نمایید" ErrorMessage="گواهینامه رانندگی را انتخاب نمایید"></asp:RequiredFieldValidator>
                </td>
            </tr>
         
        </table>
        <div>
                          <asp:CheckBox Text=" فرزند کارکنان از کار افتاده کلی دائم یا فوت شده << حین خدمت>> در واحدها یا سازمانهای وابسته به شهرداریهای متقاضی استخدام  " runat="server" ID="chIsChildOfShahdari" />

        </div>
<table style="width: 100%">

            <tr>
      <td class=" "><span class="clrequir">*</span> آدرس محل سکونت </td>
                <td  >
                    <asp:TextBox ID="TXTOwnerAddress" runat="server" data-rel="tooltip" title="آدرس را به ترتیب استان.شهر.محله و کاملا دقیق وارد نمایید" TextMode="MultiLine" CssClass="TXTOwnerAddress"></asp:TextBox>

                </td>
                              <td><span class="clrequir">*</span>  تلفن محل سکونت</td>
                <td>
                    <%--<div class="input-group" dir="ltr">
																<span class="input-group-addon">
																	<i class="ace-icon fa fa-phone"></i>
																</span>--%>
                    <table>
                        <tr>
                            <td>
                                <input runat="server" ID="TXTHomePhone"  data-rel="tooltip" title="شماره تلفن ثابت" class="eee" type="text" maxlength="7" style="width:80px"  >
                            </td>
                            <td>
                                <input runat="server" ID="TXTHomePhonePre"   data-rel="tooltip" title="پیش شماره" placeholder="0xx" class="eee" type="text" style="width:30px;margin-right:4px"  maxlength="3" >
                            </td>
                        </tr>
                    </table>
																
															<%--</div>--%>
                   <%-- <asp:TextBox MaxLength="8"  ></asp:TextBox></td>--%>
                <td>
                   <%-- <asp:RegularExpressionValidator ID="RVHomePhone" runat="server"
                        ControlToValidate="txtHomePhone" Display="Dynamic" ErrorMessage="فقط عدد "
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>--%>
                </td>
                <td class=" "> کد پستی محل سکونت </td>
                <td class=" ">
                    <asp:TextBox runat="server" CssClass="ADDRSSCSS"  ID="txtcodePosti" data-rel="tooltip" title="کد پستی را بدون خط تیره و فقط عدد وارد نمایید"></asp:TextBox></td>
          
            </tr>

            
            <tr>
      <td class=" ">&nbsp;</td>
                <td  >
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                        ControlToValidate="TXTOwnerAddress" ErrorMessage="آدرس الزامی است"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator></td>
                              <td>&nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                        ControlToValidate="TXTHomePhone" ErrorMessage="تلفن محل سکونت الزامی است"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </td>
                <td>
                    &nbsp;</td>
                <td class=" "> &nbsp;</td>
                <td class=" ">
                    &nbsp;</td>
          
            </tr>

            
        </table>
    </fieldset>

        <fieldset class="fieldsetP"><legend>وضعیت ایثارگری</legend>
 
            <asp:RadioButtonList runat="server" ID="rdsa"></asp:RadioButtonList>
         

    </fieldset>
        
  

    <div id="dNext" style="text-align: left">

        <%--            <a href="RequestNosazi.aspx"><div  class="apre oposityset" ><table><tbody><tr><td><h1>  مرحله قبلی</h1></td><td><img src="/asset/images/pre.png"> </td></tr></tbody></table></div></a>--%>
        <a class="btn btn-success" onserverclick="aanneexxtt_ServerClick" validationgroup="RVTbl_Personal" runat="server" id="aanneexxtt">
            <div>
                <table>
                    <tbody>
                        <tr>
                            <td>
                                <h1>ثبت و مرحله بعدی</h1>
                            </td>
                            <td>
                                <img style="" src="/App_Themes/Theme1/Images/next.png"></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </a>


    </div>
    <script type="text/javascript">
        

        function checkMelliCode(val, args) {
            var meli_code;
            meli_code = args.Value;
            if (meli_code.length == 10) {
                if ((meli_code == '0000000000') || (meli_code == '1111111111') || (meli_code == '2222222222') || (meli_code == '3333333333') || (meli_code == '4444444444') || (meli_code == '5555555555') || (meli_code == '6666666666') || (meli_code == '7777777777') || (meli_code == '8888888888') || meli_code == ('9999999999')) {
                    alert("کد ملي صحيح نمي باشد");
                    args.IsValid = false;
                    return false;
                }
                c = parseInt(meli_code.charAt(9));
                n = (parseInt(meli_code.charAt(0)) * 10) + (parseInt(meli_code.charAt(1)) * 9) + (parseInt(meli_code.charAt(2)) * 8) + (parseInt(meli_code.charAt(3)) * 7) + (parseInt(meli_code.charAt(4)) * 6) + (parseInt(meli_code.charAt(5)) * 5) + (parseInt(meli_code.charAt(6)) * 4) + (parseInt(meli_code.charAt(7)) * 3) + (parseInt(meli_code.charAt(8)) * 2);
                r = n - parseInt(n / 11) * 11;
                if ((r == 0 && r == c) || (r == 1 && c == 1) || (r > 1 && c == 11 - r)) {
                    args.IsValid = true;
                }
                else {
                    alert("کد ملي صحيح نمي باشد");
                    args.IsValid = false;
                }
            }
            else {
                alert("کد ملي صحيح نمي باشد");
                args.IsValid = false;
                return false;
            }
        }

       
        $('.selecttt').on('change', function   () {
            //$('#dcj').fadeOut(500);
            //$('#dcj').fadein(500);
                 //   $('#dcj').html('داشتن حداکثر بیست و پنج سال تمام سن متولدین تاریخ 19 اسفند 1368 به بعد الزامی است.به استثنا خانواده ایثارگران محترم');
         
            if (this.value == "1")
            {
                $('#dcj').fadeIn();
                $('#dcj2').fadeOut();
            }
            else if (this.value == "2")
            {
                $('#dcj2').fadeIn();
                $('#dcj').fadeOut();               
            }
            else
                {
                $('#dcj2').fadeOut();
                $('#dcj').fadeOut();
                }
        })
        $( document ).ready(function(){
            if ($('.selecttt').val() == "1")
            {
                $('#dcj').fadeIn();
                $('#dcj2').fadeOut();
            }
            else if ($('.selecttt').val() == "2") {
                $('#dcj2').fadeIn();
                $('#dcj').fadeOut();
            }
            else {
                $('#dcj2').fadeOut();
                $('#dcj').fadeOut();
            }

        });


      //  $.mask.definitions['~'] = '[+-]';
      //  $('.input-mask-phone').mask('(099) 99999999');
    </script>
</asp:Content>
