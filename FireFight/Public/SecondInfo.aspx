<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="SecondInfo.aspx.cs" Inherits="FireFight.Public.SecondInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    <style>
        .vv {
        visibility:visible;
        }
        .v {
        visibility:hidden;
        }
        .displaynono {
        display:none;
        
        }
        .displayblockk {
        display:inherit;

        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:Label runat="server" ID="lblPersonalID" Text="-65" Visible="false" ></asp:Label>
    <asp:Label runat="server" ID="lbljobRequest" Text="0" Visible="false"></asp:Label>
    <fieldset class="fieldsetP">
       <legend>شماره  داوطلب</legend>
        <center>
            <h1>
            <table style="margin-top: -40px;"><tr ><td><span class="fa  fa-folder-open"></span>  شماره داوطلبی: </td><td><blink><asp:Label runat="server" ID="lblPesonalCode"></asp:Label></blink></td></tr></table>
                </h1>
         </center>
    </fieldset>
     <fieldset class="fieldsetP">
        <legend>وضعیت شغلی  </legend>
        <table>
         <tr><td><span class="clrequir">*</span> شغل </td><td>
             <asp:dropdownlist runat="server" ID="DDCurrentJobID" CssClass="ddcurrentjob" AutoPostBack="True" OnSelectedIndexChanged="DDCurrentJobID_SelectedIndexChanged"   ></asp:dropdownlist>

                                                          </td>
             <td>
                 <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic" 
    ValidationGroup="RVTbl_Personal" runat="server" ControlToValidate="DDCurrentJobID"
    Text="شغل فعلی را انتخاب نمایید" ErrorMessage="شغل فعلی را انتخاب نمایید"></asp:RequiredFieldValidator>
             </td>
             </tr>
            </table>
         <div id="dcurrentjob">
             <table runat="server" id="tblhowlong">
               <tr>  
<td><span class="clrequir">*</span>
</td><td>
      <table><tr><td>سابقه اشتغال  </td><td>
                <asp:TextBox runat="server" ID="txtEmmloyeYearLong" MaxLength="2" Width="30px"></asp:TextBox>
            </td>
            <td>سال و</td>
            <td>
                <asp:DropDownList runat="server" ID="DDEmploymentLong">
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
                </asp:DropDownList>
            </td>
            <td>ماه</td></tr></table>

     </td> <td>&nbsp;&nbsp;&nbsp;<span class="clrequir">*</span> <asp:Label runat="server" ID="lblshahrdari"></asp:Label> محل خدمت  </td><td>
         <asp:textbox runat="server" ID="TXTOfficeJobName" ></asp:textbox>
         <asp:DropDownList runat="server" ID="ddOfficeJobName"></asp:DropDownList>

                                                                                                                                         </td><td>
</td><td><asp:textbox Visible="false" Text="0" runat="server" ID="TXTBimeLong" ></asp:textbox></td>  
    
        </tr>
            </table>

              
         </div>
         <div>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                  ControlToValidate="txtEmmloyeYearLong" Display="Dynamic" ErrorMessage="سال اشتغال را فقط   رقم وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
         </div>
         </fieldset>

    <fieldset class="fieldsetP"><legend>وضعیت تحصیلی</legend>
        <table>
            <tr><td><span class="clrequir">*</span> آخرین مقطع تحصیلی </td><td><asp:dropdownlist runat="server" ID="DDEducationLevel" CssClass="classddlevel" AutoPostBack="True" OnSelectedIndexChanged="DDEducationLevel_SelectedIndexChanged"   ></asp:dropdownlist></td>
                <td>
                    <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator111" Display="Dynamic" 
    ValidationGroup="RVTbl_Personal" runat="server" ControlToValidate="DDEducationLevel"
    Text="مقطع تحصیلی  را انتخاب نمایید" ErrorMessage="مقطع تحصیلی را انتخاب نمایید"></asp:RequiredFieldValidator>
</td>
                <td><span class="clrequir">*</span> رشته  تحصیلی  </td>
                <td> 
                 <div   id="sdid" >  <asp:DropDownList runat="server" ID="ddStudyFiedlD"  ></asp:DropDownList></div>
                   <div   id="sdname"  > <asp:TextBox runat="server" ID="txtStudyFieldName"   ></asp:TextBox></div>

                </td>
                </tr>
            </table><table>
            <tr runat="server" visible="false">
                <td colspan="2">سال اخذ مدرک</td>  <td><asp:textbox runat="server" ID="TXTEducationYear" MaxLength="4" ></asp:textbox></td><td>      
                               <asp:RegularExpressionValidator ID="RVEducationYear" runat="server" 
                  ControlToValidate="txtEducationYear" Display="Dynamic" ErrorMessage="فقط چهار رقم وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td>
    <td>نام آموزشگاه</td><td><asp:textbox runat="server" ID="TXTEducationName" ></asp:textbox></td><td>
</td><td></td> <td> محل تحصیل</td><td> <table><tr><td >استان</td><td><asp:dropdownlist runat="server" ID="DDEducationLocationOstan" ></asp:dropdownlist></td><td >شهر</td><td><asp:textbox runat="server" ID="TXTEducationCityName" ></asp:textbox></td></tr></table>  </td><td>
</td><td></td></tr>
            </table>
    </fieldset>

    <fieldset>
            <legend>وضعیت بومی بودن</legend>
       <br />
          <div>
 داوطلبان بومی می توانند جهت استفاده از امتیاز مربوطه یکی از گزینه های زیر را انتخاب نمایند
          </div>
            <table style=" margin-bottom:90px;margin-right:20px">
                <tr>
                    <td><span class="clrequir">*</span>
            <asp:DropDownList runat="server" ID="ddFinalyNativeID" AutoPostBack="True" OnSelectedIndexChanged="ddFinalyNativeID_SelectedIndexChanged"></asp:DropDownList>

                    </td>
                    <td runat="server" id="tdtwon">در شهر </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddFiNalyNativeCityID" ></asp:DropDownList>
                    </td>
                </tr>
            </table>
         

    </fieldset>
<%--<div>
    <div>داوطلب گرامی جهت تعیین وضعیت بومی بودن یکی از گزینه های زیر را انتخاب نمایید</div>
    <table>
        
        <tr>
           
            <td><asp:RadioButton Text="شهر محل صدور شناسنامه داوطلب" GroupName="yy" runat="server" id="Native_SodorSH"></asp:RadioButton> </td>
            </tr>
        <tr>
           
            <td><asp:RadioButton Text="شهر محل صدور  شناسنامه همسر داوطلب" GroupName="yy" runat="server" id="Native_Wife"></asp:RadioButton></td>
            </tr>
        <tr>
            
            <td><asp:RadioButton Text="شهر محل پرداخت حق  بیمه همسر یا پدر و مادر یا داوطلب  با سابقه حداقل 4 سال" GroupName="yy" runat="server" id="Native_WifeBime"></asp:RadioButton></td>

        </tr>
         <tr>
              
             <td><asp:RadioButton Text="تحصیلات در قم حداقل چهار سال در مقاطع ابتدایی,راهنمایی,دبیرستان و دانشگاه به صورت متناوب یا متوالی" GroupName="yy" runat="server" ID="Native_ShoolOne" /> </td>
         </tr>
        <tr>
             <td><asp:RadioButton Text="محل خدمت فعلی همسر یا فرزندان کارمندان رسمی و پیمانی دولت یا نیروهای مسلح و بازنشستگان قم"  GroupName="yy" runat="server" ID="Native_Parent" /> </td>
        </tr>
    </table>
</div>--%>
           
    <div id="dNext" style="text-align:left">
    
            <a class="btn btn-grey" href="/public/FirstInfo.aspx"><div  class="apre oposityset" ><table><tbody><tr><td><h1>  مرحله قبلی</h1></td><td><img src="/App_Themes/Theme1/Images/pre.png"> </td></tr></tbody></table></div></a>
            <a  class="btn btn-success" OnServerClick="aanneexxtt_ServerClick" runat="server" id="aanneexxtt"  ><div    class="anext oposityset" ><table><tbody><tr><td><h1>  ثبت و مرحله بعدی</h1></td><td><img style=" " src="/App_Themes/Theme1/Images/next.png"></td></tr></tbody></table> </div></a>
    

</div>
    <script type="text/javascript">
        ////////////$(document).ready(function () {
        ////////////    $('.ddcurrentjob').on('change', function () {
        ////////////        if (this.value == "1" || this.value == "0" )
        ////////////            $('#dcurrentjob').hide(500);
        ////////////        else
        ////////////            $('#dcurrentjob').show(500);
        ////////////    })
        ////////////   // $('#dcurrentjob').show(500);
        ////////////    $(document).ready(function () {
        ////////////        if ($('.ddcurrentjob').val == "1" || $('.ddcurrentjob').val == "0")
        ////////////            $('#dcurrentjob').hide(500);
        ////////////        else
        ////////////            $('#dcurrentjob').show(500);
        ////////////    });
            //////////////////////////////////////////////////////////////level Field

           
            //////////////$('.classddlevel').on('change', function () {
            //////////////    if (this.value == "1") {
            //////////////        $('#sdid').hide(500);
            //////////////        $('#sdname').show(500);
            //////////////    }
            //////////////    else {
            //////////////        $('#sdid').show(500);
            //////////////        $('#sdname').hide(500);
            //////////////    }
            //////////////});

            //////////////$(document).ready(function () {
            //////////////    if ($('.classddlevel').val == "1")//if deyplom
            //////////////    {
            //////////////        $('#sdid').hide(500);
            //////////////        $('#sdname').show(500);
            //////////////    }
            //////////////    else {
            //////////////        $('#sdid').show(500);
            //////////////        $('#sdname').hide(500);
            //////////////        //css({ "display": "inherit" });//show
            //////////////    }

            //////////////});


            //////////////});

 
       // $('#sdname').show(500);


    </script>
</asp:Content>
