using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DataFormater
{
    /// <summary>
    /// 中文辅助类
    /// </summary>
    public class ChineseHelper
    { 
        /// <summary>
        /// 取得字符串中的所有中文 
        /// </summary>
        /// <param name="content">原始串</param>
        /// <returns>原始串中的中文集合</returns>
        public static List<char> GetChineseChar(string content)
        {
            List<char> chineseList = new List<char>();
            string regStr = "[\u4e00-\u9fa5]+";
            Regex reg = new Regex(regStr, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            foreach (Match mc in reg.Matches(content))
            {
                char[] chars = mc.Groups[0].Value.ToCharArray();
                chineseList.AddRange(chars);
            }
            return chineseList;
        }
        /// <summary>
        /// 取得字符串中的所有中文 
        /// </summary>
        /// <param name="content">原始串</param>
        /// <returns>原始串中的中文集合</returns>
        public static List<string> GetChineseString(string content)
        {
            List<string> chineseList = new List<string>();
            string regStr = "[\u4e00-\u9fa5]+";
            Regex reg = new Regex(regStr, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            foreach (Match mc in reg.Matches(content))
            {
                chineseList.Add(mc.Groups[0].Value);
            }
            return chineseList;
        }
    }
}
