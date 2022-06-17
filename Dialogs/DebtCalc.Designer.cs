
namespace DocumentAdder
{
    partial class DebtCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtCalc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isconfirmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtcalcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DocumentAdder.DataSet1();
            this.debt_calcTableAdapter = new DocumentAdder.DataSet1TableAdapters.debt_calcTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtcalcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.sumDataGridViewTextBoxColumn,
            this.calcdateDataGridViewTextBoxColumn,
            this.dtDataGridViewTextBoxColumn,
            this.reportdateDataGridViewTextBoxColumn,
            this.isconfirmedDataGridViewTextBoxColumn,
            this.dscDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.debtcalcBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(604, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма в рублях";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.Width = 103;
            // 
            // calcdateDataGridViewTextBoxColumn
            // 
            this.calcdateDataGridViewTextBoxColumn.DataPropertyName = "calc_date";
            this.calcdateDataGridViewTextBoxColumn.HeaderText = "Дата платежа";
            this.calcdateDataGridViewTextBoxColumn.Name = "calcdateDataGridViewTextBoxColumn";
            this.calcdateDataGridViewTextBoxColumn.Width = 96;
            // 
            // dtDataGridViewTextBoxColumn
            // 
            this.dtDataGridViewTextBoxColumn.DataPropertyName = "dt";
            this.dtDataGridViewTextBoxColumn.HeaderText = "Дата учета";
            this.dtDataGridViewTextBoxColumn.Name = "dtDataGridViewTextBoxColumn";
            this.dtDataGridViewTextBoxColumn.Width = 81;
            // 
            // reportdateDataGridViewTextBoxColumn
            // 
            this.reportdateDataGridViewTextBoxColumn.DataPropertyName = "report_date";
            this.reportdateDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.reportdateDataGridViewTextBoxColumn.Name = "reportdateDataGridViewTextBoxColumn";
            this.reportdateDataGridViewTextBoxColumn.Width = 115;
            // 
            // isconfirmedDataGridViewTextBoxColumn
            // 
            this.isconfirmedDataGridViewTextBoxColumn.DataPropertyName = "is_confirmed";
            this.isconfirmedDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.isconfirmedDataGridViewTextBoxColumn.Name = "isconfirmedDataGridViewTextBoxColumn";
            this.isconfirmedDataGridViewTextBoxColumn.Width = 66;
            // 
            // dscDataGridViewTextBoxColumn
            // 
            this.dscDataGridViewTextBoxColumn.DataPropertyName = "dsc";
            this.dscDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.dscDataGridViewTextBoxColumn.Name = "dscDataGridViewTextBoxColumn";
            this.dscDataGridViewTextBoxColumn.Width = 102;
            // 
            // debtcalcBindingSource
            // 
            this.debtcalcBindingSource.DataMember = "debt_calc";
            this.debtcalcBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debt_calcTableAdapter
            // 
            this.debt_calcTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 270);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(532, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 270);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Платежи";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtcalcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource debtcalcBindingSource;
        private DataSet1TableAdapters.debt_calcTableAdapter debt_calcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isconfirmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}