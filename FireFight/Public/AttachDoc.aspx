<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/WizardRMenu.Master" AutoEventWireup="true" CodeBehind="AttachDoc.aspx.cs" Inherits="FireFight.Public.AttachDoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    <style>
        .dOwnertype {
            background-color: red;
        }

        .CarView {
            border-radius: 10px;
            border-style: solid;
            float: right;
            margin: 5px;
            padding: 5px;
            width: 200px;
        }

        .dpic {
            position: relative;
            float: right;
            padding: 5px;
            text-align: center;
        }

        .picc {
            width: 200px;
            height: 200px;
            border-radius: 10px;
        }

        .apic {
            position: absolute;
            top: 0px;
            right: 0px;
        }

        .dselecttype {
            width: 250px;
            float: right;
            background-color: #CDCDCD;
            padding: 5px;
            border-style: solid;
            border-radius: 5px;
            font-family: 'B Mitra',Tahoma;
            margin: 5px;
        }
 </style>       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
     <asp:Label runat="server" ID="lblPersonalID" Text="-65" Visible="false"></asp:Label>
    <div>
       
    </div>
<table>
    <tr>
        <td>نوع مدرک:</td>
        <td><asp:DropDownList runat="server" ID="ddAttachType"></asp:DropDownList></td>
        </tr>
    </table><table>
    <tr>
        <td><asp:FileUpload runat="server" ID="FileUpload1" /></td>
       
        <td><asp:Button runat="server" Text="افزودن پیوست" ID="btnInsert" OnClick="btnInsert_Click" /></td>
    </tr>
</table>
              <div id="dPic">
                <asp:Repeater runat="server" ID="rpPic">
                    <ItemTemplate>
                        <div id="dPicView" class="dpic">
                              <a id="ADel" class="fa fa-times fa-2x apic"  href='<%# DataBinder.Eval(Container,"DataItem.AttachID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="ADel_ServerClick" runat="server"  ></a>
                            <img runat="server" class="picc" id="img" src='<%# "/upload/"+Eval("AttachID")+ System.IO.Path.GetExtension(Eval("AttachName").ToString()) %>' /><br />
                            <asp:Label runat="server" ID="lbltype" Text='<%# Eval("TypeName") %>'></asp:Label><br />
                              <%--<%#  DateConvert.m2sh(Eval("createDate").ToString())%>--%>
                            <%--<asp:Label runat="server" ID="lblAttachID" Visible="false" Text='<%# Eval("AttachID") %>'></asp:Label>--%>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

    <div id="dNext" style="text-align:left;margin-top:350px">
    
            <a  class="btn btn-grey" href="SecondInfo.aspx"><div  class="apre oposityset" ><table><tbody><tr><td><h1>  مرحله قبلی</h1></td><td><img src="/App_Themes/Theme1/Images/pre.png"> </td></tr></tbody></table></div></a>
            <a  class="btn btn-success"  OnServerClick="aanneexxtt_ServerClick" runat="server" id="aanneexxtt"  ><div    class="anext oposityset" ><table><tbody><tr><td><h1>  ثبت و مرحله بعدی</h1></td><td><img style=" " src="/App_Themes/Theme1/Images/next.png"></td></tr></tbody></table> </div></a>
    

</div>
</asp:Content>
