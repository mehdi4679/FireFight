using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using FireFightBLL;
using FireFightDAL;
using FireFightCL;
using System.Data;

namespace FireFight.Public
{
    public partial class Print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var r = (HtmlGenericControl)Master.FindControl("contentAfetrSide");
            r.Attributes["class"] = "col-xs-12 col-sm-12  ";
            var t = (HtmlGenericControl)Master.FindControl("dSide");
            t.Visible = false;
            var liActive = (HtmlGenericControl)Master.FindControl("step1");
            liActive.Attributes.Add("class", "complete");
            var liActive2 = (HtmlGenericControl)Master.FindControl("step2");
            liActive2.Attributes.Add("class", "complete");
            var liActive3 = (HtmlGenericControl)Master.FindControl("step3");
            liActive3.Attributes.Add("class", "complete");
            var liActive4 = (HtmlGenericControl)Master.FindControl("step4");
            liActive4.Attributes.Add("class", "complete");
            var liActive5 = (HtmlGenericControl)Master.FindControl("step5");
            liActive5.Attributes.Add("class", "complete");
            var liActive6 = (HtmlGenericControl)Master.FindControl("step6");
            liActive6.Attributes.Add("class", "active");
            var body = (HtmlGenericControl)Master.FindControl("bd1");
            body.Attributes["class"] = "no-skin rtl container ";

            if (Session["IsManage"] == null)
            {
               
                lblPersonalID.Text = Session["PersonalID"].ToString();
            }
            else
                lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();

