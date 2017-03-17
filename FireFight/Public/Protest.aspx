<%@ Page Title="" Language="C#" MasterPageFile="~/Manage/ManageMasterPage1.master" AutoEventWireup="true" CodeBehind="Protest.aspx.cs" Inherits="FireFight.Public.Protest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderhead" runat="server">
</asp:Content>
 <asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder1" runat="server">
    <table>
        <tr><td>تاریخ اعتراض</td><td><asp:Label runat="server" ID="lblProtestDate"></asp:Label></td></tr>
        <tr>
            <td>عنوان اعتراض:</td><td><asp:TextBox runat="server" data-rel="tooltip" title="عنوان مناسب برای اعتراض خود را وارد نمایید" ID="txtProtestTitle"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                متن اعتراضیه:
            </td>
            <td>
                <asp:TextBox TextMode="MultiLine" Height="200px" Width="500px" runat="server" ID="txtProtextContent" data-rel="tooltip" title="متن اعتراض خود را با شرح جزییات وارد نمایید"></asp:TextBox>
            </td>
        </tr>

    </table>
    <asp:Button runat="server" ID="btnSave" Text="ثبت اعتراض" OnClick="btnSave_Click" />
    <div runat="server" id="dReplay"  >
        <table>
            <tr><td>تاریخ پاسخ:</td><td><asp:Label runat="server" ID="lblReplayDate"></asp:Label></td></tr>
            <tr>
             <td>جواب اعتراض</td> 
                <td><asp:TextBox runat="server" Width="500px" ID="txtProtestReplay" TextMode="MultiLine" Height="200px" ></asp:TextBox></td>  
            </tr>
        </table>
        <asp:Button runat="server" ID="btnreplay"  Text="پاسخ به اعتراض" OnClick="btnreplay_Click"/>
    </div>


    <asp:Label runat="server" ID="lblPersonalID" Visible="false" Text="0">

    </asp:Label>
</asp:Content>
