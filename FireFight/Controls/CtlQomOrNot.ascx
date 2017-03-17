<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlQomOrNot.ascx.cs" Inherits="FireFight.Controls.CtlQomOrNot" %>
<style>
    .h {
    visibility:hidden;
    }
    .v {
    visibility:inherit;
    }

</style>
<table>
    <tr>

        <td><asp:DropDownList runat="server" ID="ddQomOrNot" CssClass="dqomornot"></asp:DropDownList></td>
        <td class="h tdtdtd" id="tdc" ><asp:TextBox runat="server" ID="txtCity"></asp:TextBox> </td>
    </tr>

   
</table>
<script type="text/javascript">
    $('.dqomornot').on('change', function   () {
        if (this.value == "1")
            $('.tdtdtd').attr("class", "v");
        else
            $('.tdtdtd').attr("class", "v");
    })

</script>