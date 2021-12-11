using Questionnaire_Models;
using Questionnaire_ORM.OstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_DBSoure
{
    public class QuestionnaireManager
    {
        /// <summary>
        /// 取得SurveyList DB
        /// </summary>
        /// <returns></returns>
        public static List<SurveyList> GetSurveyList()
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {
                    var query =
                         (from list in context.SurveyLists
                          orderby list.Survey_ID descending
                          select list);

                    var order = query.ToList();
                    return order;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        /// <summary>
        /// 查SurveyList標題
        /// </summary>
        /// <param name="txtsearch"></param>
        /// <returns></returns>
        public static List<SurveyList> GetSurveyListTitle(string txtsearch)
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {
                    var query =
                         (from list in context.SurveyLists
                          where list.Title == txtsearch
                          select list);

                    var search = query.ToList();
                    return search;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }


        //public static List<SurveyList> GetSurveyListDate(DateTime sdate ,DateTime edate)
        //{
            //try
            //{
            //    using (OstContextModel context = new OstContextModel())
            //    {
                                         
            //        //var query =
            //        //     (from list in context.SurveyLists
            //        //      where list.Title == txtsearch
            //        //      select list);

            //        var search = query.ToList();
            //        return search;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(ex);
            //    return null;
            //}
        //}


        /// <summary>
        /// 新增問題QuestionList
        /// </summary>
        /// <param name="questionListModel"></param>
        public static void AddQList(QuestionListModel questionListModel)
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {

                    QuestionList newquestionList = new QuestionList();
                    newquestionList.Question_ID = questionListModel.Question_ID;
                    newquestionList.TypeID = questionListModel.TypeID;
                    newquestionList.Survey_ID = questionListModel.Survey_ID;
                    newquestionList.Question = questionListModel.Question;
                    newquestionList.Options = questionListModel.Options;
                    newquestionList.Must = questionListModel.Must;

                    context.QuestionLists.Add(newquestionList);
                    context.SaveChanges();

                }
            }

            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return;
            }
        }

        /// <summary>
        /// 取得Questionnaire DB
        /// </summary>
        /// <returns></returns>
        public static List<QuestionList> GetQuestionnaireList()
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {
                    var query =
                         (from list in context.QuestionLists
                          orderby list.QuestionSort descending
                          select list);

                    var order = query.ToList();
                    return order;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        /// <summary>
        /// 取得SurveyReplier DB
        /// </summary>
        /// <returns></returns>
        public static List<Surveyreplier> GetSurveyReplier()
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {
                    var query =
                         (from list in context.Surveyrepliers
                          orderby list.Survey_ID descending
                          select list);

                    var order = query.ToList();
                    return order;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }


        /// <summary>
        /// 新增問卷SurveyList
        /// </summary>
        /// <param name="SurveyListModel"></param>
        public static void AddSList(SurveyListModel surveyListModel)
        {
            try
            {
                using (OstContextModel context = new OstContextModel())
                {

                    SurveyList newsurveyList = new SurveyList();

                    newsurveyList.Survey_ID = surveyListModel.Survey_ID;
                    newsurveyList.Condition = surveyListModel.Condition;
                    newsurveyList.Contents = surveyListModel.Contents;
                    newsurveyList.Stime = surveyListModel.Stime;
                    newsurveyList.Etime = surveyListModel.Etime;
                    newsurveyList.OnOff = surveyListModel.OnOff;


                    context.SurveyLists.Add(newsurveyList);
                    context.SaveChanges();

                }
            }

            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return;
            }
        }

    }
}
