
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocAttach));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rELSERVERPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILESERVERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp2.DataSet1();
            this.dataTable3TableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.DataTable3TableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(723, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1DataGridViewTextBoxColumn,
            this.rELSERVERPATHDataGridViewTextBoxColumn,
            this.fILESERVERNAMEDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dtDataGridViewTextBoxColumn,
            this.name1DataGridViewTextBoxColumn,
            this.dscDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable3BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(855, 519);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // column1DataGridViewTextBoxColumn
            // 
            this.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn";
            this.column1DataGridViewTextBoxColumn.ReadOnly = true;
            this.column1DataGridViewTextBoxColumn.Width = 59;
            // 
            // rELSERVERPATHDataGridViewTextBoxColumn
            // 
            this.rELSERVERPATHDataGridViewTextBoxColumn.DataPropertyName = "REL_SERVER_PATH";
            this.rELSERVERPATHDataGridViewTextBoxColumn.HeaderText = "REL_SERVER_PATH";
            this.rELSERVERPATHDataGridViewTextBoxColumn.Name = "rELSERVERPATHDataGridViewTextBoxColumn";
            this.rELSERVERPATHDataGridViewTextBoxColumn.Visible = false;
            this.rELSERVERPATHDataGridViewTextBoxColumn.Width = 138;
            // 
            // fILESERVERNAMEDataGridViewTextBoxColumn
            // 
            this.fILESERVERNAMEDataGridViewTextBoxColumn.DataPropertyName = "FILE_SERVER_NAME";
            this.fILESERVERNAMEDataGridViewTextBoxColumn.HeaderText = "FILE_SERVER_NAME";
            this.fILESERVERNAMEDataGridViewTextBoxColumn.Name = "fILESERVERNAMEDataGridViewTextBoxColumn";
            this.fILESERVERNAMEDataGridViewTextBoxColumn.Visible = false;
            this.fILESERVERNAMEDataGridViewTextBoxColumn.Width = 141;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Вложение";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nameDataGridViewTextBoxColumn.Width = 83;
            // 
            // dtDataGridViewTextBoxColumn
            // 
            this.dtDataGridViewTextBoxColumn.DataPropertyName = "dt";
            this.dtDataGridViewTextBoxColumn.HeaderText = "Дата записи";
            this.dtDataGridViewTextBoxColumn.Name = "dtDataGridViewTextBoxColumn";
            this.dtDataGridViewTextBoxColumn.Width = 97;
            // 
            // name1DataGridViewTextBoxColumn
            // 
            this.name1DataGridViewTextBoxColumn.DataPropertyName = "name1";
            this.name1DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.name1DataGridViewTextBoxColumn.Name = "name1DataGridViewTextBoxColumn";
            this.name1DataGridViewTextBoxColumn.Width = 51;
            // 
            // dscDataGridViewTextBoxColumn
            // 
            this.dscDataGridViewTextBoxColumn.DataPropertyName = "dsc";
            this.dscDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.dscDataGridViewTextBoxColumn.Name = "dscDataGridViewTextBoxColumn";
            this.dscDataGridViewTextBoxColumn.Width = 102;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // DocAttach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocAttach";
            this.Text = "Вложения";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private DataSet1TableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rELSERVERPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fILESERVERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscDataGridViewTextBoxColumn;
    }
}