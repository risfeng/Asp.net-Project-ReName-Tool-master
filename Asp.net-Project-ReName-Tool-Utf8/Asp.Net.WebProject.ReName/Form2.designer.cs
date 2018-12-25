﻿namespace Asp.Net.WebProject.ReName
{
    partial class FileReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileReplaceForm));
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
            this.btnReName.Location = new System.Drawing.Point(194, 146);
            this.btnReName.Name = "btnReName";
            this.btnReName.Size = new System.Drawing.Size(200, 37);
            this.btnReName.TabIndex = 0;
            this.btnReName.Text = "开始替换";
            this.btnReName.UseVisualStyleBackColor = true;
            this.btnReName.Click += new System.EventHandler(this.btnReName_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(152, 214);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "极客易客-blog.geekek.me";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtNewProjectName
            // 
            this.txtNewProjectName.Location = new System.Drawing.Point(124, 112);
            this.txtNewProjectName.Name = "txtNewProjectName";
            this.txtNewProjectName.Size = new System.Drawing.Size(324, 21);
            this.txtNewProjectName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "替换为：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "需要替换的名称：";
            // 
            // txtOldProjectName
            // 
            this.txtOldProjectName.Location = new System.Drawing.Point(124, 84);
            this.txtOldProjectName.Name = "txtOldProjectName";
            this.txtOldProjectName.Size = new System.Drawing.Size(324, 21);
            this.txtOldProjectName.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(124, 24);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(324, 23);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "选择解决方案文件……";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "选择解决方案文件：";
            // 
            // cbClearBinAndObj
            // 
            this.cbClearBinAndObj.AutoSize = true;
            this.cbClearBinAndObj.Checked = true;
            this.cbClearBinAndObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClearBinAndObj.Location = new System.Drawing.Point(19, 157);
            this.cbClearBinAndObj.Name = "cbClearBinAndObj";
            this.cbClearBinAndObj.Size = new System.Drawing.Size(132, 16);
            this.cbClearBinAndObj.TabIndex = 10;
            this.cbClearBinAndObj.Text = "清除Bin和Obj文件夹";
            this.cbClearBinAndObj.UseVisualStyleBackColor = true;
            // 
            // txtSelectFilePath
            // 
            this.txtSelectFilePath.Location = new System.Drawing.Point(124, 57);
            this.txtSelectFilePath.Name = "txtSelectFilePath";
            this.txtSelectFilePath.ReadOnly = true;
            this.txtSelectFilePath.Size = new System.Drawing.Size(324, 21);
            this.txtSelectFilePath.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "解决方案根目录：";
            // 
            // FileReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 252);
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
            this.Name = "FileReplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asp.Net文件重名工具-blog.geekek.me";
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

