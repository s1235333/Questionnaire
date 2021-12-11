using Questionnaire_ORM.OstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Questionnaire_Methods
{
    public class Methods
    {




        /// <summary>
        /// 取得GV目前頁數
        /// </summary>
        /// <returns></returns>

        public static int GetCurrentPage()
        {
            string pageText = HttpContext.Current.Request.QueryString["Page"];

            if (string.IsNullOrWhiteSpace(pageText))
                return 1;

            int intPage;
            if (!int.TryParse(pageText, out intPage))
                return 1;

            if (intPage <= 0)
                return 1;

            return intPage;
        }



        /// <summary>
        /// 建立問卷DataTable  (一頁十筆)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<SurveyList> GetPageDataTable(List<SurveyList> list)
        {
            int startIndex = (GetCurrentPage() - 1) * 10;
            return list.Skip(startIndex).Take(10).ToList();

        }

        public static List<Surveyreplier> GetPageDataTableSurveyreplier(List<Surveyreplier> list)
        {
            int startIndex = (GetCurrentPage() - 1) * 10;
            return list.Skip(startIndex).Take(10).ToList();

        }

        /// <summary>
        /// 建立問題DataTable  (一頁十筆)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<QuestionList> GetPageDataTableQuestionList(List<QuestionList> list)
        {
            int startIndex = (GetCurrentPage() - 1) * 10;
            return list.Skip(startIndex).Take(10).ToList();

        }





    }
}
