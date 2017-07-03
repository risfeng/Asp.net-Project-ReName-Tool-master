using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asp.Net.WebProject.ReName
{
    public partial class ReplaceForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = "Files|*.sln",
            Title = "请选择一个解决方案文件"
        };
        public ReplaceForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://blog.geekek.me");
        }

        /// <summary>
        /// 更新按钮文本的
        /// </summary>
        /// <param name="text"></param>
        /// <param name="btn"></param>
        /// <param name="Enable"></param>
        delegate void SetButtonValueCallBack(string text, Button btn, bool Enable);
        public void SetButtonValue(string text, Button btn, bool Enable)
        {
            if (btn.InvokeRequired)
            {
                SetButtonValueCallBack d = new SetButtonValueCallBack(SetButtonValue);
                this.Invoke(d, new object[] { text, btn, Enable });
            }
            else
            {
                btn.Text = text;
                btn.Enabled = Enable;
            }
        }
        private void btnReName_Click(object sender, EventArgs e)
        {
            try
            {
                ((Action)ReName).BeginInvoke(null, null); //调用委托的异步执行方法，回调函数为空 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReName()
        {

            try
            {

                if (string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    MessageBox.Show("请选择解决方案文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newProjectName = txtNewProjectName.Text.Trim();
                if (string.IsNullOrEmpty(newProjectName))
                {
                    MessageBox.Show("请输入新名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dr = MessageBox.Show("在重命名项目前请一定先备份，以免程序不当之处导致您的损失，以此产生的损失一切由自己担负。您确定要继续吗?", "备份警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)//如果点击“确定”按钮
                {
                    return;
                }
                SetButtonValue("正在处理中……", btnReName, false);
                var filePath = openFileDialog.FileName;
                var fullPath = Path.GetFullPath(filePath);  //绝对路径
                var fileExtension = Path.GetExtension(filePath); //文件扩展名 带.
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);//文件名没有扩展名
                var fileName = Path.GetFileName(filePath); //得到文件名包括扩展名
                var directoryName = Path.GetDirectoryName(filePath); //得到文件所在目录


                //新文件名称
                var newProjectFullPath = string.Format("{0}\\{1}{2}", directoryName, newProjectName, fileExtension);
                //移动
                if (!File.Exists(newProjectFullPath))
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    fileInfo.MoveTo(newProjectFullPath);
                }
                //读取解决方案文件内容并替换名称
                var projectContent = File.ReadAllText(newProjectFullPath, Encoding.UTF8);
                projectContent = projectContent.Replace(fileNameWithoutExtension, newProjectName);
                //将新内容写入到解决方案文件
                using (StreamWriter f2 = new StreamWriter(newProjectFullPath, false, Encoding.UTF8))
                {
                    f2.WriteLine(projectContent);
                    f2.Flush();
                    f2.Close();

                };
                //遍历所有目录并修改文件
                FindAndEditFile(directoryName);

                SetButtonValue("重命名", btnReName, true);
                MessageBox.Show("处理完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 递归 查找文件及目录
        /// </summary>
        /// <param name="sSourcePath">递归起始目录</param>
        public void FindAndEditFile(string sSourcePath)
        {
            var filePath = openFileDialog.FileName;
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);//文件名没有扩展名
            var newProjectName = txtNewProjectName.Text.Trim();//新名

            //在指定目录及子目录下查找文件
            DirectoryInfo Dir = new DirectoryInfo(sSourcePath);
            DirectoryInfo[] DirSub = Dir.GetDirectories();
            if (DirSub.Length <= 0)
            {
                foreach (FileInfo f in Dir.GetFiles("*.*", SearchOption.TopDirectoryOnly)) //查找文件
                {
                    ReplaceFile(f, fileNameWithoutExtension, newProjectName);

                }
            }
            int t = 1;
            foreach (DirectoryInfo d in DirSub)//查找子目录 
            {
                if (cbClearBinAndObj.Checked)
                {
                    if (d.Name.Contains("bin") || d.Name.Contains("obj"))
                    {
                        //删除文件夹  
                        Directory.Delete(d.FullName, true);
                        continue;
                    }
                }
                else
                {
                    if (d.Name.Contains("bin") || d.Name.Contains("obj"))
                    {
                        continue;
                    }
                }

                var newpath = string.Format("{0}\\{1}", Dir, d.Name.Replace(fileNameWithoutExtension, newProjectName));
                if (d.Name.Contains(fileNameWithoutExtension))
                {
                    Directory.Move(d.FullName, newpath);//更改目录名称
                }
                FindAndEditFile(newpath);//递归 

                if (t == 1)
                {
                    foreach (FileInfo f in Dir.GetFiles("*.*", SearchOption.TopDirectoryOnly)) //查找文件
                    {
                        ReplaceFile(f, fileNameWithoutExtension, newProjectName);
                    }
                    t++;
                }
            }
        }
        /// <summary>
        /// 替换名称
        /// </summary>
        /// <param name="f">当前文件信息</param>
        /// <param name="oldName">旧名称</param>
        /// <param name="newName">新名称</param>
        private void ReplaceFile(FileInfo f, string oldName, string newName)
        {

            var fullpath = f.FullName;
            var currentFileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullpath);
            if (currentFileNameWithoutExtension.Contains(oldName))
            {
                //新文件名称
                var newProjectFullPath = fullpath.Replace(oldName, newName);

                //复制
                if (!File.Exists(newProjectFullPath))
                {
                    FileInfo fileInfo = new FileInfo(fullpath);
                    fileInfo.MoveTo(newProjectFullPath);
                }
                //读取解决方案文件内容并替换名称
                var fileContent = File.ReadAllText(newProjectFullPath, Encoding.UTF8);
                fileContent = fileContent.Replace(oldName, newName);
                //将新内容写入到解决方案文件
                using (StreamWriter f2 = new StreamWriter(newProjectFullPath, false, Encoding.UTF8))
                {
                    f2.WriteLine(fileContent);
                    f2.Flush();
                    f2.Close();

                };

            }
            else
            {
                //读取解决方案文件内容并替换名称
                var fileContent = File.ReadAllText(fullpath, Encoding.UTF8);
                if (fileContent.Contains(oldName))
                {
                    fileContent = fileContent.Replace(oldName, newName);
                    //将新内容写入到解决方案文件
                    using (StreamWriter f2 = new StreamWriter(fullpath, false, Encoding.UTF8))
                    {
                        f2.WriteLine(fileContent);
                        f2.Flush();
                        f2.Close();

                    };
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                var fileName = Path.GetFileNameWithoutExtension(filePath); //得到文件名包括扩展名
                var directoryName = Path.GetDirectoryName(filePath); //得到文件所在目录

                txtSelectFilePath.Text = string.Format("{0}", directoryName);

                txtOldProjectName.Text = fileName;//解决方案名称
            }
        }

        private void btnOpenFileReplace_Click(object sender, EventArgs e)
        {
            FileReplaceForm ff = new FileReplaceForm();
            ff.ShowDialog();
        }
    }
}
