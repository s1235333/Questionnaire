using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using Questionnaire_DBSoure;
using Questionnaire_Models;
using Questionnaire_ORM.OstModels;

namespace Questionnaire_Auth
{
    public class AuthManager
    {
        /// <summary> 檢查目前是否登入 </summary>
        /// <returns></returns>
        public static bool IsLogined()
        {
            if (HttpContext.Current.Session["User"] == null)
                return false;
            else
                return true;
        }

        private static string GetConnectionString()
        {
            string val = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return val;
        }

        public static DataRow GetUserInfoAccount(string account)
        {
            string connectionString = GetConnectionString();
            string dbCommandString =
                $@" SELECT UserID, Account, Password, UserName
                    FROM User
                    WHERE Account = @account
                ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dbCommandString, connection))
                {
                    command.Parameters.AddWithValue("@account", account);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();

                        if (dt.Rows.Count == 0)
                            return null;

                        DataRow dr = dt.Rows[0];
                        return dr;
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(ex);
                        return null;
                    }
                }
            }
        }

    


        /// <summary>
        /// 取得目前使用者資料
        /// </summary>
        /// <returns></returns>
        public static UserModel GetCurrentUser()
        {
            string account = HttpContext.Current.Session["User"] as string;

            if (account == null)
                return null;

            User userlist = UserInfoManager.GetUserInfo(account);

            if (userlist == null)
            {
                HttpContext.Current.Session["User"] = null;
                return null;
            }


            //因為dr設為取得使用者帳號的方法，所以可以取得對應的欄位
            UserModel model = new UserModel();
            model.UserID = userlist.UserID;
            model.UserName = userlist.UserName;
            model.Account = userlist.Account;
            model.Password = userlist.Password;



            return model;

        }





    }
}
