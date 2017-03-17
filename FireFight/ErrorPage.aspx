<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="FireFight.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <h1><center>
      
         <div style="position:absolute;top:200px;;right:30%">
  <img src="App_Themes/Theme1/Images/delete.png" style="width:300px;height:300px" />
    خطا در سیستم 
        <br />
       <%-- لطفا با مرکز تماس بگیرید--%>
    </div>  
       <div>
           کاربر گرامی در اغلب موارد ایجاد خطا به علت پایان زمان شما میباشد
           <br />
           شما میتوانید با رفتن به صفحه <a href="EditLogin.aspx">شروع</a> و ویرایش اطلاعات دوباره وارد سیستم شود و مراحل ثبت نام خود را به پایان برسانید
           <br />
           در صورت فراموش کردن شماره داوطلبی یا کد سریال خود روی دکمه فراموش کرده ام   کلیک نمایید
       </div>
        </center></h1>
    </form>
</body>
</html>
