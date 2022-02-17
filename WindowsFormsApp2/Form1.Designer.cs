namespace WindowsFormsApp2
{
    partial class Form1
    {
        private class User
        {
            public int ID { get; set; }
            public string NAME { get; set; }
        }
        

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Users = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiovzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp2.DataSet1();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiovzDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsspdocnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courtdocnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.DataTable1TableAdapter();
            this.dataTable2TableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label17, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label18, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox4, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label22, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox7, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox8, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label24, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox10, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox11, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 4, 15);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 20);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 20);
            this.tableLayoutPanel1.Controls.Add(this.label31, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 15);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 16);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 17);
            this.tableLayoutPanel1.Controls.Add(this.label27, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.comboBox7, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.label34, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.comboBox8, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label35, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.comboBox6, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.comboBox5, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.label32, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.label33, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.comboBox9, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.label36, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 5, 13);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 6, 13);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 7, 13);
            this.tableLayoutPanel1.Controls.Add(this.label30, 4, 14);
            this.tableLayoutPanel1.Controls.Add(this.label29, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.button9, 3, 18);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 3, 19);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 4, 13);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 21;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "\r\nТип документа\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox1, 4);
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(618, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "\r\nФамилия\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "\r\nИмя\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(939, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "\r\nОтчество\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(627, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(783, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(939, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "\r\n№ КД\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "\r\n№ Дела";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "\r\n№ ИП";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "\r\n№ Испол. документа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(627, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "\r\nID Дела";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(783, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 26);
            this.label12.TabIndex = 15;
            this.label12.Text = "\r\n№ КД";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(939, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 26);
            this.label13.TabIndex = 16;
            this.label13.Text = "\r\n№ Дела";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 26);
            this.label14.TabIndex = 24;
            this.label14.Text = "\r\nДата вынесения решения";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(159, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 26);
            this.label15.TabIndex = 25;
            this.label15.Text = "\r\nДата вступления в силу";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 26);
            this.label16.TabIndex = 26;
            this.label16.Text = "\r\nДата возбуждения";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(471, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 26);
            this.label17.TabIndex = 27;
            this.label17.Text = "\r\nДата пост об окончании ИП";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label18, 2);
            this.label18.Location = new System.Drawing.Point(627, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(230, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Приказ, иск, правопреемство, банкротство";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox2.Location = new System.Drawing.Point(159, 149);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox2.TabIndex = 12;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox3.Location = new System.Drawing.Point(315, 149);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox3.TabIndex = 13;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox3.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox4.Location = new System.Drawing.Point(471, 149);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox4.TabIndex = 14;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox4.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.fiovzDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.name1DataGridViewTextBoxColumn,
            this.column1DataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.execnumberDataGridViewTextBoxColumn,
            this.name2DataGridViewTextBoxColumn,
            this.column2DataGridViewTextBoxColumn,
            this.dscDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(627, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 7);
            this.dataGridView1.Size = new System.Drawing.Size(621, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Дела";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 68;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Вкладка";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.ReadOnly = true;
            this.typDataGridViewTextBoxColumn.Width = 75;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 66;
            // 
            // fiovzDataGridViewTextBoxColumn
            // 
            this.fiovzDataGridViewTextBoxColumn.DataPropertyName = "fio_vz";
            this.fiovzDataGridViewTextBoxColumn.HeaderText = "ФИО взыскателя";
            this.fiovzDataGridViewTextBoxColumn.Name = "fiovzDataGridViewTextBoxColumn";
            this.fiovzDataGridViewTextBoxColumn.ReadOnly = true;
            this.fiovzDataGridViewTextBoxColumn.Width = 113;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // name1DataGridViewTextBoxColumn
            // 
            this.name1DataGridViewTextBoxColumn.DataPropertyName = "name1";
            this.name1DataGridViewTextBoxColumn.HeaderText = "Портфель";
            this.name1DataGridViewTextBoxColumn.Name = "name1DataGridViewTextBoxColumn";
            this.name1DataGridViewTextBoxColumn.Width = 83;
            // 
            // column1DataGridViewTextBoxColumn
            // 
            this.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn";
            this.column1DataGridViewTextBoxColumn.ReadOnly = true;
            this.column1DataGridViewTextBoxColumn.Width = 59;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birth_date";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.Width = 102;
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "№ КД";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            this.contractDataGridViewTextBoxColumn.Width = 58;
            // 
            // execnumberDataGridViewTextBoxColumn
            // 
            this.execnumberDataGridViewTextBoxColumn.DataPropertyName = "exec_number";
            this.execnumberDataGridViewTextBoxColumn.HeaderText = "№ Дела";
            this.execnumberDataGridViewTextBoxColumn.Name = "execnumberDataGridViewTextBoxColumn";
            this.execnumberDataGridViewTextBoxColumn.Width = 68;
            // 
            // name2DataGridViewTextBoxColumn
            // 
            this.name2DataGridViewTextBoxColumn.DataPropertyName = "name2";
            this.name2DataGridViewTextBoxColumn.HeaderText = "Название суда";
            this.name2DataGridViewTextBoxColumn.Name = "name2DataGridViewTextBoxColumn";
            this.name2DataGridViewTextBoxColumn.Width = 99;
            // 
            // column2DataGridViewTextBoxColumn
            // 
            this.column2DataGridViewTextBoxColumn.DataPropertyName = "Column2";
            this.column2DataGridViewTextBoxColumn.HeaderText = "Размер требования";
            this.column2DataGridViewTextBoxColumn.Name = "column2DataGridViewTextBoxColumn";
            this.column2DataGridViewTextBoxColumn.ReadOnly = true;
            this.column2DataGridViewTextBoxColumn.Width = 122;
            // 
            // dscDataGridViewTextBoxColumn
            // 
            this.dscDataGridViewTextBoxColumn.DataPropertyName = "dsc";
            this.dscDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.dscDataGridViewTextBoxColumn.Name = "dscDataGridViewTextBoxColumn";
            this.dscDataGridViewTextBoxColumn.Width = 102;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 26);
            this.label19.TabIndex = 34;
            this.label19.Text = "\r\nДата получения агентством";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 26);
            this.label20.TabIndex = 35;
            this.label20.Text = "\r\nДата возврата";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(315, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 26);
            this.label21.TabIndex = 36;
            this.label21.Text = "\r\nДата ограничения выезда";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(471, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(150, 26);
            this.label22.TabIndex = 37;
            this.label22.Text = "\r\nДата отказа в возбуждении";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox5.Location = new System.Drawing.Point(3, 201);
            this.maskedTextBox5.Mask = "00/00/0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox5.TabIndex = 15;
            this.maskedTextBox5.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox5.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox6.Location = new System.Drawing.Point(159, 201);
            this.maskedTextBox6.Mask = "00/00/0000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox6.TabIndex = 16;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox6.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox7.Location = new System.Drawing.Point(315, 201);
            this.maskedTextBox7.Mask = "00/00/0000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox7.TabIndex = 17;
            this.maskedTextBox7.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox7.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox8.Location = new System.Drawing.Point(471, 201);
            this.maskedTextBox8.Mask = "00/00/0000";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox8.TabIndex = 18;
            this.maskedTextBox8.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox8.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 26);
            this.label23.TabIndex = 42;
            this.label23.Text = "\r\nДата отмены СП";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(159, 224);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 39);
            this.label24.TabIndex = 43;
            this.label24.Text = "\r\nДата исполнения недостатков";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(315, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 26);
            this.label25.TabIndex = 44;
            this.label25.Text = "\r\nДата и время СЗ";
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox9.Location = new System.Drawing.Point(3, 266);
            this.maskedTextBox9.Mask = "00/00/0000";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox9.TabIndex = 19;
            this.maskedTextBox9.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox9.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox10.Location = new System.Drawing.Point(159, 266);
            this.maskedTextBox10.Mask = "00/00/0000";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox10.TabIndex = 20;
            this.maskedTextBox10.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox10.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox11.Location = new System.Drawing.Point(315, 266);
            this.maskedTextBox11.Mask = "00/00/0000 90:00";
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox11.TabIndex = 21;
            this.maskedTextBox11.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox11.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.debtstatusDataGridViewTextBoxColumn,
            this.fiovzDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.column1DataGridViewTextBoxColumn1,
            this.birthdateDataGridViewTextBoxColumn1,
            this.contractDataGridViewTextBoxColumn1,
            this.fsspdocnumDataGridViewTextBoxColumn,
            this.courtdocnumDataGridViewTextBoxColumn,
            this.name1DataGridViewTextBoxColumn1,
            this.column2DataGridViewTextBoxColumn1,
            this.name2DataGridViewTextBoxColumn1,
            this.execnumberDataGridViewTextBoxColumn1,
            this.dscDataGridViewTextBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView2, 4);
            this.dataGridView2.DataSource = this.dataTable2BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(627, 428);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView2, 6);
            this.dataGridView2.Size = new System.Drawing.Size(621, 318);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID Дела";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 68;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Width = 66;
            // 
            // debtstatusDataGridViewTextBoxColumn
            // 
            this.debtstatusDataGridViewTextBoxColumn.DataPropertyName = "Debt_status";
            this.debtstatusDataGridViewTextBoxColumn.HeaderText = "Статус долга";
            this.debtstatusDataGridViewTextBoxColumn.Name = "debtstatusDataGridViewTextBoxColumn";
            this.debtstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.debtstatusDataGridViewTextBoxColumn.Width = 90;
            // 
            // fiovzDataGridViewTextBoxColumn1
            // 
            this.fiovzDataGridViewTextBoxColumn1.DataPropertyName = "fio_vz";
            this.fiovzDataGridViewTextBoxColumn1.HeaderText = "ФИО взыскателя";
            this.fiovzDataGridViewTextBoxColumn1.Name = "fiovzDataGridViewTextBoxColumn1";
            this.fiovzDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fiovzDataGridViewTextBoxColumn1.Width = 113;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Портфель";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 83;
            // 
            // column1DataGridViewTextBoxColumn1
            // 
            this.column1DataGridViewTextBoxColumn1.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.column1DataGridViewTextBoxColumn1.Name = "column1DataGridViewTextBoxColumn1";
            this.column1DataGridViewTextBoxColumn1.ReadOnly = true;
            this.column1DataGridViewTextBoxColumn1.Width = 59;
            // 
            // birthdateDataGridViewTextBoxColumn1
            // 
            this.birthdateDataGridViewTextBoxColumn1.DataPropertyName = "birth_date";
            this.birthdateDataGridViewTextBoxColumn1.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn1.Name = "birthdateDataGridViewTextBoxColumn1";
            this.birthdateDataGridViewTextBoxColumn1.Width = 102;
            // 
            // contractDataGridViewTextBoxColumn1
            // 
            this.contractDataGridViewTextBoxColumn1.DataPropertyName = "contract";
            this.contractDataGridViewTextBoxColumn1.HeaderText = "№ КД";
            this.contractDataGridViewTextBoxColumn1.Name = "contractDataGridViewTextBoxColumn1";
            this.contractDataGridViewTextBoxColumn1.Width = 58;
            // 
            // fsspdocnumDataGridViewTextBoxColumn
            // 
            this.fsspdocnumDataGridViewTextBoxColumn.DataPropertyName = "fssp_doc_num";
            this.fsspdocnumDataGridViewTextBoxColumn.HeaderText = "№ ИП";
            this.fsspdocnumDataGridViewTextBoxColumn.Name = "fsspdocnumDataGridViewTextBoxColumn";
            this.fsspdocnumDataGridViewTextBoxColumn.Width = 58;
            // 
            // courtdocnumDataGridViewTextBoxColumn
            // 
            this.courtdocnumDataGridViewTextBoxColumn.DataPropertyName = "court_doc_num";
            this.courtdocnumDataGridViewTextBoxColumn.HeaderText = "№ ИД";
            this.courtdocnumDataGridViewTextBoxColumn.Name = "courtdocnumDataGridViewTextBoxColumn";
            this.courtdocnumDataGridViewTextBoxColumn.Width = 59;
            // 
            // name1DataGridViewTextBoxColumn1
            // 
            this.name1DataGridViewTextBoxColumn1.DataPropertyName = "name1";
            this.name1DataGridViewTextBoxColumn1.HeaderText = "ФССП";
            this.name1DataGridViewTextBoxColumn1.Name = "name1DataGridViewTextBoxColumn1";
            this.name1DataGridViewTextBoxColumn1.Width = 65;
            // 
            // column2DataGridViewTextBoxColumn1
            // 
            this.column2DataGridViewTextBoxColumn1.DataPropertyName = "Column2";
            this.column2DataGridViewTextBoxColumn1.HeaderText = "Размер требования";
            this.column2DataGridViewTextBoxColumn1.Name = "column2DataGridViewTextBoxColumn1";
            this.column2DataGridViewTextBoxColumn1.ReadOnly = true;
            this.column2DataGridViewTextBoxColumn1.Width = 122;
            // 
            // name2DataGridViewTextBoxColumn1
            // 
            this.name2DataGridViewTextBoxColumn1.DataPropertyName = "name2";
            this.name2DataGridViewTextBoxColumn1.HeaderText = "Название суда";
            this.name2DataGridViewTextBoxColumn1.Name = "name2DataGridViewTextBoxColumn1";
            this.name2DataGridViewTextBoxColumn1.Width = 99;
            // 
            // execnumberDataGridViewTextBoxColumn1
            // 
            this.execnumberDataGridViewTextBoxColumn1.DataPropertyName = "exec_number";
            this.execnumberDataGridViewTextBoxColumn1.HeaderText = "Номер дела в суде";
            this.execnumberDataGridViewTextBoxColumn1.Name = "execnumberDataGridViewTextBoxColumn1";
            this.execnumberDataGridViewTextBoxColumn1.Width = 96;
            // 
            // dscDataGridViewTextBoxColumn1
            // 
            this.dscDataGridViewTextBoxColumn1.DataPropertyName = "dsc";
            this.dscDataGridViewTextBoxColumn1.HeaderText = "Комментарий";
            this.dscDataGridViewTextBoxColumn1.Name = "dscDataGridViewTextBoxColumn1";
            this.dscDataGridViewTextBoxColumn1.Width = 102;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dataSet1;
            // 
            // textBox11
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox11, 2);
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Location = new System.Drawing.Point(3, 488);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.tableLayoutPanel1.SetRowSpan(this.textBox11, 2);
            this.textBox11.Size = new System.Drawing.Size(306, 54);
            this.textBox11.TabIndex = 22;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.textBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox12
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox12, 2);
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Location = new System.Drawing.Point(3, 548);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.textBox12, 2);
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox12.Size = new System.Drawing.Size(306, 198);
            this.textBox12.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.add_file;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(315, 428);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 5);
            this.panel1.Size = new System.Drawing.Size(150, 144);
            this.panel1.TabIndex = 58;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(471, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 168);
            this.button2.TabIndex = 60;
            this.button2.Text = "Готово!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(315, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 168);
            this.button3.TabIndex = 61;
            this.button3.Text = "Посмотреть вложения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1095, 13);
            this.label31.Name = "label31";
            this.tableLayoutPanel1.SetRowSpan(this.label31, 5);
            this.label31.Size = new System.Drawing.Size(143, 130);
            this.label31.TabIndex = 62;
            this.label31.Text = "\r\nГорячие клавиши:\r\n\r\nEnter -> Поиск\r\nCtrl + D -> Очистить панель\r\nCtrl + Q -> Уд" +
    "алить файлы\r\nCtrl + Shift + D -> Очистить все\r\nPageDown -> Перенести в конец стр" +
    "оки";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(939, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(783, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(627, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 95);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 20);
            this.textBox7.TabIndex = 7;
            this.textBox7.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.textBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(159, 95);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 22);
            this.textBox8.TabIndex = 8;
            this.textBox8.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Location = new System.Drawing.Point(471, 95);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(150, 20);
            this.textBox10.TabIndex = 10;
            this.textBox10.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.textBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 149);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(315, 95);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 20);
            this.textBox9.TabIndex = 9;
            this.textBox9.EnabledChanged += new System.EventHandler(this.maskedTextBox8_EnabledChanged);
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(471, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Платежи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(471, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 23);
            this.button4.TabIndex = 63;
            this.button4.Text = "Протокол";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(471, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 24);
            this.button5.TabIndex = 64;
            this.button5.Text = "Создать банкротство";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(471, 224);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 26);
            this.label27.TabIndex = 49;
            this.label27.Text = "\r\nСтатус";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(471, 266);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox7.DataSource = this.Users;
            this.comboBox7.DisplayMember = "NAME";
            this.comboBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox7.Location = new System.Drawing.Point(471, 333);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(150, 21);
            this.comboBox7.TabIndex = 69;
            this.comboBox7.ValueMember = "ID";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label34.Location = new System.Drawing.Point(471, 317);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(150, 13);
            this.label34.TabIndex = 74;
            this.label34.Text = "Исполнитель задачи";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label26.Location = new System.Drawing.Point(3, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(150, 13);
            this.label26.TabIndex = 71;
            this.label26.Text = "Дата поступления";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 455);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(129, 26);
            this.label28.TabIndex = 52;
            this.label28.Text = "\r\nДобавить комментарий";
            // 
            // comboBox8
            // 
            this.comboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(3, 398);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(150, 21);
            this.comboBox8.TabIndex = 84;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label35.Location = new System.Drawing.Point(3, 382);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(150, 13);
            this.label35.TabIndex = 86;
            this.label35.Text = "Адрес отправителя";
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 428);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 24);
            this.button7.TabIndex = 88;
            this.button7.Text = "Добавить в список";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "П.3,СТ.46",
            "П.4,СТ.46",
            "П.1,СТ.46",
            "П.3,СТ.46,П.4,СТ.46",
            "П.6,СТ.46",
            "П.1,СТ.47",
            "П.7,СТ.47",
            "П.4,СТ.47",
            "П.1,СТ.45",
            "П.5,СТ.46",
            "П.2,СТ.46"});
            this.comboBox6.Location = new System.Drawing.Point(159, 333);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(150, 21);
            this.comboBox6.TabIndex = 68;
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "213123212"});
            this.comboBox5.Location = new System.Drawing.Point(315, 333);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(150, 21);
            this.comboBox5.TabIndex = 67;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label32.Location = new System.Drawing.Point(315, 317);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(150, 13);
            this.label32.TabIndex = 72;
            this.label32.Text = "Название документа";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label33.Location = new System.Drawing.Point(159, 317);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(150, 13);
            this.label33.TabIndex = 73;
            this.label33.Text = "Статья и пункт";
            // 
            // comboBox9
            // 
            this.comboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(159, 398);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(150, 21);
            this.comboBox9.TabIndex = 85;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(159, 428);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 24);
            this.button8.TabIndex = 89;
            this.button8.Text = "Добавить в список";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label36.Location = new System.Drawing.Point(159, 382);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(150, 13);
            this.label36.TabIndex = 87;
            this.label36.Text = "Отправитель";
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(315, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 29);
            this.button6.TabIndex = 82;
            this.button6.Text = "Добавить в список";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(783, 363);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(143, 20);
            this.textBox14.TabIndex = 78;
            this.textBox14.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Приказ",
            "Иск",
            "Правопреемство",
            "Банкротство",
            "Испол. пр-во"});
            this.comboBox2.Location = new System.Drawing.Point(939, 363);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1095, 363);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(143, 20);
            this.textBox15.TabIndex = 80;
            this.textBox15.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(627, 395);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(116, 26);
            this.label30.TabIndex = 54;
            this.label30.Text = "\r\nИспол. производство";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(315, 395);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 26);
            this.label29.TabIndex = 53;
            this.label29.Text = "\r\nДобавить файл";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 90;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 10, 9, 2, 41, 0);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(471, 518);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 24);
            this.button9.TabIndex = 92;
            this.button9.Text = "Другие документы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(471, 548);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 17);
            this.checkBox3.TabIndex = 94;
            this.checkBox3.Text = "Постановка задачи";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(471, 398);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 24);
            this.tableLayoutPanel2.TabIndex = 96;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 70;
            this.checkBox1.Text = "Учёт конвертов\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(78, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(69, 17);
            this.checkBox4.TabIndex = 95;
            this.checkBox4.Text = "Приставы";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(627, 363);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 91;
            this.checkBox2.Text = "Сканы";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button10, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(471, 363);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(150, 29);
            this.tableLayoutPanel3.TabIndex = 97;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(69, 21);
            this.comboBox4.TabIndex = 92;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(78, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 23);
            this.button10.TabIndex = 93;
            this.button10.Text = "Открыть";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 630);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox9;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiovzDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsspdocnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courtdocnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn execnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiovzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn execnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.BindingSource Users;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button10;
    }
}

