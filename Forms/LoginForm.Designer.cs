namespace WindowsFormsApp2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.NotLoged = new System.Windows.Forms.Label();
            this.Loged = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotLoged
            // 
            this.NotLoged.AutoSize = true;
            this.NotLoged.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotLoged.Location = new System.Drawing.Point(59, 22);
            this.NotLoged.Name = "NotLoged";
            this.NotLoged.Size = new System.Drawing.Size(476, 42);
            this.NotLoged.TabIndex = 0;
            this.NotLoged.Text = "Авторизация не пройдена";
            // 
            // Loged
            // 
            this.Loged.AutoSize = true;
            this.Loged.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loged.Location = new System.Drawing.Point(148, 22);
            this.Loged.Name = "Loged";
            this.Loged.Size = new System.Drawing.Size(330, 42);
            this.Loged.TabIndex = 1;
            this.Loged.Text = "Вы авторизованы";
            this.Loged.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(220, 79);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(141, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 140);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Loged);
            this.Controls.Add(this.NotLoged);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotLoged;
        private System.Windows.Forms.Label Loged;
        private System.Windows.Forms.Button LoginButton;
    }
}