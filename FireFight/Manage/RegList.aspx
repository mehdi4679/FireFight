<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="RegList.aspx.cs" Inherits="FireFight.Manage.RegList" %>
<%@ Register src="../Controls/CtlPersonalAccept.ascx" tagname="CtlPersonalAccept" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder1" runat="server">
        <div >
     <asp:Label ID="LblParamPersonalID"  Visible="false" runat="server" ></asp:Label> 
    <input value="جستجو" type="button" runat="server"  ID="btnSerachLight"  Text="" SkinID="hbtn-search-r" onclick="openlight()"/>&nbsp; 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
    <div style="overflow-x:auto">

    
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
 
<asp:TemplateField HeaderText="ورود">
            <ItemTemplate>
                        <a id="AEdit" class="fa fa-arrow-left green" href='<%#  "/Public/FirstInfo.aspx?PersonalID="+ DataBinder.Eval(Container,"DataItem.PersonalID") +"&AcceptName=" +Eval("AcceptName").ToString()+"&PName="+Eval("FirstName").ToString()+" "+Eval("LastName").ToString() %>' title="ورود و ویرایش"   runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<asp:TemplateField HeaderText="دریافت کارت">
            <ItemTemplate>
                        <a id="AEditeee" class="fa fa-floppy-o green" href='<%#  "/Public/FirstCard.aspx?PersonalID="+ DataBinder.Eval(Container,"DataItem.PersonalID") +"&AcceptName=" +Eval("AcceptName").ToString()+"&PName="+Eval("FirstName").ToString()+" "+Eval("LastName").ToString() %>' title="دریافت کارت اول"   runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
    <asp:TemplateField HeaderText="دریافت کارت دوم">
            <ItemTemplate>
                        <a id="AEditeeee" class="fa fa-floppy-o green" href='<%#  "/Public/SecondCard.aspx?PersonalID="+ DataBinder.Eval(Container,"DataItem.PersonalID") +"&AcceptName=" +Eval("AcceptName").ToString()+"&PName="+Eval("FirstName").ToString()+" "+Eval("LastName").ToString() %>' title="دریافت کارت دوم"   runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
    <asp:TemplateField HeaderText="نمایش اعتراض">
            <ItemTemplate>
                        <a id="Aprotest" class="fa fa-floppy-o green" href='<%#  "/Public/Protest.aspx?PersonalID="+ DataBinder.Eval(Container,"DataItem.PersonalID") +"&AcceptName=" +Eval("AcceptName").ToString()+"&PName="+Eval("FirstName").ToString()+" "+Eval("LastName").ToString() %>' title="نمایش اعتراض"   runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
        <asp:TemplateField HeaderText="کارت ورود به جلسه">
            <ItemTemplate>
                        <a id="Aprotest22" class="fa fa-floppy-o green" href='<%#  "/Public/EnterExamCard.aspx?PersonalID="+ DataBinder.Eval(Container,"DataItem.PersonalID") +"&AcceptName=" +Eval("AcceptName").ToString()+"&PName="+Eval("FirstName").ToString()+" "+Eval("LastName").ToString() %>' title="کارت ورود به جلسه"   runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<asp:TemplateField HeaderText="وضعیت">
            <ItemTemplate>
                        <a style="width:100px" id="AEdittt" class="fa fa-book" href='<%# DataBinder.Eval(Container,"DataItem.PersonalID")%>' title="نظر" onserverclick="AcceptItem" runat="server" ></a>
                <%#Eval("AcceptName") %>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="PersonalID"  HeaderText="ش فرآیند"   SortExpression="PersonalID" />
   <asp:BoundField DataField="PeriodName"  HeaderText="دوره"   SortExpression="PeriodName" />
   <asp:BoundField DataField="PesonalCode"  HeaderText="کد فردی"   SortExpression="PesonalCode" />
     <asp:TemplateField HeaderText="شغل"   SortExpression="JobRequestIDName"><ItemTemplate><a href="#" runat="server" id="jnbm" style="width:200px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a><%#Eval("JobRequestIDName").ToString() %> </ItemTemplate></asp:TemplateField>
   <%--<asp:BoundField DataField="JobRequestIDName" HeaderStyle-Width="200px"  HeaderText="شغل"   SortExpression="JobRequestIDName" />--%>
   <asp:BoundField DataField="NationalCode"  HeaderText="کد ملی"   SortExpression="NationalCode" />
   <asp:BoundField DataField="FirstName"  HeaderText="نام"   SortExpression="FirstName" />
   <asp:BoundField DataField="LastName"  HeaderText="نام خانوادگی"   SortExpression="LastName" />
   <asp:BoundField DataField="FatherName"  HeaderText="نام پدر"   SortExpression="FatherName" />
   <asp:BoundField DataField="BitrhPalceState"  HeaderText="استان  "   SortExpression="BitrhPalceState" />
   <asp:BoundField DataField="BirthPlaceCity"  HeaderText="شهر محل تولد"   SortExpression="BirthPlaceCity" />
   <asp:BoundField DataField="fullBirthDate"  HeaderText="تاریخ تولد"   SortExpression="fullBirthDate" />
  <%--  <asp:BoundField DataField="OwnerAddress"  HeaderText="آدرس"   SortExpression="OwnerAddress" />--%>
   <asp:BoundField DataField="HomePhone"  HeaderText="تلفن"   SortExpression="HomePhone" />
   <asp:BoundField DataField="Mobile"  HeaderText="موبایل"   SortExpression="Mobile" />
   <asp:BoundField DataField="EmergencyMobile"  HeaderText="موبایل اضطراری"   SortExpression="EmergencyMobile" />
   <asp:BoundField DataField="MilitaryStatusIDName"  HeaderText="نظام وظیفه"   SortExpression="MilitaryStatusIDName" />
   <asp:BoundField DataField="DriversLicenseIDName"  HeaderText="گواهینامه رانندگی"   SortExpression="DriversLicenseIDName" />
    <%--asp:BoundField DataField="CurrentJobIDName"  HeaderText="شغل فعلی"   SortExpression="CurrentJobIDName" />--%>
   <asp:BoundField DataField="OfficeJobName"  HeaderText="محل کار"   SortExpression="OfficeJobName" />
  <%-- <asp:BoundField DataField="EmploymentLong"  HeaderText="مدت خدمت"   SortExpression="EmploymentLong" />--%>
   <asp:BoundField DataField="EducationLevelName"  HeaderText="مقطع تحصیلی"   SortExpression="EducationLevelName" />
   <asp:BoundField DataField="EducationName"  HeaderText="رشته تحصیلی"   SortExpression="EducationName" />
   <%--<asp:BoundField DataField="EpeyOrderID"  HeaderText="شماره خرید"   SortExpression="EpeyOrderID" />
   <asp:BoundField DataField="codePosti"  HeaderText="کد پستی"   SortExpression="codePosti" />--%>
   <%--<asp:BoundField DataField="FinalyNativeIDName"  HeaderText="وضعیت بومی"   SortExpression="FinalyNativeIDName" />
   <asp:BoundField DataField="FiNalyNativeCityIDName"  HeaderText="شهر بومی"   SortExpression="FiNalyNativeCityIDName" />--%>
  <%-- <asp:BoundField DataField="FinalySacrificeIDName"  HeaderText="ایثارگری"   SortExpression="FinalySacrificeIDName" />--%>
   
    <asp:TemplateField HeaderText="  اتمام ثبت نام" SortExpression="PrintDate"><ItemTemplate><%#  Eval("PrintDateName").ToString()  %></ItemTemplate></asp:TemplateField>
             </Columns>
