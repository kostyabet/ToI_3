namespace TI_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFilePlain = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFilePlain = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelP = new System.Windows.Forms.Label();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.TextBoxQ = new System.Windows.Forms.TextBox();
            this.LabelQ = new System.Windows.Forms.Label();
            this.TextBoxR = new System.Windows.Forms.TextBox();
            this.LabelR = new System.Windows.Forms.Label();
            this.ButtonR = new System.Windows.Forms.Button();
            this.LabelD = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.EulerLabel = new System.Windows.Forms.Label();
            this.TextBoxEuler = new System.Windows.Forms.TextBox();
            this.RadioButtonCipher = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecipher = new System.Windows.Forms.RadioButton();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.LabelE = new System.Windows.Forms.Label();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCipher = new System.Windows.Forms.Label();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.DarkGray;
            this.OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileCipher,
            this.OpenFilePlain});
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(224, 26);
            this.OpenFile.Text = "Открыть файл";
            // 
            // OpenFileCipher
            // 
            this.OpenFileCipher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OpenFileCipher.Enabled = false;
            this.OpenFileCipher.Name = "OpenFileCipher";
            this.OpenFileCipher.Size = new System.Drawing.Size(283, 26);
            this.OpenFileCipher.Text = "С зашифрованным текстом";
            this.OpenFileCipher.Click += new System.EventHandler(this.OpenFileCipher_Click);
            // 
            // OpenFilePlain
            // 
            this.OpenFilePlain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OpenFilePlain.Name = "OpenFilePlain";
            this.OpenFilePlain.Size = new System.Drawing.Size(283, 26);
            this.OpenFilePlain.Text = "С исходным текстом";
            this.OpenFilePlain.Click += new System.EventHandler(this.OpenFilePlain_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFilePlain,
            this.SaveFileCipher});
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(224, 26);
            this.SaveFile.Text = "Сохранить в файл";
            // 
            // SaveFilePlain
            // 
            this.SaveFilePlain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveFilePlain.Enabled = false;
            this.SaveFilePlain.Name = "SaveFilePlain";
            this.SaveFilePlain.Size = new System.Drawing.Size(326, 26);
            this.SaveFilePlain.Text = "Сохранить исходный текст";
            this.SaveFilePlain.Click += new System.EventHandler(this.SaveFilePlain_Click);
            // 
            // SaveFileCipher
            // 
            this.SaveFileCipher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveFileCipher.Name = "SaveFileCipher";
            this.SaveFileCipher.Size = new System.Drawing.Size(326, 26);
            this.SaveFileCipher.Text = "Сохранить зашифрованный текст";
            this.SaveFileCipher.Click += new System.EventHandler(this.SaveFileCipher_Click);
            // 
            // ClearStrip
            // 
            this.ClearStrip.BackColor = System.Drawing.Color.DarkGray;
            this.ClearStrip.Name = "ClearStrip";
            this.ClearStrip.Size = new System.Drawing.Size(125, 24);
            this.ClearStrip.Text = "Очистить поля";
            this.ClearStrip.Click += new System.EventHandler(this.ClearStrip_Click);
            // 
            // LabelP
            // 
            this.LabelP.Location = new System.Drawing.Point(251, 78);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(26, 23);
            this.LabelP.TabIndex = 1;
            this.LabelP.Text = "P:";
            // 
            // TextBoxP
            // 
            this.TextBoxP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxP.Location = new System.Drawing.Point(276, 75);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(222, 27);
            this.TextBoxP.TabIndex = 2;
            this.TextBoxP.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // TextBoxQ
            // 
            this.TextBoxQ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxQ.Location = new System.Drawing.Point(276, 108);
            this.TextBoxQ.Name = "TextBoxQ";
            this.TextBoxQ.Size = new System.Drawing.Size(222, 27);
            this.TextBoxQ.TabIndex = 4;
            this.TextBoxQ.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // LabelQ
            // 
            this.LabelQ.Location = new System.Drawing.Point(251, 111);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(26, 23);
            this.LabelQ.TabIndex = 3;
            this.LabelQ.Text = "Q:";
            // 
            // TextBoxR
            // 
            this.TextBoxR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxR.Location = new System.Drawing.Point(62, 187);
            this.TextBoxR.Multiline = true;
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.ReadOnly = true;
            this.TextBoxR.Size = new System.Drawing.Size(222, 27);
            this.TextBoxR.TabIndex = 5;
            // 
            // LabelR
            // 
            this.LabelR.Location = new System.Drawing.Point(39, 190);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(37, 23);
            this.LabelR.TabIndex = 6;
            this.LabelR.Text = "R:";
            // 
            // ButtonR
            // 
            this.ButtonR.BackColor = System.Drawing.Color.Silver;
            this.ButtonR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonR.FlatAppearance.BorderSize = 0;
            this.ButtonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonR.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ButtonR.Location = new System.Drawing.Point(355, 141);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(345, 30);
            this.ButtonR.TabIndex = 7;
            this.ButtonR.Text = "Рассчитать параметры";
            this.ButtonR.UseVisualStyleBackColor = false;
            this.ButtonR.Click += new System.EventHandler(this.ButtonR_Click);
            // 
            // LabelD
            // 
            this.LabelD.Location = new System.Drawing.Point(564, 81);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(173, 23);
            this.LabelD.TabIndex = 8;
            this.LabelD.Text = "Закрытая константа D:";
            // 
            // TextBoxD
            // 
            this.TextBoxD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxD.Location = new System.Drawing.Point(568, 103);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(249, 27);
            this.TextBoxD.TabIndex = 9;
            this.TextBoxD.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // EulerLabel
            // 
            this.EulerLabel.Location = new System.Drawing.Point(324, 190);
            this.EulerLabel.Name = "EulerLabel";
            this.EulerLabel.Size = new System.Drawing.Size(56, 23);
            this.EulerLabel.TabIndex = 10;
            this.EulerLabel.Text = "φ(R):";
            // 
            // TextBoxEuler
            // 
            this.TextBoxEuler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxEuler.Location = new System.Drawing.Point(370, 187);
            this.TextBoxEuler.Multiline = true;
            this.TextBoxEuler.Name = "TextBoxEuler";
            this.TextBoxEuler.ReadOnly = true;
            this.TextBoxEuler.Size = new System.Drawing.Size(222, 27);
            this.TextBoxEuler.TabIndex = 11;
            // 
            // RadioButtonCipher
            // 
            this.RadioButtonCipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonCipher.Checked = true;
            this.RadioButtonCipher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RadioButtonCipher.Location = new System.Drawing.Point(19, 381);
            this.RadioButtonCipher.Name = "RadioButtonCipher";
            this.RadioButtonCipher.Size = new System.Drawing.Size(121, 24);
            this.RadioButtonCipher.TabIndex = 12;
            this.RadioButtonCipher.TabStop = true;
            this.RadioButtonCipher.Text = "Шифрация";
            this.RadioButtonCipher.UseVisualStyleBackColor = true;
            this.RadioButtonCipher.CheckedChanged += new System.EventHandler(this.RadioButtonCipher_CheckedChanged);
            // 
            // RadioButtonDecipher
            // 
            this.RadioButtonDecipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonDecipher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RadioButtonDecipher.Location = new System.Drawing.Point(19, 414);
            this.RadioButtonDecipher.Name = "RadioButtonDecipher";
            this.RadioButtonDecipher.Size = new System.Drawing.Size(121, 24);
            this.RadioButtonDecipher.TabIndex = 13;
            this.RadioButtonDecipher.Text = "Дешифрация";
            this.RadioButtonDecipher.UseVisualStyleBackColor = true;
            this.RadioButtonDecipher.CheckedChanged += new System.EventHandler(this.RadioButtonDecipher_CheckedChanged);
            // 
            // TextBoxE
            // 
            this.TextBoxE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBoxE.Location = new System.Drawing.Point(806, 185);
            this.TextBoxE.Multiline = true;
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.ReadOnly = true;
            this.TextBoxE.Size = new System.Drawing.Size(222, 28);
            this.TextBoxE.TabIndex = 14;
            // 
            // LabelE
            // 
            this.LabelE.Location = new System.Drawing.Point(639, 190);
            this.LabelE.Name = "LabelE";
            this.LabelE.Size = new System.Drawing.Size(174, 25);
            this.LabelE.TabIndex = 15;
            this.LabelE.Text = "Открытая константа E:";
            // 
            // PlainText
            // 
            this.PlainText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlainText.Location = new System.Drawing.Point(19, 250);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.ReadOnly = true;
            this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainText.Size = new System.Drawing.Size(502, 113);
            this.PlainText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Исходный текст:";
            // 
            // LabelCipher
            // 
            this.LabelCipher.Location = new System.Drawing.Point(542, 228);
            this.LabelCipher.Name = "LabelCipher";
            this.LabelCipher.Size = new System.Drawing.Size(502, 23);
            this.LabelCipher.TabIndex = 18;
            this.LabelCipher.Text = "Зашифрованный текст:";
            // 
            // CipherText
            // 
            this.CipherText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CipherText.Location = new System.Drawing.Point(542, 251);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherText.Size = new System.Drawing.Size(502, 113);
            this.CipherText.TabIndex = 19;
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Silver;
            this.ResultButton.Enabled = false;
            this.ResultButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ResultButton.FlatAppearance.BorderSize = 0;
            this.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ResultButton.Location = new System.Drawing.Point(146, 381);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(898, 57);
            this.ResultButton.TabIndex = 20;
            this.ResultButton.Text = "Зашифровать";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(405, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Введите значения параметров";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1066, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.LabelCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.LabelE);
            this.Controls.Add(this.TextBoxE);
            this.Controls.Add(this.RadioButtonDecipher);
            this.Controls.Add(this.RadioButtonCipher);
            this.Controls.Add(this.TextBoxEuler);
            this.Controls.Add(this.EulerLabel);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.LabelD);
            this.Controls.Add(this.ButtonR);
            this.Controls.Add(this.LabelR);
            this.Controls.Add(this.TextBoxR);
            this.Controls.Add(this.TextBoxQ);
            this.Controls.Add(this.LabelQ);
            this.Controls.Add(this.TextBoxP);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1084, 503);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1084, 503);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теория информации Лабораторная работа №3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;

        private System.Windows.Forms.Button ResultButton;

        private System.Windows.Forms.TextBox PlainText;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCipher;

        private System.Windows.Forms.TextBox CipherText;

        private System.Windows.Forms.Label LabelD;

        private System.Windows.Forms.TextBox TextBoxD;

        private System.Windows.Forms.RadioButton RadioButtonCipher;
        private System.Windows.Forms.RadioButton RadioButtonDecipher;

        private System.Windows.Forms.Label EulerLabel;

        private System.Windows.Forms.TextBox TextBoxE;

        private System.Windows.Forms.Label LabelE;
        private System.Windows.Forms.TextBox TextBoxEuler;

        private System.Windows.Forms.Button ButtonR;

        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFilePlain;
        private System.Windows.Forms.ToolStripMenuItem SaveFileCipher;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFileCipher;
        private System.Windows.Forms.ToolStripMenuItem OpenFilePlain;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.TextBox TextBoxQ;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.Label LabelR;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearStrip;

        #endregion
    }
}