<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="FireFight.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <div>
        <fieldset class="fieldsetP">
            <legend>پرداخت الکترونیک</legend>
            <div><i class="ace-icon fa fa-circle green"></i>تذکر مهم: 
                
                <br />
                لازم است داوطلب کلیه موارد مندرج در آگهی استخدام را به دقت مطالعه نموده و با آگاهی کامل از شرایط, نسبت به پرداخت الکترونیک

                اقدام نماید.خاطر نشان میگردد چنانچه در هر مرحله از ثبت نام و آزمون داوطلب فاقد شرایط لازم تشخیص داده شود

                استرداد وجه پرداختی امکان پذیر نمیباشد.
            </div>
            <table style="margin-right: 50px">
                <tr>
                    <td><span class="clrequir">*</span> کد ملی </td>
                    <td>
                        <asp:TextBox runat="server" ID="TXTNationalCode" data-rel="tooltip" title="فقط عدد و بدون خط تیره"></asp:TextBox></td>
                    <td> &nbsp;</td>
                     
                    <td> <asp:RegularExpressionValidator ID="RVNationalCode" runat="server"
                        ControlToValidate="txtNationalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>

                    </td>
                    <td>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TXTNationalCode"
                        Display="Dynamic" ErrorMessage="کد ملی نامعتبر است" ClientValidationFunction="checkMelliCode"
                        SetFocusOnError="True" ValidateEmptyText="false" ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"
                        Width="128px"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td><span class="clrequir">*</span> نام خانوادگی </td>
                    <td>
                        <asp:TextBox data-rel="tooltip" title="فقط حروف فارسی وارد کنید" runat="server" ID="TXTLastName"></asp:TextBox></td>
                    <td></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RVLastName" runat="server"
                            ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                            ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                            ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RqLastName" runat="server"
                            ControlToValidate="txtLastName" ErrorMessage="لطفا پر کنبد"
                            ValidationGroup="RVTbl_EpayOrder" ForeColor="Red">
                        </asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><span class="clrequir">*</span> نام </td>
                    <td>
                        <asp:TextBox runat="server" ID="TXTFirstName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:TextBox></td>
                    <td></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RVFirstName" runat="server"
                            ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                            ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                            ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RqFirstName" runat="server"
                            ControlToValidate="txtFirstName" ErrorMessage="لطفا پر کنبد"
                            ValidationGroup="RVTbl_EpayOrder" ForeColor="Red">
                        </asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>نام پدر</td>
                    <td>
                        <asp:TextBox runat="server" ID="TXTPhoneNumber"   data-rel="tooltip" title="فقط حروف فارسی"></asp:TextBox></td>
                    <td></td>
                    <td>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="TXTPhoneNumber" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                            ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                            ValidationGroup="RVTbl_EpayOrder" ForeColor="Red"></asp:RegularExpressionValidator>    

                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td><span class="clrequir">*</span> شماره همراه</td>
                    <td>
                        <asp:TextBox runat="server" ID="TXTMobile" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید"></asp:TextBox></td>
                    <td></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ValidationGroup="RVTbl_EpayOrder"
                            ControlToValidate="TXTMobile" Display="Dynamic"
                            ErrorMessage="شماره موبایل را 11 رقمی و صحیح وارد نمایید" ValidationExpression="^\d{11}$">    
                        </asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RqMobile" runat="server"
                            ControlToValidate="txtMobile" ErrorMessage="لطفا پر کنبد"
                            ValidationGroup="RVTbl_EpayOrder" ForeColor="Red">
                        </asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>ایمیل</td>
                    <td>
                        <asp:TextBox data-rel="tooltip" title="ایمیل را دقیق و حروف انگلیسی وارد نمایید" runat="server" ID="TXTEmail"></asp:TextBox></td>
                    <td></td>
                    <td>
                        <asp:RegularExpressionValidator ID="validateEmail" ValidationGroup="RVTbl_EpayOrder"
                            runat="server" ErrorMessage="ایمیل اشتباه است."
                            ControlToValidate="TXTEmail"
                            ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>مبلغ قابل پرداخت</td>
                    <td>
                        <asp:Label runat="server" ID="lblPrice" CssClass="priceclass"></asp:Label></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

            <div style="margin-right: 50px">
            <asp:Button CssClass="btn btn-primary "  Width="330px" runat="server" Text="پرداخت" ID="BtnInsert" SkinID="btnInsert"
                ValidationGroup="RVTbl_EpayOrder" OnClick="BtnInsert_Click" />
                </div>
        </fieldset>


    </div>
    <script>
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


    </script>
</asp:Content>
