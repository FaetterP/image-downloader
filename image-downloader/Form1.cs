using image_downloader.models;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace image_downloader
{
    public partial class Form1 : Form
    {
        private string _pathToSave = Application.StartupPath + "\\saves\\";
        private int _count = 100;
        private Model _model = new PrntscModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(_pathToSave) == false)
            {
                Directory.CreateDirectory(_pathToSave);
            }
            selectedFolderText.Text = _pathToSave;
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _pathToSave = dialog.SelectedPath;
                selectedFolderText.Text = _pathToSave;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _count; i++)
            {
                string url = _model.GenerateURL();
                if (url == "") continue;
                urlLabel.Text += i + ")" + url + "\n";

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, @_pathToSave + url.Remove(0,32));
                }

            }
        }
    }
}
