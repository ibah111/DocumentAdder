
namespace DocumentAdder
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.label1 = new System.Windows.Forms.Label();
            this.IstCB = new System.Windows.Forms.ComboBox();
            this.ECPCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdrTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateDocMB = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Истец, взыскатель";
            // 
            // IstCB
            // 
            this.IstCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IstCB.FormattingEnabled = true;
            this.IstCB.Items.AddRange(new object[] {
            "К.С.О.",
            "Н.С.А.",
            "ООО Вымпел",
            "ООО НБК",
            "Т.И.А."});
            this.IstCB.Location = new System.Drawing.Point(15, 25);
            this.IstCB.Name = "IstCB";
            this.IstCB.Size = new System.Drawing.Size(166, 21);
            this.IstCB.TabIndex = 1;
            // 
            // ECPCB
            // 
            this.ECPCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ECPCB.FormattingEnabled = true;
            this.ECPCB.Items.AddRange(new object[] {
            "К.С.О.",
            "Н.С.А.",
            "Н.К.В.",
            "Т.И.А."});
            this.ECPCB.Location = new System.Drawing.Point(15, 74);
            this.ECPCB.Name = "ECPCB";
            this.ECPCB.Size = new System.Drawing.Size(166, 21);
            this.ECPCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ЭЦП";
            // 
            // AdrTB
            // 
            this.AdrTB.Location = new System.Drawing.Point(215, 25);
            this.AdrTB.Name = "AdrTB";
            this.AdrTB.Size = new System.Drawing.Size(166, 20);
            this.AdrTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес (mail)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата вынесения документа";
            // 
            // DateDocMB
            // 
            this.DateDocMB.Location = new System.Drawing.Point(15, 127);
            this.DateDocMB.Mask = "00/00/0000";
            this.DateDocMB.Name = "DateDocMB";
            this.DateDocMB.Size = new System.Drawing.Size(166, 20);
            this.DateDocMB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "На какой E-Mail поступило";
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(215, 74);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(166, 20);
            this.MailTB.TabIndex = 4;
            // 
            // DoneBtn
            // 
            this.DoneBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.DoneBtn.Location = new System.Drawing.Point(15, 169);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(366, 44);
            this.DoneBtn.TabIndex = 6;
            this.DoneBtn.Text = "Готово";
            this.DoneBtn.UseVisualStyleBackColor = false;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 217);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateDocMB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdrTB);
            this.Controls.Add(this.ECPCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IstCB);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mail";
            this.Text = "Занесение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IstCB;
        private System.Windows.Forms.ComboBox ECPCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdrTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DateDocMB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.Button DoneBtn;
    }
}