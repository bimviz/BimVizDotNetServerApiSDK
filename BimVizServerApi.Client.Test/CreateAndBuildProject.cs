using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BimViz.ServerApi.Client;
using BimViz.ServerApi.Client.Model;

namespace BimVizServerApi.Client.Test
{
    public partial class CreateAndBuildProject : Form
    {
        string mUserName;
        string mProjectId;
        BimVizServerApiClient mApiClient;

        public CreateAndBuildProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mUserName = "";
            mApiClient = new BimVizServerApiClient("", ""); //公有云试用url:http://cloud.bimviz.io

            btnUploadModelFiles.Enabled = false;
            btnSceneBuild.Enabled = false;
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //项目基本信息
            BVProject project = new BVProject();
            project.Name = "测试项目";
            project.Description = "测试备注";

            //场景设置，创建项目的时候可以为空
            ProjectSettings settings = new ProjectSettings();
            settings.BackgroundStyle = (int)SceneBackgroundStyle.White;
            settings.SceneComplex = (int)SceneLoadMode.Complete;
            settings.ThemeStyle = (int)SceneThemeStyle.ModelSelf;
            settings.GroundStyle = SceneGroundStyle.GreenLand;
            settings.SceneDomain = (int)SceneDomain.Architectural;

            ProjectInfo prjInfo = new ProjectInfo();
            prjInfo.Project = project;
            prjInfo.SceneSettings = settings;

            lblMessage.Text = "正在创建项目...";
            ResultModel result = mApiClient.ModelProjectManager.AddProject(mUserName, prjInfo);
            if (result != null && result.IsSuccess)
            {
                mProjectId = result.ProjectId;
                btnUploadModelFiles.Enabled = true;               
            }

            lblMessage.Text = result.Message;
        }

        private void btnUploadModelFiles_Click(object sender, EventArgs e)
        {
            List<string> files = SelectFiles();
            if (files == null || files.Count < 1)
            {
                lblMessage.Text = "请选择上传的模型文件！";
                return;
            }

            lblMessage.Text = "正在上传项目模型...";            
            mApiClient.ModelProjectManager.UploadProjectFileAsync(mUserName, mProjectId, files[0], UploadProjectFileProgress, UploadProjectFileCompleted);
            /*ResultModel result = mApiClient.ModelProjectManager.UploadProjectFiles(mUserName, mProjectId, files);
            if (result.IsSuccess)
            {
                btnSceneBuild.Enabled = true;
            }

            lblMessage.Text = result.Message;*/
        }
        
        private void UploadProjectFileProgress(object sender, UploadProgressChangedEventArgs e)
        {            
            string test = string.Format("上传文件{0}/{1}，文件上传进度：{2}", e.BytesSent, e.TotalBytesToSend, e.ProgressPercentage);
            progressBar.Value = e.ProgressPercentage;
            lblMessage.Text = test;           
        }

        private void UploadProjectFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            lblMessage.Text = "文件上传完成！";
        }

        private void btnSceneBuild_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "正在编译项目...";
            ResultModel result = mApiClient.ProjectBuildManager.RebuildScene(mUserName, mProjectId, RebuildCmd.RebuildAll);
            lblMessage.Text = result.Message;
        }

        private List<string> SelectFiles()
        {
            List<string> files = new List<string>();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "ifc files (*.ifc)|*.ifc|bzip2 files (*.bzip2)|*.bzip2";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(fileDialog.FileNames);
            }

            return files;
        }
    }
}
