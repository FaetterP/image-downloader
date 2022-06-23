using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_downloader
{
    public partial class Form1 : Form
    {
        private string _pathToSave = "";

        public Form1()
        {
            InitializeComponent();
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

        }
    }
}
