using Questionnaire_ORM.OstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_DBSoure
{
    public class UserInfoManager
    {
        /// <summary>
        /// 利用帳號取得使用者資料
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static User GetUserInfo(string account)
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {
                    var query =
                         (from user in context.Users
                          where user.Account == account
                          select user);

                    var useraccount = query.FirstOrDefault();
                    return useraccount;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }
    }
}
