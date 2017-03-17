using FireFightBLL;
using FireFightCL;
using FireFightDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FireFight.Public
{
    public partial class SecondCard : System.Web.UI.Page
    {
        private void setPrintDate()
        {
            ClPersonal cl = new ClPersonal();
            cl.PrintCardSecond = DateTime.Now.ToString();
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsManage"] == null)
               lblPersonalID.Text = Session["PersonalID2"].ToString();
            else
                lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();

            if (!Page.IsPostBack)
            {



                ClPersonal cl = new ClPersonal();
                cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
                DataSet ds = PersonalClass.GetListAccept(cl);
                DataRow dr = ds.Tables[0].Rows[0];
                txtFatherName.Text = dr["FatherName"].ToString();
                txtName.Text = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                txtNationalCode.Text = dr["NationalCode"].ToString();
                txtPesonalCode.Text = dr["PesonalCode"].ToString();
                lblExamDate.Text = dr["ShiftExam1Name2"].ToString();



                if (dr["AcceptIDD"].ToString() == "2")
                {
                    FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "متقاضی گرامی شما به دلیل ذیل واجد شرایط شرکت در آزمون استخدامی نمی باشید ");
                    aLLContetctt.Visible = false;
                    lblAccept.Text = dr["AcceptName"].ToString();
                    daccept.Visible = true;

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


                 
                    setPrintDate();
            }
        }
    }
}