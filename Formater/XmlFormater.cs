using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace DataFormater
{
    /// <summary>
    /// 格式化xml输出
    /// </summary>
    public class XmlFormater
    {
        /// <summary>
        /// 格式化xml输出
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static string FormatXml(string xmlString)
        {
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(xmlString);
            StringBuilder sb = new StringBuilder();
            StringWriter writer = new StringWriter(sb);
            XmlTextWriter xmlTxtWriter = null;
            try
            {
                xmlTxtWriter = new XmlTextWriter(writer);
                xmlTxtWriter.Formatting = Formatting.Indented;
                xmlTxtWriter.Indentation = 1;
                xmlTxtWriter.IndentChar = '\t';
                xd.WriteTo(xmlTxtWriter);
            }
            finally
            {
                if (xmlTxtWriter != null)
                    xmlTxtWriter.Close();
            }
            return sb.ToString();
        }
    }
}
