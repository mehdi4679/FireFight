using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireFight
{
    public class PublicFN
    {
        public static int SendSMSs(string mobile, string msg)
        {

            FireFight.TerraficSms.Send sms = new FireFight.TerraficSms.Send();
            //TerraficPlan.MySMS.Send sms = new TerraficPlan.MySMS.Send();
            long[] rec = null;
            byte[] status = null;
            int retval = sms.SendSms("rshekari", "r24qz137", new string[] { mobile.ToString() }, "1000724137", msg, false, "", ref rec, ref status);
            //retval :

            //    switch (retval){ 
            //        case 1:
            //           ReturnMSG="کلمه عبور نامعتبر.!!";
            //           break;
            //        case 2:
            //           ReturnMSG = "اعتبار موجود نمیباشد";
            //           break;
            //        case 3:
            //           ReturnMSG = "محدودیت روزانه!!";
            //           break;
            //        case 4:
            //           ReturnMSG = "محدودیت ارسال";
            //           break;
            //        case 5:
            //           ReturnMSG = "شماره همراه نامعتبر است!!!";
            //           break;
            //        case 6:
            //           ReturnMSG = "سیستم غیر فعال!!";
            //           break;
            //        case 7:
            //           ReturnMSG = "کلمات نامناسب";
            //        case 8:
            //           ReturnMSG = "Pardis Minimum Receivers";
            //        case 9:
            //           ReturnMSG = "شماره عمومی است!!";
            //           break;

            //}

            return retval;
            //Status :
            // Sent=0,
            // Failed=1


        }
    }
}