namespace DataFormater
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabXml = new System.Windows.Forms.TabPage();
            this.TxtXml = new ICSharpCode.TextEditor.TextEditorControl();
            this.XmlContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.格式化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabJson = new System.Windows.Forms.TabPage();
            this.TabHtml = new System.Windows.Forms.TabPage();
            this.TxtHTML = new ICSharpCode.TextEditor.TextEditorControl();
            this.HTMLContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Html格式化toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.JsonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Json格式化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Json重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonViewer1 = new EPocalipse.Json.Viewer.JsonViewer();
            this.tabControl1.SuspendLayout();
            this.TabXml.SuspendLayout();
            this.XmlContextMenuStrip.SuspendLayout();
            this.TabJson.SuspendLayout();
            this.TabHtml.SuspendLayout();
            this.HTMLContextMenuStrip.SuspendLayout();
            this.JsonContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabXml);
            this.tabControl1.Controls.Add(this.TabJson);
            this.tabControl1.Controls.Add(this.TabHtml);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // TabXml
            // 
            this.TabXml.Controls.Add(this.TxtXml);
            this.TabXml.Location = new System.Drawing.Point(4, 22);
            this.TabXml.Name = "TabXml";
            this.TabXml.Padding = new System.Windows.Forms.Padding(3);
            this.TabXml.Size = new System.Drawing.Size(689, 413);
            this.TabXml.TabIndex = 0;
            this.TabXml.Text = "XML";
            this.TabXml.UseVisualStyleBackColor = true;
            // 
            // TxtXml
            // 
            this.TxtXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtXml.ContextMenuStrip = this.XmlContextMenuStrip;
            this.TxtXml.Encoding = ((System.Text.Encoding)(resources.GetObject("TxtXml.Encoding")));
            this.TxtXml.IsIconBarVisible = false;
            this.TxtXml.Location = new System.Drawing.Point(6, 6);
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.ShowEOLMarkers = true;
            this.TxtXml.ShowInvalidLines = false;
            this.TxtXml.ShowSpaces = true;
            this.TxtXml.ShowTabs = true;
            this.TxtXml.ShowVRuler = true;
            this.TxtXml.Size = new System.Drawing.Size(680, 401);
            this.TxtXml.TabIndex = 53;
            // 
            // XmlContextMenuStrip
            // 
            this.XmlContextMenuStrip.AllowDrop = true;
            this.XmlContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.格式化ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.重做ToolStripMenuItem});
            this.XmlContextMenuStrip.Name = "contextMenuStrip1";
            this.XmlContextMenuStrip.Size = new System.Drawing.Size(111, 180);
            // 
            // 格式化ToolStripMenuItem
            // 
            this.格式化ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("格式化ToolStripMenuItem.Image")));
            this.格式化ToolStripMenuItem.Name = "格式化ToolStripMenuItem";
            this.格式化ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.格式化ToolStripMenuItem.Text = "格式化";
            this.格式化ToolStripMenuItem.Click += new System.EventHandler(this.格式化ToolStripMenuItem_Click_1);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制ToolStripMenuItem.Image")));
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴ToolStripMenuItem.Image")));
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切ToolStripMenuItem.Image")));
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除ToolStripMenuItem.Image")));
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("全选ToolStripMenuItem.Image")));
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("撤销ToolStripMenuItem.Image")));
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("重做ToolStripMenuItem.Image")));
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.重做ToolStripMenuItem.Text = "重做";
            this.重做ToolStripMenuItem.Click += new System.EventHandler(this.重做ToolStripMenuItem_Click);
            // 
            // TabJson
            // 
            this.TabJson.Controls.Add(this.jsonViewer1);
            this.TabJson.Location = new System.Drawing.Point(4, 22);
            this.TabJson.Name = "TabJson";
            this.TabJson.Padding = new System.Windows.Forms.Padding(3);
            this.TabJson.Size = new System.Drawing.Size(689, 413);
            this.TabJson.TabIndex = 1;
            this.TabJson.Text = "JSON";
            this.TabJson.UseVisualStyleBackColor = true;
            // 
            // TabHtml
            // 
            this.TabHtml.Controls.Add(this.TxtHTML);
            this.TabHtml.Location = new System.Drawing.Point(4, 22);
            this.TabHtml.Name = "TabHtml";
            this.TabHtml.Padding = new System.Windows.Forms.Padding(3);
            this.TabHtml.Size = new System.Drawing.Size(689, 413);
            this.TabHtml.TabIndex = 2;
            this.TabHtml.Text = "HTML";
            this.TabHtml.UseVisualStyleBackColor = true;
            // 
            // TxtHTML
            // 
            this.TxtHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHTML.ContextMenuStrip = this.HTMLContextMenuStrip;
            this.TxtHTML.Encoding = ((System.Text.Encoding)(resources.GetObject("TxtHTML.Encoding")));
            this.TxtHTML.IsIconBarVisible = false;
            this.TxtHTML.Location = new System.Drawing.Point(4, 6);
            this.TxtHTML.Name = "TxtHTML";
            this.TxtHTML.ShowEOLMarkers = true;
            this.TxtHTML.ShowInvalidLines = false;
            this.TxtHTML.ShowSpaces = true;
            this.TxtHTML.ShowTabs = true;
            this.TxtHTML.ShowVRuler = true;
            this.TxtHTML.Size = new System.Drawing.Size(680, 397);
            this.TxtHTML.TabIndex = 55;
            // 
            // HTMLContextMenuStrip
            // 
            this.HTMLContextMenuStrip.AllowDrop = true;
            this.HTMLContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Html格式化toolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.HTMLContextMenuStrip.Name = "contextMenuStrip1";
            this.HTMLContextMenuStrip.Size = new System.Drawing.Size(153, 202);
            // 
            // Html格式化toolStripMenuItem
            // 
            this.Html格式化toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Html格式化toolStripMenuItem.Image")));
            this.Html格式化toolStripMenuItem.Name = "Html格式化toolStripMenuItem";
            this.Html格式化toolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Html格式化toolStripMenuItem.Text = "格式化";
            this.Html格式化toolStripMenuItem.Click += new System.EventHandler(this.Html格式化toolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "复制";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "粘贴";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "剪切";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "删除";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "全选";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "撤销";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem8.Text = "重做";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // JsonContextMenuStrip
            // 
            this.JsonContextMenuStrip.AllowDrop = true;
            this.JsonContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Json格式化ToolStripMenuItem,
            this.Json复制ToolStripMenuItem,
            this.Json粘贴ToolStripMenuItem,
            this.Json剪切ToolStripMenuItem,
            this.Json删除ToolStripMenuItem,
            this.Json全选ToolStripMenuItem,
            this.Json撤销ToolStripMenuItem,
            this.Json重做ToolStripMenuItem});
            this.JsonContextMenuStrip.Name = "contextMenuStrip1";
            this.JsonContextMenuStrip.Size = new System.Drawing.Size(111, 180);
            // 
            // Json格式化ToolStripMenuItem
            // 
            this.Json格式化ToolStripMenuItem.Name = "Json格式化ToolStripMenuItem";
            this.Json格式化ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json复制ToolStripMenuItem
            // 
            this.Json复制ToolStripMenuItem.Name = "Json复制ToolStripMenuItem";
            this.Json复制ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json粘贴ToolStripMenuItem
            // 
            this.Json粘贴ToolStripMenuItem.Name = "Json粘贴ToolStripMenuItem";
            this.Json粘贴ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json剪切ToolStripMenuItem
            // 
            this.Json剪切ToolStripMenuItem.Name = "Json剪切ToolStripMenuItem";
            this.Json剪切ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json删除ToolStripMenuItem
            // 
            this.Json删除ToolStripMenuItem.Name = "Json删除ToolStripMenuItem";
            this.Json删除ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json全选ToolStripMenuItem
            // 
            this.Json全选ToolStripMenuItem.Name = "Json全选ToolStripMenuItem";
            this.Json全选ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json撤销ToolStripMenuItem
            // 
            this.Json撤销ToolStripMenuItem.Name = "Json撤销ToolStripMenuItem";
            this.Json撤销ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Json重做ToolStripMenuItem
            // 
            this.Json重做ToolStripMenuItem.Name = "Json重做ToolStripMenuItem";
            this.Json重做ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // jsonViewer1
            // 
            this.jsonViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonViewer1.AutoSize = true;
            this.jsonViewer1.Json = null;
            this.jsonViewer1.Location = new System.Drawing.Point(3, 3);
            this.jsonViewer1.Name = "jsonViewer1";
            this.jsonViewer1.Size = new System.Drawing.Size(680, 404);
            this.jsonViewer1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 438);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataFormater";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabXml.ResumeLayout(false);
            this.XmlContextMenuStrip.ResumeLayout(false);
            this.TabJson.ResumeLayout(false);
            this.TabJson.PerformLayout();
            this.TabHtml.ResumeLayout(false);
            this.HTMLContextMenuStrip.ResumeLayout(false);
            this.JsonContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabXml;
        private System.Windows.Forms.TabPage TabJson;
        private ICSharpCode.TextEditor.TextEditorControl TxtXml;
        private System.Windows.Forms.ContextMenuStrip XmlContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式化ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip JsonContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Json格式化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Json重做ToolStripMenuItem;
        private System.Windows.Forms.TabPage TabHtml;
        private ICSharpCode.TextEditor.TextEditorControl TxtHTML;
        private System.Windows.Forms.ContextMenuStrip HTMLContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Html格式化toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private EPocalipse.Json.Viewer.JsonViewer jsonViewer1;
    }
}

