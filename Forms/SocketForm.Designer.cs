namespace DocumentAdder.Forms
{
    partial class SocketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketForm));
            this.textError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textError
            // 
            this.textError.AutoSize = true;
            this.textError.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.textError.Location = new System.Drawing.Point(22, 21);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(774, 180);
            this.textError.TabIndex = 0;
            this.textError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SocketForm
            // 
            this.ClientSize = new System.Drawing.Size(821, 237);
            this.Controls.Add(this.textError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SocketForm";
            this.Text = "Соединение.....";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label textError;
    }
}