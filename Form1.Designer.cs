namespace TortoiseTTSApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.qualityList = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voiceList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 309);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(12, 379);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(149, 24);
            this.outputButton.TabIndex = 1;
            this.outputButton.Text = "Select Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // qualityList
            // 
            this.qualityList.AccessibleName = "qualityList";
            this.qualityList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.qualityList.FormattingEnabled = true;
            this.qualityList.Items.AddRange(new object[] {
            "Ultra Fast",
            "Fast",
            "Standard",
            "High Quality"});
            this.qualityList.Location = new System.Drawing.Point(335, 379);
            this.qualityList.Name = "qualityList";
            this.qualityList.Size = new System.Drawing.Size(149, 24);
            this.qualityList.TabIndex = 2;
            this.qualityList.Text = "Select Quality...";
            this.qualityList.SelectedIndexChanged += new System.EventHandler(this.qualityList_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 411);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(472, 50);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.voiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 144);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(217, 287);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(55, 16);
            this.creditLabel.TabIndex = 5;
            this.creditLabel.TabStop = true;
            this.creditLabel.Text = "CREDITS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 128);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // voiceList
            // 
            this.voiceList.AccessibleName = "voiceList";
            this.voiceList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.voiceList.FormattingEnabled = true;
            this.voiceList.Location = new System.Drawing.Point(174, 379);
            this.voiceList.Name = "voiceList";
            this.voiceList.Size = new System.Drawing.Size(149, 24);
            this.voiceList.TabIndex = 7;
            this.voiceList.Text = "Select Voice...";
            this.voiceList.SelectedIndexChanged += new System.EventHandler(this.voiceList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.voiceList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.qualityList);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TorToiSe Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button outputButton;
        private ComboBox qualityList;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog1;
        private Button generateButton;
        private Label label1;
        private LinkLabel creditLabel;
        private PictureBox pictureBox1;
        private ComboBox voiceList;
    }
}