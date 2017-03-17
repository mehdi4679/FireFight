<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlEpayOrder.ascx.cs" Inherits="FireFight.Controls.CtlEpayOrder" %>
    <div >
     <asp:Label ID="LblParamEpayOrderID"  Visible="false" runat="server" Text="0"></asp:Label> 
     </div >
    
  
         

 <div>
<table>
 <tr><td>نام</td><td><asp:textbox runat="server" ID="TXTFirstName" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVFirstName" runat="server" 
                  ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید" 
                  ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="RqFirstName" runat="server" 
                  ControlToValidate="txtFirstName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_EpayOrder" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>نام خانوادگی</td><td><asp:textbox runat="server" ID="TXTLastName" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVLastName" runat="server" 
                  ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید" 
                  ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="RqLastName" runat="server" 
                  ControlToValidate="txtLastName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_EpayOrder" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>تلفن</td><td><asp:textbox runat="server" ID="TXTPhoneNumber" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVPhoneNumber" runat="server" 
                  ControlToValidate="txtPhoneNumber" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>موبایل</td><td><asp:textbox runat="server" ID="TXTMobile" ></asp:textbox></td><td></td><td>  
    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"    ValidationGroup="RVTbl_Personal" 
                     ControlToValidate="TXTMobile" Display="Dynamic"  
                     ErrorMessage="شماره موبایل را 11 رقمی و صحیح وارد نمایید" ValidationExpression="^\d{11}$">    
                </asp:RegularExpressionValidator>               
</td><td>                 <asp:RequiredFieldValidator ID="RqMobile" runat="server" 
                  ControlToValidate="txtMobile" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_EpayOrder" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>ایمیل</td><td><asp:textbox runat="server" ID="TXTEmail" ></asp:textbox></td><td></td><td>
<asp:RegularExpressionValidator ID="validateEmail"    ValidationGroup="RVTbl_Personal"
  runat="server" ErrorMessage="ایمیل اشتباه است."
  ControlToValidate="TXTEmail" 
  ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />

                                                                                                                                                     </td><td></td></tr>
    <tr><td>مبلغ قایل پرداخت</td><td><asp:Label runat="server" ID="lblPrice" CssClass="priceFormat"></asp:Label></td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
</table>
             
              <asp:Button runat="server" Text="ثبتــ"  ID="BtnInsert" SkinID="btnInsert" 
                        ValidationGroup="RVTbl_EpayOrder"  OnClick="BtnInsert_Click" />
            
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
         
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        
 
 

