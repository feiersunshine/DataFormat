using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace DataFormater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TxtXml.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("XML");
            TxtHTML.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("HTML");
        }

        #region 提示信息
        /// <summary>
        /// 提示成功信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteSucessMsg(string msg)
        {
            MessageBox.Show(msg, "DataFormater 成功提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 提示失败信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteErrMsg(string msg)
        {
            MessageBox.Show(msg, "DataFormater 错误提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMsg(string msg)
        {
            MessageBox.Show(msg, "DataFormater 提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Xml格式化菜单

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XmlContextMenuStrip.SourceControl.Select();//先获取焦点，防止点两下才运行
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Copy(TxtXml, e);

        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XmlContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Paste(TxtXml, e);
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XmlContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Cut(TxtXml, e);

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.XmlContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Delete(TxtXml, e);

        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XmlContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.SelectAll(TxtXml, e);

        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XmlContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.Undo();
        }

        private void 重做ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XmlContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.XmlContextMenuStrip.SourceControl;
            rtb.Redo();
        }

        private void 格式化ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                TxtXml.Text = XmlFormater.FormatXml(TxtXml.Text);
            }
            catch (Exception ex)
            {
                WriteErrMsg(ex.Message);
            }
        }
        #endregion
   
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region HTML格式化菜单 
        private void Html格式化toolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtHTML.Text = HtmlFormater.FormatHtml(TxtHTML.Text,true);
            }
            catch (Exception ex)
            {
                WriteErrMsg(ex.Message);
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();//先获取焦点，防止点两下才运行
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Copy(TxtHTML, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Paste(TxtHTML, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Cut(TxtHTML, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.Delete(TxtHTML, e);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.ActiveTextAreaControl.TextArea.ClipboardHandler.SelectAll(TxtHTML, e);

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.Undo();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.HTMLContextMenuStrip.SourceControl.Select();
            ICSharpCode.TextEditor.TextEditorControl rtb = (TextEditorControl)this.HTMLContextMenuStrip.SourceControl;
            rtb.Redo();
        }
        #endregion


    }
}
