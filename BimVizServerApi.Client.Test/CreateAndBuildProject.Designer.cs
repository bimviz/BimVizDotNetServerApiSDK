namespace BimVizServerApi.Client.Test
{
    partial class CreateAndBuildProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUploadModelFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSceneBuild = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一步创建项目：";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(181, 23);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(88, 23);
            this.btnCreateProject.TabIndex = 1;
            this.btnCreateProject.Text = "创建项目";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "第二步上传项目模型：";
            // 
            // btnUploadModelFiles
            // 
            this.btnUploadModelFiles.Location = new System.Drawing.Point(181, 73);
            this.btnUploadModelFiles.Name = "btnUploadModelFiles";
            this.btnUploadModelFiles.Size = new System.Drawing.Size(88, 23);
            this.btnUploadModelFiles.TabIndex = 3;
            this.btnUploadModelFiles.Text = "上传项目模型";
            this.btnUploadModelFiles.UseVisualStyleBackColor = true;
            this.btnUploadModelFiles.Click += new System.EventHandler(this.btnUploadModelFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "第三部编译项目：";
            // 
            // btnSceneBuild
            // 
            this.btnSceneBuild.Location = new System.Drawing.Point(181, 122);
            this.btnSceneBuild.Name = "btnSceneBuild";
            this.btnSceneBuild.Size = new System.Drawing.Size(88, 23);
            this.btnSceneBuild.TabIndex = 5;
            this.btnSceneBuild.Text = "编译项目";
            this.btnSceneBuild.UseVisualStyleBackColor = true;
            this.btnSceneBuild.Click += new System.EventHandler(this.btnSceneBuild_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(34, 168);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(29, 12);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "消息";
            // 
            // CreateAndBuildProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 199);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSceneBuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUploadModelFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.label1);
            this.Name = "CreateAndBuildProject";
            this.Text = "BimViz Server API测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUploadModelFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSceneBuild;
        private System.Windows.Forms.Label lblMessage;
    }
}

