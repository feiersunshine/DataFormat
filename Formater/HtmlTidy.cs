using System.Collections.Generic;
using TidyManaged;

namespace DataFormater
{
    /// <summary>
    /// HtmlTidy HTML格式化为XHTML，修复Dom结构
    /// </summary>
    public class HtmlTidy
    {
        /// <summary>
        /// 整理不规则的HTML片段
        /// </summary>
        /// <param name="htmlOrgStr"></param>
        /// <returns></returns>
        public static string TidyHTML(string htmlOrgStr)
        {
            List<char> chineseCharList = ChineseHelper.GetChineseChar(htmlOrgStr);//处理前提取出中文，处理时中文会乱码
            int count = 0;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (char item in chineseCharList)
            {
                dic.Add("$" + count + "$", item.ToString());
                count++;
            }
            foreach (KeyValuePair<string, string> item in dic)
            {
                htmlOrgStr = htmlOrgStr.Replace(item.Value, item.Key);
            }
            using (Document doc = Document.FromString(htmlOrgStr))
            {
                doc.ShowWarnings = false;
                doc.Quiet = true;
                doc.OutputXhtml = true;
                doc.CleanAndRepair();
                string parsed = doc.Save();
                foreach (KeyValuePair<string, string> item in dic)
                {
                    parsed = parsed.Replace(item.Key, item.Value);//处理完后，将中文替换回来
                }
                htmlOrgStr = parsed;
            }
            return htmlOrgStr;
        }
    }
}
