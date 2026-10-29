namespace paperman
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            richTextBox1 = new RichTextBox();
            btnSaveFile = new Button();
            btnWriteFile = new Button();
            btnDeleteFile = new Button();
            btnReadFile = new Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 128, 0);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(569, 82);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(569, 82);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PAPERMAN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(0, 64, 64);
            panelMain.Controls.Add(richTextBox1);
            panelMain.Controls.Add(btnSaveFile);
            panelMain.Controls.Add(btnWriteFile);
            panelMain.Controls.Add(btnDeleteFile);
            panelMain.Controls.Add(btnReadFile);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 82);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(569, 308);
            panelMain.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(280, 11);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 274);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.Gainsboro;
            btnSaveFile.FlatStyle = FlatStyle.Flat;
            btnSaveFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveFile.ImageAlign = ContentAlignment.MiddleRight;
            btnSaveFile.Location = new Point(10, 11);
            btnSaveFile.Margin = new Padding(3, 2, 3, 2);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Padding = new Padding(9, 0, 9, 0);
            btnSaveFile.Size = new Size(245, 60);
            btnSaveFile.TabIndex = 0;
            btnSaveFile.Text = "Save file";
            btnSaveFile.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackColor = Color.Gainsboro;
            btnWriteFile.FlatStyle = FlatStyle.Flat;
            btnWriteFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWriteFile.ImageAlign = ContentAlignment.MiddleRight;
            btnWriteFile.Location = new Point(10, 82);
            btnWriteFile.Margin = new Padding(3, 2, 3, 2);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Padding = new Padding(9, 0, 9, 0);
            btnWriteFile.Size = new Size(245, 60);
            btnWriteFile.TabIndex = 1;
            btnWriteFile.Text = "Write file";
            btnWriteFile.TextAlign = ContentAlignment.MiddleLeft;
            btnWriteFile.UseVisualStyleBackColor = false;
            btnWriteFile.Click += btnWriteFile_Click_1;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.BackColor = Color.Gainsboro;
            btnDeleteFile.FlatStyle = FlatStyle.Flat;
            btnDeleteFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteFile.ImageAlign = ContentAlignment.MiddleRight;
            btnDeleteFile.Location = new Point(10, 154);
            btnDeleteFile.Margin = new Padding(3, 2, 3, 2);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Padding = new Padding(9, 0, 9, 0);
            btnDeleteFile.Size = new Size(245, 60);
            btnDeleteFile.TabIndex = 2;
            btnDeleteFile.Text = "Delete file";
            btnDeleteFile.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteFile.UseVisualStyleBackColor = false;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = Color.Gainsboro;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReadFile.ImageAlign = ContentAlignment.MiddleRight;
            btnReadFile.Location = new Point(10, 225);
            btnReadFile.Margin = new Padding(3, 2, 3, 2);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Padding = new Padding(9, 0, 9, 0);
            btnReadFile.Size = new Size(245, 60);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "Read file";
            btnReadFile.TextAlign = ContentAlignment.MiddleLeft;
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 390);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Files";
            panelHeader.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnReadFile;
        private RichTextBox richTextBox1;
    }
}