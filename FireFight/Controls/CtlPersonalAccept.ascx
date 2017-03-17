<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPersonalAccept.ascx.cs" Inherits="FireFight.Controls.CtlPersonalAccept" %>
  
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
          <asp:Label runat="server" ID="lblUserReg"  Font-Bold="True" Text="0"  Visible="false" ForeColor="Green"  ></asp:Label> 
<asp:Label runat="server" ID="lblPersonalID"  Font-Bold="True" Text="0"  Visible="false" ForeColor="Green"  ></asp:Label>

<table>
<tr runat="server" id="TrPrimery" visible="false"><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTPersonAcceptID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr runat="server" id="tr1" visible="false"><td>فرد</td><td><asp:dropdownlist runat="server" ID="DDPersonalID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>نظر</td><td><asp:dropdownlist runat="server" ID="DDAcceptID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>توضیحات</td><td><asp:textbox TextMode="MultiLine" runat="server" ID="TXTDescAccept" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr runat="server"  id="tr2" visible="false"><td>تاریخ نظر</td><td><asp:textbox runat="server" ID="TXTAcceptDate" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr runat="server"  id="tr3" visible="false" ><td>کاربر ثبت کننده</td><td><asp:dropdownlist runat="server" ID="DDUserReg" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
    <asp:Button runat="server" Text="ذخیره"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                        ValidationGroup="RVTbl_PersonAccept" />
             
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
             
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.PersonAcceptID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
 
   <asp:BoundField DataField="PersonAcceptID"  HeaderText="ش فرآیند"   SortExpression="PersonAcceptID" />
   <asp:BoundField DataField="PersonalIDName"  HeaderText="فرد"   SortExpression="PersonalIDName" />
   <asp:BoundField DataField="AcceptIDName"  HeaderText="نظر"   SortExpression="AcceptIDName" />
   <asp:BoundField DataField="DescAccept"  HeaderText="توضیحات"   SortExpression="DescAccept" />
   <asp:BoundField DataField="AcceptDateName"  HeaderText="تاریخ نظر"   SortExpression="AcceptDateName" />
   <asp:BoundField DataField="UseridName"  HeaderText="کاربر ثبت کننده"   SortExpression="UseridName" />
             </Columns>
</asp:GridView>
        

      <asp:Label ID="LblParamPersonAcceptID"  Visible="false" runat="server" Text="0"></asp:Label> 

             
          
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
       
 
 

