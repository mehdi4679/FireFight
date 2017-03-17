using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireFightCL;
using FireFightDAL;
using FireFightBLL;
using System.Data.SqlClient;
using System.Data;

namespace FireFight.Public
{
    public partial class FirstCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsManage"] == null)
               lblPersonalID.Text = Session["PersonalID2"].ToString();
            else
                lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();

            if (!Page.IsPostBack) {



                ClPersonal cl = new ClPersonal();
                cl.PersonalID =Convert.ToInt32( lblPersonalID.Text);
                DataSet ds = PersonalClass.GetListAccept(cl);
                DataRow dr = ds.Tables[0].Rows[0];
                txtFatherName.Text = dr["FatherName"].ToString();
                txtName.Text = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                txtNationalCode.Text = dr["NationalCode"].ToString();
                txtPesonalCode.Text = dr["PesonalCode"].ToString();
                HospitalDate.Text = dr["ShiftExam1Name"].ToString();



                if (dr["AcceptIDD"].ToString() == "2")
                {
                    FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "متقاضی گرامی شما به دلیل ذیل واجد شرایط شرکت در آزمون استخدامی نمی باشید ");
                    aLLContetctt.Visible = false;
                    lblAccept.Text = dr["AcceptName"].ToString().Replace("رد ثبت نام", "");
                    daccept.Visible = true;
                    dprint.Visible = false;
                }
                 
                

                ds.Dispose();
                ///////////////////////BindImage
                ClAttach clAttach1 = new ClAttach();
                clAttach1.PersonalID = Convert.ToInt32(lblPersonalID.Text);
                clAttach1.ForCatalogValue = 1;
                clAttach1.ForCatalogType = 4;
                DataSet dsImage = AttachClass.GetList(clAttach1);
                if (dsImage.Tables[0].Rows.Count > 0)
                {
                    DataRow drimage = dsImage.Tables[0].Rows[0];
                    img1.Src = "/upload/" + drimage["AttachID"].ToString() + System.IO.Path.GetExtension(drimage["AttachName"].ToString());
                }
                dsImage.Dispose();
                //////////////////////


                if (Session["PersonalID2"] != null && Request.QueryString["PersonalID"] == null)
                    setPrintDate();

            }
        }

        private void setPrintDate()
        {
            ClPersonal cl = new ClPersonal();
            cl.PrintCradFirst = DateTime.Now.ToString();
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

        private string RetEaxmDate1(int shiftExam1) { 
            string retstr="";
            if (shiftExam1 == 1)
                retstr = "ساعت ";
            else if(shiftExam1==2)
                retstr = "";
            else if(shiftExam1==3)
                retstr = "";
           else if(shiftExam1==4)
                retstr = "";
            else if(shiftExam1==5)
                retstr = "";
            else if(shiftExam1==6)
                retstr = "";
            else
                retstr = "";
        return retstr;
        }


    }
}