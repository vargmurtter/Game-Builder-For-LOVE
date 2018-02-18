namespace GameBuilderForLOVE
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAndStart = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildAndOpenFolderBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelProject = new System.Windows.Forms.ToolStripStatusLabel();
            this.BuildProject = new System.Windows.Forms.Button();
            this.OpenCurrentProjectFolder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.openProjectFolder});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.ChooseProjectFolderBtn_Click);
            // 
            // openProjectFolder
            // 
            this.openProjectFolder.Name = "openProjectFolder";
            this.openProjectFolder.Size = new System.Drawing.Size(179, 22);
            this.openProjectFolder.Text = "Open Project Folder";
            this.openProjectFolder.Click += new System.EventHandler(this.OpenCurrentProjectFolder_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAndStart,
            this.BuildAndOpenFolderBtn});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildAndStart
            // 
            this.buildAndStart.Name = "buildAndStart";
            this.buildAndStart.Size = new System.Drawing.Size(194, 22);
            this.buildAndStart.Text = "Build And Start";
            this.buildAndStart.Click += new System.EventHandler(this.BuildProject_Click);
            // 
            // BuildAndOpenFolderBtn
            // 
            this.BuildAndOpenFolderBtn.Name = "BuildAndOpenFolderBtn";
            this.BuildAndOpenFolderBtn.Size = new System.Drawing.Size(194, 22);
            this.BuildAndOpenFolderBtn.Text = "Build And Open Folder";
            this.BuildAndOpenFolderBtn.Click += new System.EventHandler(this.BuildAndOpenFolderBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelProject});
            this.statusStrip1.Location = new System.Drawing.Point(0, 95);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(370, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelProject
            // 
            this.statusLabelProject.Name = "statusLabelProject";
            this.statusLabelProject.Size = new System.Drawing.Size(0, 17);
            // 
            // BuildProject
            // 
            this.BuildProject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuildProject.BackgroundImage")));
            this.BuildProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuildProject.Location = new System.Drawing.Point(2, 31);
            this.BuildProject.Name = "BuildProject";
            this.BuildProject.Size = new System.Drawing.Size(60, 60);
            this.BuildProject.TabIndex = 2;
            this.BuildProject.UseVisualStyleBackColor = true;
            this.BuildProject.Click += new System.EventHandler(this.BuildProject_Click);
            // 
            // OpenCurrentProjectFolder
            // 
            this.OpenCurrentProjectFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenCurrentProjectFolder.BackgroundImage")));
            this.OpenCurrentProjectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenCurrentProjectFolder.Location = new System.Drawing.Point(68, 32);
            this.OpenCurrentProjectFolder.Name = "OpenCurrentProjectFolder";
            this.OpenCurrentProjectFolder.Size = new System.Drawing.Size(60, 60);
            this.OpenCurrentProjectFolder.TabIndex = 3;
            this.OpenCurrentProjectFolder.UseVisualStyleBackColor = true;
            this.OpenCurrentProjectFolder.Click += new System.EventHandler(this.OpenCurrentProjectFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 117);
            this.Controls.Add(this.OpenCurrentProjectFolder);
            this.Controls.Add(this.BuildProject);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game Builder For LÖVE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelProject;
        private System.Windows.Forms.Button BuildProject;
        private System.Windows.Forms.Button OpenCurrentProjectFolder;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildAndStart;
        private System.Windows.Forms.ToolStripMenuItem BuildAndOpenFolderBtn;
        private System.Windows.Forms.ToolStripMenuItem openProjectFolder;
    }
}

