<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="EpayList.aspx.cs" Inherits="FireFight.Manage.EpayList" %>
<asp:Content runat="server" id="maincontanct" ContentPlaceHolderID="MainContentPlaceHolder1">
    <input type="button" onclick="OpenLight()"   ID="btnSerachLight"  value="جستجو" SkinID="hbtn-search-r"/> 
    <div style="overflow :auto;height:500px;">
    <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting"
               AllowSorting="True" PageSize="5">
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<%--<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.EpayOrderID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.EpayOrderID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
   <asp:BoundField DataField="EpayOrderID"  HeaderText="ش فرآیند"   SortExpression="EpayOrderID" />
    <asp:BoundField DataField="FirstName"  HeaderText="نام"   SortExpression="FirstName" />
   <asp:BoundField DataField="LastName"  HeaderText="نام خانوادگی"   SortExpression="LastName" />
   <asp:BoundField DataField="PhoneNumber"  HeaderText="شماره تلفن"   SortExpression="PhoneNumber" />
   <asp:BoundField DataField="Mobile"  HeaderText="موبایل"   SortExpression="Mobile" />
   <asp:BoundField DataField="Email"  HeaderText="ایمیل"   SortExpression="Email" />
   <asp:BoundField DataField="ISUse"  HeaderText="استفاده شده؟"   SortExpression="ISUse" />
   <asp:BoundField DataField="NationalCode"  HeaderText="کد ملی"   SortExpression="NationalCode" />
     
   <asp:BoundField DataField="IP"  HeaderText="IP"   SortExpression="IP" />
   <asp:BoundField DataField="OS"  HeaderText="OS"   SortExpression="OS" />
   <asp:BoundField DataField="Browser"  HeaderText="Browser"   SortExpression="Browser" />
   <asp:BoundField DataField="OrderDateStart"  HeaderText="زمان شروع"   SortExpression="OrderDateStart" />
   <asp:BoundField DataField="OrderDateEND"  HeaderText="زمان اتمام"   SortExpression="OrderDateEND" />
   <asp:BoundField DataField="OrderStatus"  HeaderText="وضعیت پرداخت"   SortExpression="OrderStatus" />
   <asp:BoundField DataField="RefId"  HeaderText="شماره بانک"   SortExpression="RefId" />
   <asp:BoundField DataField="ResCode"  HeaderText="شماره خرید"   SortExpression="ResCode" />
   <asp:BoundField DataField="Comment"  HeaderText="توضیحات"   SortExpression="Comment" />
   <asp:BoundField DataField="VerifyResult"  HeaderText="مبلغ پرداختی"   SortExpression="VerifyResult" />
           </Columns>
</asp:GridView>
         

</div>

    <div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false"><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTEpayOrderID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>< <tr><td>شماره بانک</td><td><asp:textbox runat="server" ID="TXTRefId" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>شماره خرید</td><td><asp:textbox runat="server" ID="TXTResCode" ></asp:textbox></td><td></td><td>
</td><td></td></tr> <tr><td>نام</td><td><asp:textbox runat="server" ID="TXTFirstName" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نام خانوادگی</td><td><asp:textbox runat="server" ID="TXTLastName" ></asp:textbox></td><td></td><td>
</td><td></td></tr> <tr><td>موبایل</td><td><asp:textbox runat="server" ID="TXTMobile" ></asp:textbox></td><td></td><td>
</td><td></td></tr>  <tr><td>کد ملی</td><td><asp:textbox runat="server" ID="TXTNationalCode" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
               <asp:Button runat="server" OnClick="BtnSerach_Click1" Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"    />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
 <input type="hidden"  id="LightBox" runat="server" /> 
<script type="text/javascript">
       if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }
     
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv")
    }
    function OpenLight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }
   </script>



</asp:Content>