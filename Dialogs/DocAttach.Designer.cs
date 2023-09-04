
namespace DocumentAdder.Dialogs
{
    partial class DocAttach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocAttach));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            docAttachBindingSource = new System.Windows.Forms.BindingSource(components);
            DocAttachId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DocAttachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DocAttachIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            DocAttachRUserId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            DocAttachAttachTyp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            DocAttachDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)docAttachBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1004, 644);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Right;
            button1.Location = new System.Drawing.Point(842, 609);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(158, 32);
            button1.TabIndex = 2;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DocAttachId, DocAttachName, DocAttachIsActive, DocAttachRUserId, DocAttachAttachTyp, DocAttachDt });
            dataGridView1.DataSource = docAttachBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.Location = new System.Drawing.Point(4, 3);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new System.Drawing.Size(996, 600);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // docAttachBindingSource
            // 
            docAttachBindingSource.DataSource = typeof(DatabaseContact.Models.DocAttach);
            // 
            // DocAttachId
            // 
            DocAttachId.DataPropertyName = "id";
            DocAttachId.HeaderText = "ID";
            DocAttachId.Name = "DocAttachId";
            DocAttachId.ReadOnly = true;
            DocAttachId.Width = 43;
            // 
            // DocAttachName
            // 
            DocAttachName.DataPropertyName = "name";
            DocAttachName.HeaderText = "Название файла";
            DocAttachName.Name = "DocAttachName";
            DocAttachName.ReadOnly = true;
            DocAttachName.Width = 112;
            // 
            // DocAttachIsActive
            // 
            DocAttachIsActive.DataPropertyName = "is_active";
            DocAttachIsActive.HeaderText = "Активный";
            DocAttachIsActive.Name = "DocAttachIsActive";
            DocAttachIsActive.ReadOnly = true;
            DocAttachIsActive.Width = 68;
            // 
            // DocAttachRUserId
            // 
            DocAttachRUserId.DataPropertyName = "r_user_id";
            DocAttachRUserId.HeaderText = "Пользователь";
            DocAttachRUserId.Name = "DocAttachRUserId";
            DocAttachRUserId.ReadOnly = true;
            DocAttachRUserId.Width = 90;
            // 
            // DocAttachAttachTyp
            // 
            DocAttachAttachTyp.DataPropertyName = "attach_typ";
            DocAttachAttachTyp.HeaderText = "Тип вложения";
            DocAttachAttachTyp.Name = "DocAttachAttachTyp";
            DocAttachAttachTyp.ReadOnly = true;
            DocAttachAttachTyp.Width = 82;
            // 
            // DocAttachDt
            // 
            DocAttachDt.DataPropertyName = "dt";
            DocAttachDt.HeaderText = "Дата";
            DocAttachDt.Name = "DocAttachDt";
            DocAttachDt.ReadOnly = true;
            DocAttachDt.Width = 57;
            // 
            // DocAttach
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1004, 644);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "DocAttach";
            Text = "Информация";
            Load += Form3_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)docAttachBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource docAttachBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocAttachId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocAttachName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DocAttachIsActive;
        private System.Windows.Forms.DataGridViewComboBoxColumn DocAttachRUserId;
        private System.Windows.Forms.DataGridViewComboBoxColumn DocAttachAttachTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocAttachDt;
    }
}