</asp:GridView>
       </div>  
<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox"  style="padding:10px;width:100%">
    <table>
        <tr>
            <td>
<table style=" margin-right:50px">
<tr runat="server" id="TrPrimery" ><td>ش فرآیند</td><td><asp:textbox     runat="server" ID="TXTPersonalID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>دوره</td><td><asp:DropDownList runat="server" ID="ddPeriodID" ></asp:DropDownList></td><td></td><td>
</td><td></td></tr><tr><td>کد فردی</td><td><asp:textbox runat="server" ID="TXTPesonalCode" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVPesonalCode" runat="server" 
                  ControlToValidate="txtPesonalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>شغل</td><td><asp:dropdownlist runat="server" ID="DDJobRequestID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>کد ملی</td><td><asp:textbox runat="server" ID="TXTNationalCode" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVNationalCode" runat="server" 
                  ControlToValidate="txtNationalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>نام</td><td><asp:textbox runat="server" ID="TXTFirstName" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVFirstName" runat="server" 
                  ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>نام خانوادگی</td><td><asp:textbox runat="server" ID="TXTLastName" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVLastName" runat="server" 
                  ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>نام پدر</td><td><asp:textbox runat="server" ID="TXTFatherName" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVFatherName" runat="server" 
                  ControlToValidate="txtFatherName" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>استان محل تولد</td><td><asp:dropdownlist runat="server" ID="DDBitrhPalceState" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>  
    </table>
            </td>
            <td>
