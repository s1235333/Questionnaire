using Questionnaire_DBSoure;
using Questionnaire_Methods;
using Questionnaire_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Questionnaire.Back_end
{
    public partial class Trytab : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Session["addquestion"] = null;
            this.lbMsg.Visible = false;

            var Qlist = QuestionnaireManager.GetQuestionnaireList();

            if (Qlist.Count > 0) //check is empty data (大於0就做資料繫結)
            {

                var questionlist = Methods.GetPageDataTableQuestionList(Qlist);

                this.ucPagerQ.Totaluser = Qlist.Count;
                this.ucPagerQ.Visible = true;
                this.ucPagerQ.BindUserList();


                this.GVquestion.DataSource = Qlist;
                this.GVquestion.DataBind();


            }
            else
            {
                this.GVquestion.Visible = false;
                this.ucPagerQ.Visible = false;

            }

            var Rlist = QuestionnaireManager.GetSurveyReplier();

            if (Rlist.Count > 0) //check is empty data (大於0就做資料繫結)
            {

                var replierlist = Methods.GetPageDataTableSurveyreplier(Rlist);

                this.ucPagerUserInfo.Totaluser = Rlist.Count;
                this.ucPagerUserInfo.Visible = true;

                this.ucPagerUserInfo.BindUserList();


                this.GVreplier.DataSource = replierlist;
                this.GVreplier.DataBind();


            }
            else
            {
                this.GVreplier.Visible = false;
                this.ucPagerUserInfo.Visible = false;

            }


        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Add_btn_Click(object sender, EventArgs e)
        {

            var ddType = this.DDqtype.SelectedValue;
            if (ddType == "0")
            {
                this.lbMsg.Visible = true;
                this.lbMsg.Text = "請先選擇問題種類";
            }

            //常用問題1
            if (ddType == "2")
            {

            }
            //常用問題2
            if (ddType == "3")
            {

            }


            if (this.Session["addquestion"] == null)
            {
                this.Session["addquestion"] = new List<QuestionListModel>();
            }



            if (ddType == "1")
            {

                var txtq = this.txt_question.Text;
                var ddoption = this.DDoption.SelectedValue;
                var txtanswer = this.txt_answer.Text;

                int must;
                if (this.CBmust.Checked)
                {
                    must = 0;
                }
                else
                {
                    must = 1;
                }

                var questionList = new QuestionListModel()
                {
                    Question_ID = Guid.NewGuid(),
                    TypeID = Convert.ToInt32(ddoption),
                    Survey_ID = 1, //需取得 
                    Question = txtq,
                    Options = txtanswer,
                    Must = must,
                };

                var sessionQlist = this.Session["addquestion"] as List<QuestionListModel>;
                sessionQlist.Add(questionList);

            }








        }




        protected void imgBsdate_Click(object sender, ImageClickEventArgs e)
        {
            this.clsdate.Visible = true;
        }

        protected void imgBedate_Click(object sender, ImageClickEventArgs e)
        {
            this.cledate.Visible = true;
        }

        protected void clsdate_SelectionChanged(object sender, EventArgs e)
        {
            this.clsdate.Visible = false;
            this.txt_stime.Text = this.clsdate.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void cledate_SelectionChanged(object sender, EventArgs e)
        {
            this.cledate.Visible = false;
            this.txt_etime.Text = this.cledate.SelectedDate.ToString("yyyy-MM-dd");
        }




        protected void Cancel_btn2_Click(object sender, EventArgs e)
        {
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("資料尚未儲存，取消請按確定", "取消",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Warning);

            if (MsgBoxResult == DialogResult.OK)
            {
                Session.Remove("addquestion");
                DialogResult MsgBoxResult2;
                MsgBoxResult2 = MessageBox.Show("取消成功", "取消",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
            }

            else
            {
                return;
            }


        }

        protected void Finish_btn_Click(object sender, EventArgs e)
        {
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("即將送出問題，請按確定繼續", "確認",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Information);

            if (MsgBoxResult == DialogResult.OK)
            {
                var addQloist = this.Session["addquestion"] as List<QuestionListModel>;
                foreach (var sub in addQloist)
                {
                    QuestionnaireManager.AddQList(sub);
                }


                Session.Remove("addquestion");
            }

            else
            {
                return;
            }
        }

        protected void Nextstep_btn1_Click(object sender, EventArgs e)
        {

            if (this.Session["addsurvey"] == null)
            {
                this.Session["addsurvey"] = new List<SurveyListModel>();
            }

            var txtn = this.txt_Name.Text;
            var txtc = this.txt_content.Text;
            string txtst = this.txt_stime.Text;
            var txtet = this.txt_etime.Text;

            string OnOff;
            if (this.CBOnOff.Checked)
            {
                OnOff = "開放";
            }
            else
            {
                OnOff = "已關閉";
            }

            var surveyList = new SurveyListModel()
            {
                Survey_ID = 1,
                Title = txtn,
                Contents = txtc,
                Condition = OnOff,
                Stime = this.clsdate.SelectedDate,
                Etime = this.cledate.SelectedDate,
                OnOff = OnOff,
            };

            var sessionsurveylist = this.Session["addsurvey"] as List<SurveyListModel>;
            sessionsurveylist.Add(surveyList);

        }

        protected void GVquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}