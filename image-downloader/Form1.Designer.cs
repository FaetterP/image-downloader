
namespace image_downloader
{
    partial class Form1
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
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.selectedFolderText = new System.Windows.Forms.Label();
            this.selectSourceDropdown = new System.Windows.Forms.ComboBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(12, 55);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(104, 37);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // selectedFolderText
            // 
            this.selectedFolderText.AutoSize = true;
            this.selectedFolderText.Location = new System.Drawing.Point(122, 65);
            this.selectedFolderText.Name = "selectedFolderText";
            this.selectedFolderText.Size = new System.Drawing.Size(26, 17);
            this.selectedFolderText.TabIndex = 1;
            this.selectedFolderText.Text = "D:\\";
            // 
            // selectSourceDropdown
            // 
            this.selectSourceDropdown.FormattingEnabled = true;
            this.selectSourceDropdown.Items.AddRange(new object[] {
            "prntsc",
            "imgur"});
            this.selectSourceDropdown.Location = new System.Drawing.Point(71, 12);
            this.selectSourceDropdown.Name = "selectSourceDropdown";
            this.selectSourceDropdown.Size = new System.Drawing.Size(121, 24);
            this.selectSourceDropdown.TabIndex = 2;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(12, 15);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(53, 17);
            this.sourceLabel.TabIndex = 3;
            this.sourceLabel.Text = "Source";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 125);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 32);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 193);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.selectSourceDropdown);
            this.Controls.Add(this.selectedFolderText);
            this.Controls.Add(this.selectFolderButton);
            this.Name = "Form1";
            this.Text = "image-downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label selectedFolderText;
        private System.Windows.Forms.ComboBox selectSourceDropdown;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