            if (!Page.IsPostBack)
            {
                
                BindInfo();
                setPrintDate();
            }
        }
        private void BindInfo() {
            ClPersonal cl = new ClPersonal();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
           DataSet ds= PersonalClass.GetListFull(cl);
           if (ds.Tables[0].Rows.Count > 0) {
               DataRow dr = ds.Tables[0].Rows[0];

               TXTBirthPlaceCity.Text = dr["BirthPlaceCity"].ToString();
               txtcodePosti.Text = dr["codePosti"].ToString();
               TXTEmergencyMobile.Text = dr["EmergencyMobile"].ToString();
               TXTEmergencyMobile.Text = dr["EmergencyMobile"].ToString();
              // TXTFatherAddress.Text = dr["FatherAddress"].ToString();
               TXTFatherName.Text = dr["FatherName"].ToString();
               TXTFirstName.Text = dr["FirstName"].ToString();
               TXTHomePhone.Text = dr["HomePhone"].ToString();
               TXTLastName.Text = dr["LastName"].ToString();
               //TXTLocationID.Text = dr["LocationID"].ToString();
               TXTMobile.Text = dr["Mobile"].ToString();
               TXTNationalCode.Text = dr["NationalCode"].ToString();
               TXTOwnerAddress.Text = dr["OwnerAddress"].ToString();
             //  TXTStayLength.Text = dr["StayLength"].ToString();
             //  TXTWifeAddress.Text = dr["WifeAddress"].ToString();
               TXTYearBirthDate.Text = dr["YearBirthDate"].ToString();
               lblPesonalCode.Text = dr["PesonalCode"].ToString();



               DDBitrhPalceState.Text = dr["BitrhPalceStateName"].ToString();
               DDDayBithDate.Text = dr["DayBithDate"].ToString();
               DDDriversLicenseID.Text = dr["DriversLicenseIDName"].ToString();
               DDJobRequestID.Text = dr["JobRequestIDName"].ToString();
               DDMilitaryMonthLong.Text = dr["MilitaryMonthLong"].ToString();
               DDMilitaryStatusID.Text = dr["MilitaryStatusIDName"].ToString();
               DDMilitaryYearLong.Text = dr["MilitaryYearLong"].ToString();
               DDMonthBithDate.Text = dr["MonthBithDateName"].ToString();
               txtEmmloyeYearLong.Text=dr["EmmloyeYearLong"].ToString();
               DDEmploymentLong.Text = dr["EmploymentLong"].ToString();
              
                DDEmploymentLong.Text = dr["EmploymentLongName"].ToString();
               lblOfficeJobName.Text = dr["OfficeJobName"].ToString();
               txtEmmloyeYearLong.Text = dr["EmmloyeYearLong"].ToString();
              
               DDCurrentJobIDName.Text = dr["CurrentJobIDName"].ToString();
               DDEducationLevelName.Text = dr["EducationLevelName"].ToString();


               DDBitrhPalceState.Text = dr["BitrhPalceStateName"].ToString();
              
        

               chIsChildOfShahdari.Checked = Utility.ITB(dr["IsChildOfShahdari"].ToString());
              

               lblEpayTracingCode.Text = dr["EpayTracingCode"].ToString();

               lblFinalyNativeIDName.Text = dr["FinalyNativeIDName"].ToString();
               lblFinalySacrificeID.Text = dr["FinalySacrificeIDName"].ToString();

               if (dr["EducationLevel"].ToString() == "1")
                   lblStudyName.Text = dr["rr"].ToString();
               else
                   lblStudyName.Text = dr["StudyFiedlDNameee"].ToString();
               

               
               //////////////////TraceCode
               //////if (dr["PersonalTracingCode"].ToString().Length < 5) {
               ////// lblTrceCode.Text=   GetUniquCode();
               ////// if (!SavePersonalTraceCode(Convert.ToInt32(lblPersonalID.Text), lblTrceCode.Text))
               //////     Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطلا در نهایی سازی ثبت نام");
              //////}
               //////////////////////////////////////////
               if (dr["JobRequestID"].ToString() == "2")
               {
                   ClPriorityCity clp = new ClPriorityCity();
                   clp.PersonalID = Convert.ToInt32(lblPersonalID.Text);
                   DataSet dsp = PriorityCityClass.GetList(clp);
                   if (dsp.Tables[0].Rows.Count > 0)
                   {
                       DataRow drpriority;
                       for (int i = 0; i < dsp.Tables[0].Rows.Count; i++)
                       {
                           drpriority = dsp.Tables[0].Rows[i];
                            lbljobRequestCity.Text += drpriority["cityname"].ToString() + "   ,  ";
                       }
                   }
                   dsp.Dispose();
               }
               else
               {
                   lbljobRequestCity.Text = "فقط شهر قم";
               }
                
               ds.Dispose();
               ///////////////////////BindImage
               ClAttach clAttach1=new ClAttach();
               clAttach1.PersonalID=Convert.ToInt32(lblPersonalID.Text);
               clAttach1.ForCatalogValue = 1;
               clAttach1.ForCatalogType = 4;
               DataSet dsImage = AttachClass.GetList(clAttach1);
               if (dsImage.Tables[0].Rows.Count > 0)
               {
                   DataRow drimage = dsImage.Tables[0].Rows[0];
                   img1.ImageUrl = "/upload/" + drimage["AttachID"].ToString() + System.IO.Path.GetExtension(drimage["AttachName"].ToString());  
               }
               dsImage.Dispose();



               lblPrintViewDate.Text = DateConvert.m2sh(DateTime.Now.ToString()).ToString() + "  " + DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString();
           }


        }
        public  string cityname(string i) {
            if (i == "1")
                return "قم";
            else
                return "سایر شهرها";
        }

        private bool SavePersonalTraceCode(int PersonalID, string TraceCode) {
            ClPersonal cl = new ClPersonal();
            cl.PersonalID = PersonalID;
            cl.PersonalTracingCode = TraceCode;
            int h = 0;
            h = PersonalClass.Update(cl);
            if (h == 0)
                return false;
            else
                return true;
        }
        private string GetUniquCode()
        {
            string trancadeCode = "";
            int i = 0;

            DataSet ds = new DataSet();
            while (i == 0)
            {
                trancadeCode = FireFightBLL.Utility.RandomDigit(12).ToUpper();
                ClPersonal cl = new ClPersonal();
                cl.PersonalTracingCode = trancadeCode;
                ds = PersonalClass.GetList(cl);
                if (ds.Tables[0].Rows.Count == 0)
                    i = 1;
            }
            ds.Dispose();
            return trancadeCode;
        }

        private void setPrintDate() {
            ClPersonal cl = new ClPersonal();
            cl.PrintDate = DateTime.Now.ToString();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            int t = PersonalClass.Update(cl);
            if (t == 0)
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در ثبت پرینت");

            else
            {
            //    Session.Clear();
              //  FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.General_Success, "داوطلب گرامی مراحل خرید شما تکمیل شد.برای ویرایش اطلاعات با استفاده از شماره داوطلبی و کد رهگیری پرداخت شما میتوانید اقدام به ویرایش اطلاعات خود نمایید");
            }   
        }

       

 
    }
}