<table  style="margin-right:50px">
    <tr><td>تلفن</td><td><asp:textbox runat="server" ID="TXTHomePhone" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>موبایل</td><td><asp:textbox runat="server" ID="TXTMobile" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>موبایل اضطراری</td><td><asp:textbox runat="server" ID="TXTEmergencyMobile" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
    <tr><td>نظام وظیفه</td><td><asp:dropdownlist runat="server" ID="DDMilitaryStatusID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>گواهینامه رانندگی</td><td><asp:dropdownlist runat="server" ID="DDDriversLicenseID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr> <tr><td>مقطع تحصیلی</td><td><asp:DropDownList runat="server" ID="ddEducationLevel" ></asp:DropDownList></td><td></td><td>
</td><td></td></tr><tr><td>رشته تحصیلی</td><td><asp:DropDownList runat="server" ID="ddEducationName" ></asp:DropDownList></td><td></td><td>
</td><td></td></tr>   <tr><td>شهر بومی</td><td><asp:DropDownList runat="server" ID="ddFiNalyNativeCityID" ></asp:DropDownList></td><td></td><td>
</td><td></td></tr> <tr><td>  اتمام ثبت نام</td><td><asp:DropDownList runat="server" ID="ddPrintDate" >
    <asp:ListItem Value="-111">بدون انتخاب</asp:ListItem>
    <asp:ListItem Value="1">اتمام</asp:ListItem>
    <asp:ListItem Value="2">نا تمام</asp:ListItem>
    </asp:DropDownList></td><td></td><td>
</td><td></td></tr>
</table>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <table>
        <tr>
            <td>ایثارگری</td>
            <td colspan="10">
                <asp:DropDownList runat="server" ID="ddFinalySacrificeID" ></asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>وضعیت بومی</td>
            <td colspan="10">
                <asp:DropDownList runat="server" ID="ddFinalyNativeID" ></asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>شغل فعلی</td>
            <td colspan="10">
                <asp:dropdownlist runat="server" ID="DDCurrentJobID" ></asp:dropdownlist>
            </td>
        </tr>
                </table>
            </td>
        </tr>

    </table>

    
 
    <br />
              <div  >
               
             <asp:Button runat="server" Width="300px"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r" OnClick="BtnSerach_Click"    />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>

    <div id="LightAccept" class="Lightbox">
         

       <uc1:CtlPersonalAccept ID="CtlPersonalAccept1" runat="server"></uc1:CtlPersonalAccept>
         
<%--<asp:Button runat="server" Text="ذخیره" ID="btnsave" OnClick="btnsave_Click" />--%>
    </div>
    
        </div>
 <input type="hidden"  id="LightBox" runat="server" /> 
 <input type="hidden"  id="LightBox2" runat="server" /> 

<script type="text/javascript">
    
        if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }
     
        if (document.getElementById('<%= LightBox2.ClientID %>').value == "1") {
            setTimeout(f2, 0);
        }   
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function g2() {
        scripthelper.CloseLightBox("lightinsert2");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }    function f2() {
        scripthelper.ShowLightBox("LightAccept", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("LightAccept", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }

    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();

    }
   </script>


</asp:Content>
