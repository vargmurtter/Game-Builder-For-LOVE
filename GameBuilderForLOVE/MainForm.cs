using System;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Windows.Forms;

namespace GameBuilderForLOVE
{
    public partial class MainForm : Form
    {
        // путь к проекту на LOVE
        private string pathToProject = null;

        // путь к папке кэширования
        private static string cacheFolder = @"C:\GameBuilderForLOVE\Cache";

        // путь к *.dat файлу, который хранит в себе путь к последнему открытому проекту
        private string lastProject = cacheFolder + @"\lastproject.dat";

        // конструктор
        public MainForm()
        {
            InitializeComponent();
        }
        
        // собираем и запускаем проект
        private void BuildAndStart()
        {
            Build();

            Process.Start(cacheFolder + @"\build.love");
        }

        // собираем проект и открываем папку с билдом
        private void BuildAndOpenFolder()
        {
            Build();

            Process.Start("explorer", cacheFolder);
        }

        // собираем проект 
        private void Build()
        {
            if (File.Exists(pathToProject + @"\main.lua"))
            {
                CreateLoveFile();
            }
            else
            {
                MessageBox.Show("main.lua not found..", "Buliding...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // создаём файл *.love
        private void CreateLoveFile()
        {
            string startPath = pathToProject;
            string zipPath = cacheFolder + @"\build.love";

            try
            {
                if (File.Exists(zipPath))
                {
                    File.Delete(zipPath);
                }

                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Buliding...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        // создаём кэш-папку
        private void CreateCacheFolder()
        {
            try
            {
                if (!Directory.Exists(cacheFolder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(cacheFolder);
                }

                File.WriteAllText(lastProject, pathToProject);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Creating cache folder...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        // выбираем папку с проектом
        private string ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        // открываем папку с проектом
        private void OpenProjectFolder()
        {
            if (pathToProject != null)
            {
                Process.Start("explorer", pathToProject);
            }
        }

        // событие: нажата кнопка, открывающая папку с проектом
        private void ChooseProjectFolderBtn_Click(object sender, EventArgs e)
        {
            pathToProject = ChooseFolder();

            CreateCacheFolder();

            statusLabelProject.Text = "Project: " + pathToProject;

        }

        // событие: нажата кнопка, собирающая проект
        private void BuildProject_Click(object sender, EventArgs e)
        {
            BuildAndStart();
        }

        // событие: нажата кнопка, собирающая проект и открывающая папку с билдом
        private void BuildAndOpenFolderBtn_Click(object sender, EventArgs e)
        {
            BuildAndOpenFolder();
        }

        // событие: нажата кнопка, открывающая папку с проектом
        private void OpenCurrentProjectFolder_Click(object sender, EventArgs e)
        {
            OpenProjectFolder();
        }

        // событие: форма загружена
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(lastProject))
            {
                pathToProject = File.ReadAllText(lastProject);
                statusLabelProject.Text = "Project: " + pathToProject;
            }
        }

    }
}
