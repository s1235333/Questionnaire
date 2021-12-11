using Questionnaire_DBSoure;
using Questionnaire_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Questionnaire.Back_end
{
    public partial class QuestionnaireList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var list = QuestionnaireManager.GetSurveyList();

                if (list.Count > 0) //check is empty data (大於0就做資料繫結)
                {

                    var orderlist = Methods.GetPageDataTable(list);

                    this.ucPager1.Totaluser = list.Count;
                    this.ucPager1.BindUserList();


                    this.gvSurveyList.DataSource = orderlist;
                    this.gvSurveyList.DataBind();


                }
                else
                {
                    this.gvSurveyList.Visible = false;
                    this.ucPager1.Visible = false;

                }
            }
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            var txtsearch = this.title.Text;
            DateTime sdate = this.clsdate.SelectedDate;
            DateTime edate = this.clsdate.SelectedDate;

            if (sdate <= edate)
            {
                this.txtbgn_time.Text = null;
                this.txtend_time.Text = null;
                this.lbMsg.Text = "開始日期必須大於結束日期";
            }

            if (rdTitle.Checked)
            {
                if (txtsearch != null)
                {
                    string search = QuestionnaireManager.GetSurveyListTitle(txtsearch).ToString();

                    if (search != null)
                    {
                        var list = QuestionnaireManager.GetSurveyListTitle(txtsearch);

                        if (list.Count > 0) //check is empty data (大於0就做資料繫結)
                        {

                            var orderlist = Methods.GetPageDataTable(list);

                            this.ucPager1.Totaluser = list.Count;
                            this.ucPager1.BindUserList();


                            this.gvSurveyList.DataSource = orderlist;
                            this.gvSurveyList.DataBind();


                        }
                        else
                        {
                            this.gvSurveyList.Visible = false;
                            this.ucPager1.Visible = false;

                        }
                    }

                }

                else
                {
                    this.lbMsg.Text = "尚未輸入查詢標題";
                }

            }

            if (rdDate.Checked)
            {

                {
                    var list = QuestionnaireManager.GetSurveyList();

                    if (list.Count > 0) //check is empty data (大於0就做資料繫結)
                    {

                        var orderlist = Methods.GetPageDataTable(list);

                        this.ucPager1.Totaluser = list.Count;
                        this.ucPager1.BindUserList();


                        this.gvSurveyList.DataSource = orderlist;
                        this.gvSurveyList.DataBind();


                    }
                    else
                    {
                        this.gvSurveyList.Visible = false;
                        this.ucPager1.Visible = false;

                    }
                }
            }











        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuestionnaireManage.aspx");
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
            this.txtbgn_time.Text = this.clsdate.SelectedDate.ToString("yyyy-MM-dd");
        }


        protected void cledate_SelectionChanged(object sender, EventArgs e)
        {
            this.cledate.Visible = false;
            this.txtend_time.Text = this.cledate.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void rdDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDate.Checked)
            {
                this.rdTitle.Checked = false;
                this.plTitle.Visible = false;
                this.plDate.Visible = true;
                this.btn_search.Visible = true;
            }
        }

        protected void rdTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTitle.Checked)
            {
                this.rdDate.Checked = false;
                this.plDate.Visible = false;
                this.plTitle.Visible = true;
                this.btn_search.Visible = true;
            }
        }

     
    }
}