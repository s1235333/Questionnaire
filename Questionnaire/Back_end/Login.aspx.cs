using Questionnaire_Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Questionnaire.Back_end
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["User"] != null)
            {
                Response.Redirect("/Login.aspx");
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        protected void btnForget_Click(object sender, EventArgs e)
        {

        }

        protected void btnTraveler_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            string inp_Account = this.txtAccount.Text;
            string inp_PWD = this.txtPassword.Text;

            if (string.IsNullOrWhiteSpace(inp_Account) || string.IsNullOrWhiteSpace(inp_PWD))
            {
                this.ltlMsg.Text = "Account or Password is required.";
                return;
            }

            var dr = AuthManager.GetUserInfoAccount(inp_Account);

            if (dr == null)
            {
                this.ltlMsg.Text = "Account doesn't exists.";
                return;
            }

            if (string.Compare(dr["Account"].ToString(), inp_Account, true) == 0 && string.Compare(dr["Password"].ToString(), inp_PWD, false) == 0)
            {
                this.Session["User"] = dr["Account"].ToString();
                Response.Redirect("/Back_end/QuestionnaireList.aspx");
            }
            else
            {
                this.ltlMsg.Text = "Login fail.";
                return;
            }
        }

        protected void btnForget_Click1(object sender, EventArgs e)
        {

        }

        protected void btnTraveler_Click1(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {

        }
    }
}