namespace Asp.Net.WebProject.ReName
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReName = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtNewProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldProjectName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClearBinAndObj = new System.Windows.Forms.CheckBox();
            this.txtSelectFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReName
            // 
            this.btnReName.Location = new System.Drawing.Point(291, 219);
            this.btnReName.Margin = new System.Windows.Forms.Padding(4);
            this.btnReName.Name = "btnReName";
            this.btnReName.Size = new System.Drawing.Size(300, 56);
            this.btnReName.TabIndex = 0;
            this.btnReName.Text = "重命名";
            this.btnReName.UseVisualStyleBackColor = true;
            this.btnReName.Click += new System.EventHandler(this.btnReName_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(228, 321);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(215, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "极客易客-blog.geekek.me";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtNewProjectName
            // 
            this.txtNewProjectName.Location = new System.Drawing.Point(186, 168);
            this.txtNewProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProjectName.Name = "txtNewProjectName";
            this.txtNewProjectName.Size = new System.Drawing.Size(484, 28);
            this.txtNewProjectName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "重命名为：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "解决方案名称：";
            // 
            // txtOldProjectName
            // 
            this.txtOldProjectName.Location = new System.Drawing.Point(186, 126);
            this.txtOldProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldProjectName.Name = "txtOldProjectName";
            this.txtOldProjectName.ReadOnly = true;
            this.txtOldProjectName.Size = new System.Drawing.Size(484, 28);
            this.txtOldProjectName.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(186, 36);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(486, 34);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "选择解决方案文件……";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "选择解决方案文件：";
            // 
            // cbClearBinAndObj
            // 
            this.cbClearBinAndObj.AutoSize = true;
            this.cbClearBinAndObj.Checked = true;
            this.cbClearBinAndObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClearBinAndObj.Location = new System.Drawing.Point(28, 236);
            this.cbClearBinAndObj.Margin = new System.Windows.Forms.Padding(4);
            this.cbClearBinAndObj.Name = "cbClearBinAndObj";
            this.cbClearBinAndObj.Size = new System.Drawing.Size(196, 22);
            this.cbClearBinAndObj.TabIndex = 10;
            this.cbClearBinAndObj.Text = "清除Bin和Obj文件夹";
            this.cbClearBinAndObj.UseVisualStyleBackColor = true;
            // 
            // txtSelectFilePath
            // 
            this.txtSelectFilePath.Location = new System.Drawing.Point(186, 86);
            this.txtSelectFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelectFilePath.Name = "txtSelectFilePath";
            this.txtSelectFilePath.ReadOnly = true;
            this.txtSelectFilePath.Size = new System.Drawing.Size(484, 28);
            this.txtSelectFilePath.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "解决方案根目录：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSelectFilePath);
            this.Controls.Add(this.cbClearBinAndObj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewProjectName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnReName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asp.Net项目重名工具-blog.geekek.me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtNewProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldProjectName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbClearBinAndObj;
        private System.Windows.Forms.TextBox txtSelectFilePath;
        private System.Windows.Forms.Label label4;
    }
}

