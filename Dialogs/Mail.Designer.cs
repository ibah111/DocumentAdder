
namespace DocumentAdder.Dialogs
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            label1 = new System.Windows.Forms.Label();
            IstCB = new System.Windows.Forms.ComboBox();
            ECPCB = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            AdrTB = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            DateDocMB = new System.Windows.Forms.MaskedTextBox();
            label6 = new System.Windows.Forms.Label();
            MailTB = new System.Windows.Forms.TextBox();
            DoneBtn = new System.Windows.Forms.Button();
            mailModelEnabledBinding = new System.Windows.Forms.BindingSource(components);
            mailModelBinding = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)mailModelEnabledBinding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailModelBinding).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Истец, взыскатель";
            // 
            // IstCB
            // 
            IstCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", mailModelBinding, "Debtor", true));
            IstCB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", mailModelEnabledBinding, "Debtor", true));
            IstCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            IstCB.FormattingEnabled = true;
            IstCB.Items.AddRange(new object[] { "К.С.О.", "Н.С.А.", "ООО Вымпел", "ООО НБК", "Т.И.А." });
            IstCB.Location = new System.Drawing.Point(18, 29);
            IstCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            IstCB.Name = "IstCB";
            IstCB.Size = new System.Drawing.Size(193, 23);
            IstCB.TabIndex = 1;
            // 
            // ECPCB
            // 
            ECPCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", mailModelBinding, "Cert", true));
            ECPCB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", mailModelEnabledBinding, "Cert", true));
            ECPCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ECPCB.FormattingEnabled = true;
            ECPCB.Items.AddRange(new object[] { "К.С.О.", "Н.С.А.", "Н.К.В.", "Т.И.А." });
            ECPCB.Location = new System.Drawing.Point(18, 85);
            ECPCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ECPCB.Name = "ECPCB";
            ECPCB.Size = new System.Drawing.Size(193, 23);
            ECPCB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 67);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "ЭЦП";
            // 
            // AdrTB
            // 
            AdrTB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", mailModelEnabledBinding, "From_mail", true));
            AdrTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", mailModelBinding, "From_mail", true));
            AdrTB.Location = new System.Drawing.Point(251, 29);
            AdrTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AdrTB.Name = "AdrTB";
            AdrTB.Size = new System.Drawing.Size(193, 23);
            AdrTB.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(247, 10);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "Адрес (mail)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 128);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(156, 15);
            label5.TabIndex = 10;
            label5.Text = "Дата вынесения документа";
            // 
            // DateDocMB
            // 
            DateDocMB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", mailModelEnabledBinding, "Court_date", true));
            DateDocMB.DataBindings.Add(new System.Windows.Forms.Binding("Text", mailModelBinding, "Court_date", true));
            DateDocMB.Location = new System.Drawing.Point(18, 147);
            DateDocMB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DateDocMB.Mask = "00/00/0000";
            DateDocMB.Name = "DateDocMB";
            DateDocMB.Size = new System.Drawing.Size(193, 23);
            DateDocMB.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(247, 67);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(156, 15);
            label6.TabIndex = 12;
            label6.Text = "На какой E-Mail поступило";
            // 
            // MailTB
            // 
            MailTB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", mailModelEnabledBinding, "To_mail", true));
            MailTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", mailModelBinding, "To_mail", true));
            MailTB.Location = new System.Drawing.Point(251, 85);
            MailTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MailTB.Name = "MailTB";
            MailTB.Size = new System.Drawing.Size(193, 23);
            MailTB.TabIndex = 4;
            // 
            // DoneBtn
            // 
            DoneBtn.BackColor = System.Drawing.Color.LimeGreen;
            DoneBtn.Location = new System.Drawing.Point(18, 195);
            DoneBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.Size = new System.Drawing.Size(427, 51);
            DoneBtn.TabIndex = 6;
            DoneBtn.Text = "Готово";
            DoneBtn.UseVisualStyleBackColor = false;
            DoneBtn.Click += DoneBtn_Click;
            // 
            // mailModelEnabledBinding
            // 
            mailModelEnabledBinding.DataSource = typeof(Models.MailModelEnabled);
            // 
            // mailModelBinding
            // 
            mailModelBinding.DataSource = typeof(Models.MailModel);
            // 
            // Mail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(463, 250);
            Controls.Add(DoneBtn);
            Controls.Add(label6);
            Controls.Add(MailTB);
            Controls.Add(label5);
            Controls.Add(DateDocMB);
            Controls.Add(label4);
            Controls.Add(AdrTB);
            Controls.Add(ECPCB);
            Controls.Add(label3);
            Controls.Add(IstCB);
            Controls.Add(label1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mail";
            Text = "Занесение";
            ((System.ComponentModel.ISupportInitialize)mailModelEnabledBinding).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailModelBinding).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.BindingSource mailModelEnabledBinding;
        private System.Windows.Forms.BindingSource mailModelBinding;
    }
}