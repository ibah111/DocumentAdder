using DocumentAdder.Models;
using DocumentAdder.Utils;

namespace DocumentAdder.Forms
{
    partial class MainForm
    {


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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Users = new System.Windows.Forms.BindingSource(components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            typDocBox = new System.Windows.Forms.ComboBox();
            dataModelBinding = new System.Windows.Forms.BindingSource(components);
            typDocBinding = new System.Windows.Forms.BindingSource(components);
            textBoxF = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            LawActDataGridLabel = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            LawActId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActTyp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dictTyp = new System.Windows.Forms.BindingSource(components);
            LawActStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActFIoVz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActPortfolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActExecNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActCourtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActTotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActCourtAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActStartSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActBirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActFullAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActExecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawActInn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lawActResultBindingSource = new System.Windows.Forms.BindingSource(components);
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            receiptDateBox = new System.Windows.Forms.MaskedTextBox();
            returnDateBox = new System.Windows.Forms.MaskedTextBox();
            restrictionToLeaveDtBox = new System.Windows.Forms.MaskedTextBox();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            cancelDateBox = new System.Windows.Forms.MaskedTextBox();
            correctPeriodDateBox = new System.Windows.Forms.MaskedTextBox();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            LawExecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dictState = new System.Windows.Forms.BindingSource(components);
            LawExecDebtStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dictDebtStatus = new System.Windows.Forms.BindingSource(components);
            LawExecFioVz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecPortfolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecFsspDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecCourtDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecTotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecFsspName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecFsspAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecExecNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecFullAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecStartSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecInn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecExecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LawExecBirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lawExecResultBindingSource = new System.Windows.Forms.BindingSource(components);
            textBox11 = new System.Windows.Forms.TextBox();
            textBox12 = new System.Windows.Forms.TextBox();
            label31 = new System.Windows.Forms.Label();
            execNumberSearchBox = new System.Windows.Forms.TextBox();
            contractBox = new System.Windows.Forms.TextBox();
            idBox = new System.Windows.Forms.TextBox();
            execNumberBox = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            label26 = new System.Windows.Forms.Label();
            postNameBox = new System.Windows.Forms.ComboBox();
            label35 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            articleAndParagraphBox = new System.Windows.Forms.ComboBox();
            label33 = new System.Windows.Forms.Label();
            postAddressBox = new System.Windows.Forms.ComboBox();
            button8 = new System.Windows.Forms.Button();
            label36 = new System.Windows.Forms.Label();
            datePostBox = new System.Windows.Forms.DateTimePicker();
            button9 = new System.Windows.Forms.Button();
            checkBox3 = new System.Windows.Forms.CheckBox();
            label30 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBoxI = new System.Windows.Forms.TextBox();
            textBoxO = new System.Windows.Forms.TextBox();
            label28 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            CourtExecDateBox = new System.Windows.Forms.MaskedTextBox();
            courtDocNumBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            courtOrderDateBox = new System.Windows.Forms.MaskedTextBox();
            fsspDocNumBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            startDateBox = new System.Windows.Forms.MaskedTextBox();
            label17 = new System.Windows.Forms.Label();
            finishDateBox = new System.Windows.Forms.MaskedTextBox();
            label22 = new System.Windows.Forms.Label();
            rejectDateBox = new System.Windows.Forms.MaskedTextBox();
            label25 = new System.Windows.Forms.Label();
            sessionDateBox = new System.Windows.Forms.MaskedTextBox();
            label45 = new System.Windows.Forms.Label();
            ModeCB = new System.Windows.Forms.ComboBox();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            selectDocBarcode = new System.Windows.Forms.ComboBox();
            documentsBindingSource = new System.Windows.Forms.BindingSource(components);
            labelSelectDocBarcode = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            documentNameBox = new System.Windows.Forms.ComboBox();
            button6 = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            comboBox4 = new System.Windows.Forms.ComboBox();
            button10 = new System.Windows.Forms.Button();
            userTaskBox = new System.Windows.Forms.ComboBox();
            label34 = new System.Windows.Forms.Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            clearStatus = new System.Windows.Forms.Button();
            statusBox = new System.Windows.Forms.ComboBox();
            dictStatus = new System.Windows.Forms.BindingSource(components);
            label27 = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            checkBox4 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            gridFiles = new System.Windows.Forms.DataGridView();
            NeedBarcode = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            typDocumentsBindingSource = new System.Windows.Forms.BindingSource(components);
            haveKD = new System.Windows.Forms.CheckBox();
            ScanCopyKD = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)Users).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataModelBinding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typDocBinding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dictTyp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lawActResultBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dictState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dictDebtStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lawExecResultBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentsBindingSource).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dictStatus).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typDocumentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentEnableds).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(typDocBox, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxF, 4, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(label11, 4, 3);
            tableLayoutPanel1.Controls.Add(label12, 5, 3);
            tableLayoutPanel1.Controls.Add(label13, 6, 3);
            tableLayoutPanel1.Controls.Add(button2, 3, 24);
            tableLayoutPanel1.Controls.Add(LawActDataGridLabel, 4, 5);
            tableLayoutPanel1.Controls.Add(dataGridView1, 4, 6);
            tableLayoutPanel1.Controls.Add(label19, 0, 7);
            tableLayoutPanel1.Controls.Add(label20, 1, 7);
            tableLayoutPanel1.Controls.Add(label21, 2, 7);
            tableLayoutPanel1.Controls.Add(receiptDateBox, 0, 8);
            tableLayoutPanel1.Controls.Add(returnDateBox, 1, 8);
            tableLayoutPanel1.Controls.Add(restrictionToLeaveDtBox, 2, 8);
            tableLayoutPanel1.Controls.Add(label23, 0, 9);
            tableLayoutPanel1.Controls.Add(label24, 1, 9);
            tableLayoutPanel1.Controls.Add(cancelDateBox, 0, 10);
            tableLayoutPanel1.Controls.Add(correctPeriodDateBox, 1, 10);
            tableLayoutPanel1.Controls.Add(dataGridView2, 4, 19);
            tableLayoutPanel1.Controls.Add(textBox11, 0, 19);
            tableLayoutPanel1.Controls.Add(textBox12, 0, 22);
            tableLayoutPanel1.Controls.Add(label31, 7, 1);
            tableLayoutPanel1.Controls.Add(execNumberSearchBox, 6, 4);
            tableLayoutPanel1.Controls.Add(contractBox, 5, 4);
            tableLayoutPanel1.Controls.Add(idBox, 4, 4);
            tableLayoutPanel1.Controls.Add(execNumberBox, 0, 4);
            tableLayoutPanel1.Controls.Add(button1, 3, 22);
            tableLayoutPanel1.Controls.Add(button4, 2, 22);
            tableLayoutPanel1.Controls.Add(button5, 2, 23);
            tableLayoutPanel1.Controls.Add(label26, 0, 11);
            tableLayoutPanel1.Controls.Add(postNameBox, 0, 14);
            tableLayoutPanel1.Controls.Add(label35, 0, 13);
            tableLayoutPanel1.Controls.Add(button7, 0, 15);
            tableLayoutPanel1.Controls.Add(articleAndParagraphBox, 1, 12);
            tableLayoutPanel1.Controls.Add(label33, 1, 11);
            tableLayoutPanel1.Controls.Add(postAddressBox, 1, 14);
            tableLayoutPanel1.Controls.Add(button8, 1, 15);
            tableLayoutPanel1.Controls.Add(label36, 1, 13);
            tableLayoutPanel1.Controls.Add(datePostBox, 0, 12);
            tableLayoutPanel1.Controls.Add(button9, 2, 24);
            tableLayoutPanel1.Controls.Add(checkBox3, 3, 23);
            tableLayoutPanel1.Controls.Add(label30, 4, 18);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(label5, 5, 1);
            tableLayoutPanel1.Controls.Add(label6, 6, 1);
            tableLayoutPanel1.Controls.Add(textBoxI, 5, 2);
            tableLayoutPanel1.Controls.Add(textBoxO, 6, 2);
            tableLayoutPanel1.Controls.Add(label28, 0, 18);
            tableLayoutPanel1.Controls.Add(label29, 2, 18);
            tableLayoutPanel1.Controls.Add(label15, 1, 3);
            tableLayoutPanel1.Controls.Add(CourtExecDateBox, 1, 4);
            tableLayoutPanel1.Controls.Add(courtDocNumBox, 2, 4);
            tableLayoutPanel1.Controls.Add(label10, 2, 3);
            tableLayoutPanel1.Controls.Add(label14, 2, 3);
            tableLayoutPanel1.Controls.Add(courtOrderDateBox, 2, 4);
            tableLayoutPanel1.Controls.Add(fsspDocNumBox, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(label16, 1, 5);
            tableLayoutPanel1.Controls.Add(startDateBox, 1, 6);
            tableLayoutPanel1.Controls.Add(label17, 2, 5);
            tableLayoutPanel1.Controls.Add(finishDateBox, 2, 6);
            tableLayoutPanel1.Controls.Add(label22, 3, 5);
            tableLayoutPanel1.Controls.Add(rejectDateBox, 3, 6);
            tableLayoutPanel1.Controls.Add(label25, 3, 7);
            tableLayoutPanel1.Controls.Add(sessionDateBox, 3, 8);
            tableLayoutPanel1.Controls.Add(label45, 0, 16);
            tableLayoutPanel1.Controls.Add(ModeCB, 0, 17);
            tableLayoutPanel1.Controls.Add(selectDocBarcode, 1, 17);
            tableLayoutPanel1.Controls.Add(labelSelectDocBarcode, 1, 16);
            tableLayoutPanel1.Controls.Add(label32, 2, 11);
            tableLayoutPanel1.Controls.Add(documentNameBox, 2, 12);
            tableLayoutPanel1.Controls.Add(button6, 2, 13);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 13);
            tableLayoutPanel1.Controls.Add(userTaskBox, 3, 12);
            tableLayoutPanel1.Controls.Add(label34, 3, 11);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 10);
            tableLayoutPanel1.Controls.Add(label27, 2, 9);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 9);
            tableLayoutPanel1.Controls.Add(checkBox2, 3, 10);
            tableLayoutPanel1.Controls.Add(gridFiles, 2, 19);
            tableLayoutPanel1.Controls.Add(haveKD, 3, 14);
            tableLayoutPanel1.Controls.Add(ScanCopyKD, 3, 15);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 25;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1460, 921);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Добавление";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(732, 20);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Поиск";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 55);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Тип документа";
            // 
            // typDocBox
            // 
            typDocBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            typDocBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            tableLayoutPanel1.SetColumnSpan(typDocBox, 4);
            typDocBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", dataModelBinding, "Typ_doc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            typDocBox.DataSource = typDocBinding;
            typDocBox.DisplayMember = "name";
            typDocBox.Dock = System.Windows.Forms.DockStyle.Fill;
            typDocBox.FormattingEnabled = true;
            typDocBox.Location = new System.Drawing.Point(4, 73);
            typDocBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            typDocBox.Name = "typDocBox";
            typDocBox.Size = new System.Drawing.Size(720, 23);
            typDocBox.TabIndex = 0;
            typDocBox.ValueMember = "Id";
            // 
            // dataModelBinding
            // 
            dataModelBinding.DataSource = typeof(DataModel);
            // 
            // typDocBinding
            // 
            typDocBinding.DataSource = typeof(SettingsModel);
            // 
            // textBoxF
            // 
            textBoxF.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxF.Location = new System.Drawing.Point(732, 73);
            textBoxF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxF.Name = "textBoxF";
            textBoxF.Size = new System.Drawing.Size(174, 23);
            textBoxF.TabIndex = 1;
            textBoxF.KeyDown += textBox1_KeyDown;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(4, 125);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(50, 15);
            label8.TabIndex = 11;
            label8.Text = "№ Дела";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(732, 125);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(48, 15);
            label11.TabIndex = 14;
            label11.Text = "ID Дела";
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(914, 125);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(38, 15);
            label12.TabIndex = 15;
            label12.Text = "№ КД";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(1096, 125);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(50, 15);
            label13.TabIndex = 16;
            label13.Text = "№ Дела";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Enabled = false;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(550, 843);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(174, 75);
            button2.TabIndex = 28;
            button2.Text = "Готово!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LawActDataGridLabel
            // 
            LawActDataGridLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            LawActDataGridLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(LawActDataGridLabel, 2);
            LawActDataGridLabel.Location = new System.Drawing.Point(732, 195);
            LawActDataGridLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LawActDataGridLabel.Name = "LawActDataGridLabel";
            LawActDataGridLabel.Size = new System.Drawing.Size(100, 15);
            LawActDataGridLabel.TabIndex = 28;
            LawActDataGridLabel.Text = "Судебная работа";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { LawActId, LawActTyp, LawActStatus, LawActFIoVz, LawActName, LawActPortfolio, LawActFio, LawActBirthDate, LawActContract, LawActExecNumber, LawActCourtName, LawActTotalSum, LawActDsc, LawActCourtAdress, LawActStartSum, LawActNumber, LawActSeries, LawActBirthPlace, LawActFullAdr, LawActExecDate, LawActInn });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.DataSource = lawActResultBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.GridColor = System.Drawing.Color.Gray;
            dataGridView1.Location = new System.Drawing.Point(732, 213);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersVisible = false;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 12);
            dataGridView1.Size = new System.Drawing.Size(724, 414);
            dataGridView1.TabIndex = 100;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // LawActId
            // 
            LawActId.DataPropertyName = "id";
            LawActId.HeaderText = "ID";
            LawActId.Name = "LawActId";
            LawActId.ReadOnly = true;
            // 
            // LawActTyp
            // 
            LawActTyp.DataPropertyName = "typ";
            LawActTyp.DataSource = dictTyp;
            LawActTyp.DisplayMember = "name";
            LawActTyp.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            LawActTyp.HeaderText = "Вкладка";
            LawActTyp.Name = "LawActTyp";
            LawActTyp.ReadOnly = true;
            LawActTyp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            LawActTyp.ValueMember = "code";
            // 
            // dictTyp
            // 
            dictTyp.DataSource = typeof(DictModel);
            // 
            // LawActStatus
            // 
            LawActStatus.HeaderText = "Статус";
            LawActStatus.Name = "LawActStatus";
            LawActStatus.ReadOnly = true;
            // 
            // LawActFIoVz
            // 
            LawActFIoVz.DataPropertyName = "fio_vz";
            LawActFIoVz.HeaderText = "ФИО взыскателя";
            LawActFIoVz.Name = "LawActFIoVz";
            LawActFIoVz.ReadOnly = true;
            // 
            // LawActName
            // 
            LawActName.DataPropertyName = "name";
            LawActName.HeaderText = "Название продукта";
            LawActName.Name = "LawActName";
            LawActName.ReadOnly = true;
            // 
            // LawActPortfolio
            // 
            LawActPortfolio.DataPropertyName = "portfolio";
            LawActPortfolio.HeaderText = "Портфель";
            LawActPortfolio.Name = "LawActPortfolio";
            LawActPortfolio.ReadOnly = true;
            // 
            // LawActFio
            // 
            LawActFio.DataPropertyName = "fio";
            LawActFio.HeaderText = "ФИО должника";
            LawActFio.Name = "LawActFio";
            LawActFio.ReadOnly = true;
            // 
            // LawActBirthDate
            // 
            LawActBirthDate.DataPropertyName = "birth_date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            LawActBirthDate.DefaultCellStyle = dataGridViewCellStyle2;
            LawActBirthDate.HeaderText = "Дата рождения";
            LawActBirthDate.Name = "LawActBirthDate";
            LawActBirthDate.ReadOnly = true;
            // 
            // LawActContract
            // 
            LawActContract.DataPropertyName = "contract";
            LawActContract.HeaderText = "№ КД";
            LawActContract.Name = "LawActContract";
            LawActContract.ReadOnly = true;
            // 
            // LawActExecNumber
            // 
            LawActExecNumber.DataPropertyName = "exec_number";
            LawActExecNumber.HeaderText = "№ Дела";
            LawActExecNumber.Name = "LawActExecNumber";
            LawActExecNumber.ReadOnly = true;
            // 
            // LawActCourtName
            // 
            LawActCourtName.DataPropertyName = "court_name";
            LawActCourtName.HeaderText = "Название суда";
            LawActCourtName.Name = "LawActCourtName";
            LawActCourtName.ReadOnly = true;
            // 
            // LawActTotalSum
            // 
            LawActTotalSum.DataPropertyName = "total_sum";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            LawActTotalSum.DefaultCellStyle = dataGridViewCellStyle3;
            LawActTotalSum.HeaderText = "Размер требований";
            LawActTotalSum.Name = "LawActTotalSum";
            LawActTotalSum.ReadOnly = true;
            // 
            // LawActDsc
            // 
            LawActDsc.DataPropertyName = "dsc";
            LawActDsc.HeaderText = "Комментарий";
            LawActDsc.Name = "LawActDsc";
            LawActDsc.ReadOnly = true;
            // 
            // LawActCourtAdress
            // 
            LawActCourtAdress.DataPropertyName = "court_adress";
            LawActCourtAdress.HeaderText = "Адрес суда";
            LawActCourtAdress.Name = "LawActCourtAdress";
            LawActCourtAdress.ReadOnly = true;
            // 
            // LawActStartSum
            // 
            LawActStartSum.DataPropertyName = "start_sum";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            LawActStartSum.DefaultCellStyle = dataGridViewCellStyle4;
            LawActStartSum.HeaderText = "Начальная сумма задолженности";
            LawActStartSum.Name = "LawActStartSum";
            LawActStartSum.ReadOnly = true;
            // 
            // LawActNumber
            // 
            LawActNumber.DataPropertyName = "number";
            LawActNumber.HeaderText = "Номер паспорта";
            LawActNumber.Name = "LawActNumber";
            LawActNumber.ReadOnly = true;
            // 
            // LawActSeries
            // 
            LawActSeries.DataPropertyName = "series";
            LawActSeries.HeaderText = "Серия паспорта";
            LawActSeries.Name = "LawActSeries";
            LawActSeries.ReadOnly = true;
            // 
            // LawActBirthPlace
            // 
            LawActBirthPlace.DataPropertyName = "birth_place";
            LawActBirthPlace.HeaderText = "Место рождения";
            LawActBirthPlace.Name = "LawActBirthPlace";
            LawActBirthPlace.ReadOnly = true;
            // 
            // LawActFullAdr
            // 
            LawActFullAdr.DataPropertyName = "full_adr";
            LawActFullAdr.HeaderText = "Адрес регистрации";
            LawActFullAdr.Name = "LawActFullAdr";
            LawActFullAdr.ReadOnly = true;
            // 
            // LawActExecDate
            // 
            LawActExecDate.DataPropertyName = "exec_date";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            LawActExecDate.DefaultCellStyle = dataGridViewCellStyle5;
            LawActExecDate.HeaderText = "Дата дела";
            LawActExecDate.Name = "LawActExecDate";
            LawActExecDate.ReadOnly = true;
            // 
            // LawActInn
            // 
            LawActInn.DataPropertyName = "inn";
            LawActInn.HeaderText = "ИНН";
            LawActInn.Name = "LawActInn";
            LawActInn.ReadOnly = true;
            // 
            // lawActResultBindingSource
            // 
            lawActResultBindingSource.DataSource = typeof(LawActResult);
            // 
            // label19
            // 
            label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(4, 265);
            label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(160, 15);
            label19.TabIndex = 34;
            label19.Text = "Дата получения агентством";
            // 
            // label20
            // 
            label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(186, 265);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(83, 15);
            label20.TabIndex = 35;
            label20.Text = "Дата возврата";
            // 
            // label21
            // 
            label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(368, 265);
            label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(148, 15);
            label21.TabIndex = 36;
            label21.Text = "Дата ограничения выезда";
            // 
            // receiptDateBox
            // 
            receiptDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Receipt_date", true));
            receiptDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Receipt_date", true));
            receiptDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            receiptDateBox.Location = new System.Drawing.Point(4, 283);
            receiptDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            receiptDateBox.Mask = "00/00/0000";
            receiptDateBox.Name = "receiptDateBox";
            receiptDateBox.Size = new System.Drawing.Size(174, 23);
            receiptDateBox.TabIndex = 15;
            receiptDateBox.ValidatingType = typeof(System.DateTime);
            receiptDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            receiptDateBox.KeyDown += textBox1_KeyDown;
            // 
            // currentEnableds
            // 
            currentEnableds.DataSource = typeof(SettingsModel);
            // 
            // returnDateBox
            // 
            returnDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Return_date", true));
            returnDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Return_date", true));
            returnDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            returnDateBox.Location = new System.Drawing.Point(186, 283);
            returnDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            returnDateBox.Mask = "00/00/0000";
            returnDateBox.Name = "returnDateBox";
            returnDateBox.Size = new System.Drawing.Size(174, 23);
            returnDateBox.TabIndex = 16;
            returnDateBox.ValidatingType = typeof(System.DateTime);
            returnDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            returnDateBox.KeyDown += textBox1_KeyDown;
            // 
            // restrictionToLeaveDtBox
            // 
            restrictionToLeaveDtBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Restriction_to_leave_dt", true));
            restrictionToLeaveDtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Restriction_to_leave_dt", true));
            restrictionToLeaveDtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            restrictionToLeaveDtBox.Location = new System.Drawing.Point(368, 283);
            restrictionToLeaveDtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            restrictionToLeaveDtBox.Mask = "00/00/0000";
            restrictionToLeaveDtBox.Name = "restrictionToLeaveDtBox";
            restrictionToLeaveDtBox.Size = new System.Drawing.Size(174, 23);
            restrictionToLeaveDtBox.TabIndex = 17;
            restrictionToLeaveDtBox.ValidatingType = typeof(System.DateTime);
            restrictionToLeaveDtBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            restrictionToLeaveDtBox.KeyDown += textBox1_KeyDown;
            // 
            // label23
            // 
            label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(4, 335);
            label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(98, 15);
            label23.TabIndex = 42;
            label23.Text = "Дата отмены СП";
            // 
            // label24
            // 
            label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(186, 335);
            label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(172, 15);
            label24.TabIndex = 43;
            label24.Text = "Дата исполнения недостатков";
            // 
            // cancelDateBox
            // 
            cancelDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Cancel_date", true));
            cancelDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Cancel_date", true));
            cancelDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            cancelDateBox.Location = new System.Drawing.Point(4, 353);
            cancelDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cancelDateBox.Mask = "00/00/0000";
            cancelDateBox.Name = "cancelDateBox";
            cancelDateBox.Size = new System.Drawing.Size(174, 23);
            cancelDateBox.TabIndex = 19;
            cancelDateBox.ValidatingType = typeof(System.DateTime);
            cancelDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            cancelDateBox.KeyDown += textBox1_KeyDown;
            // 
            // correctPeriodDateBox
            // 
            correctPeriodDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Correct_period_date", true));
            correctPeriodDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Correct_period_date", true));
            correctPeriodDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            correctPeriodDateBox.Location = new System.Drawing.Point(186, 353);
            correctPeriodDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            correctPeriodDateBox.Mask = "00/00/0000";
            correctPeriodDateBox.Name = "correctPeriodDateBox";
            correctPeriodDateBox.Size = new System.Drawing.Size(174, 23);
            correctPeriodDateBox.TabIndex = 20;
            correctPeriodDateBox.ValidatingType = typeof(System.DateTime);
            correctPeriodDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            correctPeriodDateBox.KeyDown += textBox1_KeyDown;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { LawExecId, LawExecStatus, LawExecDebtStatus, LawExecFioVz, LawExecPortfolio, LawExecFio, LawExecBirthDate, LawExecContract, LawExecFsspDocNum, LawExecCourtDocNum, LawExecTotalSum, LawExecFsspName, LawExecFsspAddress, LawExecExecNumber, LawExecDsc, LawExecFullAdr, LawExecStartSum, LawExecNumber, LawExecSeries, LawExecInn, LawExecExecDate, LawExecBirthPlace });
            tableLayoutPanel1.SetColumnSpan(dataGridView2, 4);
            dataGridView2.DataSource = lawExecResultBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView2.Location = new System.Drawing.Point(732, 668);
            dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.RowHeadersVisible = false;
            tableLayoutPanel1.SetRowSpan(dataGridView2, 6);
            dataGridView2.Size = new System.Drawing.Size(724, 250);
            dataGridView2.TabIndex = 100;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // LawExecId
            // 
            LawExecId.DataPropertyName = "id";
            LawExecId.HeaderText = "ID";
            LawExecId.Name = "LawExecId";
            LawExecId.ReadOnly = true;
            // 
            // LawExecStatus
            // 
            LawExecStatus.DataPropertyName = "Status";
            LawExecStatus.DataSource = dictState;
            LawExecStatus.DisplayMember = "name";
            LawExecStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            LawExecStatus.HeaderText = "Статус";
            LawExecStatus.Name = "LawExecStatus";
            LawExecStatus.ReadOnly = true;
            LawExecStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            LawExecStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            LawExecStatus.ValueMember = "code";
            // 
            // dictState
            // 
            dictState.DataSource = typeof(DictModel);
            // 
            // LawExecDebtStatus
            // 
            LawExecDebtStatus.DataPropertyName = "Debt_status";
            LawExecDebtStatus.DataSource = dictDebtStatus;
            LawExecDebtStatus.DisplayMember = "name";
            LawExecDebtStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            LawExecDebtStatus.HeaderText = "Статус долга";
            LawExecDebtStatus.Name = "LawExecDebtStatus";
            LawExecDebtStatus.ReadOnly = true;
            LawExecDebtStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            LawExecDebtStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            LawExecDebtStatus.ValueMember = "code";
            // 
            // dictDebtStatus
            // 
            dictDebtStatus.DataSource = typeof(DictModel);
            // 
            // LawExecFioVz
            // 
            LawExecFioVz.DataPropertyName = "fio_vz";
            LawExecFioVz.HeaderText = "ФИО Ответсвенного";
            LawExecFioVz.Name = "LawExecFioVz";
            LawExecFioVz.ReadOnly = true;
            // 
            // LawExecPortfolio
            // 
            LawExecPortfolio.DataPropertyName = "portfolio";
            LawExecPortfolio.HeaderText = "Портфель";
            LawExecPortfolio.Name = "LawExecPortfolio";
            LawExecPortfolio.ReadOnly = true;
            // 
            // LawExecFio
            // 
            LawExecFio.DataPropertyName = "fio";
            LawExecFio.HeaderText = "ФИО";
            LawExecFio.Name = "LawExecFio";
            LawExecFio.ReadOnly = true;
            // 
            // LawExecBirthDate
            // 
            LawExecBirthDate.DataPropertyName = "birth_date";
            LawExecBirthDate.HeaderText = "Дата Рождения";
            LawExecBirthDate.Name = "LawExecBirthDate";
            LawExecBirthDate.ReadOnly = true;
            // 
            // LawExecContract
            // 
            LawExecContract.DataPropertyName = "contract";
            LawExecContract.HeaderText = "№ КД";
            LawExecContract.Name = "LawExecContract";
            LawExecContract.ReadOnly = true;
            // 
            // LawExecFsspDocNum
            // 
            LawExecFsspDocNum.DataPropertyName = "fssp_doc_num";
            LawExecFsspDocNum.HeaderText = "№ ИП";
            LawExecFsspDocNum.Name = "LawExecFsspDocNum";
            LawExecFsspDocNum.ReadOnly = true;
            // 
            // LawExecCourtDocNum
            // 
            LawExecCourtDocNum.DataPropertyName = "court_doc_num";
            LawExecCourtDocNum.HeaderText = "№ ИД";
            LawExecCourtDocNum.Name = "LawExecCourtDocNum";
            LawExecCourtDocNum.ReadOnly = true;
            // 
            // LawExecTotalSum
            // 
            LawExecTotalSum.DataPropertyName = "total_sum";
            LawExecTotalSum.HeaderText = "Размер требований";
            LawExecTotalSum.Name = "LawExecTotalSum";
            LawExecTotalSum.ReadOnly = true;
            // 
            // LawExecFsspName
            // 
            LawExecFsspName.DataPropertyName = "fssp_name";
            LawExecFsspName.HeaderText = "ФССП";
            LawExecFsspName.Name = "LawExecFsspName";
            LawExecFsspName.ReadOnly = true;
            // 
            // LawExecFsspAddress
            // 
            LawExecFsspAddress.DataPropertyName = "fssp_address";
            LawExecFsspAddress.HeaderText = "Адрес ФССП";
            LawExecFsspAddress.Name = "LawExecFsspAddress";
            LawExecFsspAddress.ReadOnly = true;
            // 
            // LawExecExecNumber
            // 
            LawExecExecNumber.DataPropertyName = "exec_number";
            LawExecExecNumber.HeaderText = "Номер ГД";
            LawExecExecNumber.Name = "LawExecExecNumber";
            LawExecExecNumber.ReadOnly = true;
            // 
            // LawExecDsc
            // 
            LawExecDsc.DataPropertyName = "dsc";
            LawExecDsc.HeaderText = "Комментарий";
            LawExecDsc.Name = "LawExecDsc";
            LawExecDsc.ReadOnly = true;
            // 
            // LawExecFullAdr
            // 
            LawExecFullAdr.DataPropertyName = "full_adr";
            LawExecFullAdr.HeaderText = "Адрес регистрации";
            LawExecFullAdr.Name = "LawExecFullAdr";
            LawExecFullAdr.ReadOnly = true;
            // 
            // LawExecStartSum
            // 
            LawExecStartSum.DataPropertyName = "start_sum";
            LawExecStartSum.HeaderText = "Начальная сумма";
            LawExecStartSum.Name = "LawExecStartSum";
            LawExecStartSum.ReadOnly = true;
            // 
            // LawExecNumber
            // 
            LawExecNumber.DataPropertyName = "number";
            LawExecNumber.HeaderText = "Номер паспорта";
            LawExecNumber.Name = "LawExecNumber";
            LawExecNumber.ReadOnly = true;
            // 
            // LawExecSeries
            // 
            LawExecSeries.DataPropertyName = "series";
            LawExecSeries.HeaderText = "Серия паспорта";
            LawExecSeries.Name = "LawExecSeries";
            LawExecSeries.ReadOnly = true;
            // 
            // LawExecInn
            // 
            LawExecInn.DataPropertyName = "inn";
            LawExecInn.HeaderText = "ИНН";
            LawExecInn.Name = "LawExecInn";
            LawExecInn.ReadOnly = true;
            // 
            // LawExecExecDate
            // 
            LawExecExecDate.DataPropertyName = "exec_date";
            LawExecExecDate.HeaderText = "Дата дела";
            LawExecExecDate.Name = "LawExecExecDate";
            LawExecExecDate.ReadOnly = true;
            // 
            // LawExecBirthPlace
            // 
            LawExecBirthPlace.DataPropertyName = "birth_place";
            LawExecBirthPlace.HeaderText = "Место рождения";
            LawExecBirthPlace.Name = "LawExecBirthPlace";
            LawExecBirthPlace.ReadOnly = true;
            // 
            // lawExecResultBindingSource
            // 
            lawExecResultBindingSource.DataSource = typeof(LawExecResult);
            // 
            // textBox11
            // 
            tableLayoutPanel1.SetColumnSpan(textBox11, 2);
            textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Dsc", true));
            textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox11.Location = new System.Drawing.Point(4, 668);
            textBox11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            tableLayoutPanel1.SetRowSpan(textBox11, 3);
            textBox11.Size = new System.Drawing.Size(356, 99);
            textBox11.TabIndex = 26;
            textBox11.TextChanged += textBox11_TextChanged;
            textBox11.KeyDown += textBox1_KeyDown;
            // 
            // textBox12
            // 
            tableLayoutPanel1.SetColumnSpan(textBox12, 2);
            textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "DscRead", true));
            textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox12.Location = new System.Drawing.Point(4, 773);
            textBox12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(textBox12, 3);
            textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox12.Size = new System.Drawing.Size(356, 145);
            textBox12.TabIndex = 57;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new System.Drawing.Point(1278, 35);
            label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label31.Name = "label31";
            tableLayoutPanel1.SetRowSpan(label31, 5);
            label31.Size = new System.Drawing.Size(178, 120);
            label31.TabIndex = 62;
            label31.Text = "Горячие клавиши:\r\n\r\nEnter -> Поиск\r\nCtrl + D -> Очистить панель\r\nCtrl + Q -> Удалить файлы\r\nCtrl + Shift + D -> Очистить все\r\nPageDown -> Перенести в конец строки";
            // 
            // execNumberSearchBox
            // 
            execNumberSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            execNumberSearchBox.Location = new System.Drawing.Point(1096, 143);
            execNumberSearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            execNumberSearchBox.Name = "execNumberSearchBox";
            execNumberSearchBox.Size = new System.Drawing.Size(174, 23);
            execNumberSearchBox.TabIndex = 6;
            execNumberSearchBox.KeyDown += textBox1_KeyDown;
            // 
            // contractBox
            // 
            contractBox.Dock = System.Windows.Forms.DockStyle.Fill;
            contractBox.Location = new System.Drawing.Point(914, 143);
            contractBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            contractBox.Name = "contractBox";
            contractBox.Size = new System.Drawing.Size(174, 23);
            contractBox.TabIndex = 5;
            contractBox.KeyDown += textBox1_KeyDown;
            // 
            // idBox
            // 
            idBox.Dock = System.Windows.Forms.DockStyle.Fill;
            idBox.Location = new System.Drawing.Point(732, 143);
            idBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            idBox.Name = "idBox";
            idBox.Size = new System.Drawing.Size(174, 23);
            idBox.TabIndex = 4;
            idBox.KeyDown += textBox1_KeyDown;
            // 
            // execNumberBox
            // 
            execNumberBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Exec_number", true));
            execNumberBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Exec_number", true));
            execNumberBox.Dock = System.Windows.Forms.DockStyle.Fill;
            execNumberBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            execNumberBox.Location = new System.Drawing.Point(4, 143);
            execNumberBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            execNumberBox.Name = "execNumberBox";
            execNumberBox.Size = new System.Drawing.Size(174, 22);
            execNumberBox.TabIndex = 7;
            execNumberBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            execNumberBox.KeyDown += textBox1_KeyDown;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(550, 773);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(174, 27);
            button1.TabIndex = 59;
            button1.Text = "Платежи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Dock = System.Windows.Forms.DockStyle.Top;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Location = new System.Drawing.Point(368, 773);
            button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(174, 27);
            button4.TabIndex = 63;
            button4.Text = "Протокол";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = System.Windows.Forms.DockStyle.Fill;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Location = new System.Drawing.Point(368, 808);
            button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(174, 29);
            button5.TabIndex = 64;
            button5.Text = "Создать банкротство";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label26
            // 
            label26.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(4, 405);
            label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(106, 15);
            label26.TabIndex = 71;
            label26.Text = "Дата поступления";
            // 
            // postNameBox
            // 
            postNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            postNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            postNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Post_address", true));
            postNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            postNameBox.FormattingEnabled = true;
            postNameBox.Location = new System.Drawing.Point(4, 493);
            postNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            postNameBox.Name = "postNameBox";
            postNameBox.Size = new System.Drawing.Size(174, 23);
            postNameBox.TabIndex = 24;
            // 
            // label35
            // 
            label35.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label35.AutoSize = true;
            label35.Location = new System.Drawing.Point(4, 475);
            label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(112, 15);
            label35.TabIndex = 86;
            label35.Text = "Адрес отправителя";
            // 
            // button7
            // 
            button7.Dock = System.Windows.Forms.DockStyle.Fill;
            button7.Location = new System.Drawing.Point(4, 528);
            button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(174, 29);
            button7.TabIndex = 88;
            button7.Text = "Добавить в список";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // articleAndParagraphBox
            // 
            articleAndParagraphBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            articleAndParagraphBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            articleAndParagraphBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Article_and_paragraph", true));
            articleAndParagraphBox.Dock = System.Windows.Forms.DockStyle.Fill;
            articleAndParagraphBox.FormattingEnabled = true;
            articleAndParagraphBox.Items.AddRange(new object[] { "П.3,СТ.46", "П.4,СТ.46", "П.1,СТ.46", "П.3,СТ.46,П.4,СТ.46", "П.6,СТ.46", "П.1,СТ.47", "П.7,СТ.47", "П.4,СТ.47", "П.1,СТ.45", "П.5,СТ.46", "П.2,СТ.46" });
            articleAndParagraphBox.Location = new System.Drawing.Point(186, 423);
            articleAndParagraphBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            articleAndParagraphBox.Name = "articleAndParagraphBox";
            articleAndParagraphBox.Size = new System.Drawing.Size(174, 23);
            articleAndParagraphBox.TabIndex = 21;
            // 
            // label33
            // 
            label33.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(186, 405);
            label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(87, 15);
            label33.TabIndex = 73;
            label33.Text = "Статья и пункт";
            // 
            // postAddressBox
            // 
            postAddressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            postAddressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            postAddressBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Post_name", true));
            postAddressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            postAddressBox.FormattingEnabled = true;
            postAddressBox.Location = new System.Drawing.Point(186, 493);
            postAddressBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            postAddressBox.Name = "postAddressBox";
            postAddressBox.Size = new System.Drawing.Size(174, 23);
            postAddressBox.TabIndex = 25;
            // 
            // button8
            // 
            button8.Dock = System.Windows.Forms.DockStyle.Fill;
            button8.Location = new System.Drawing.Point(186, 528);
            button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(174, 29);
            button8.TabIndex = 89;
            button8.Text = "Добавить в список";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label36
            // 
            label36.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label36.AutoSize = true;
            label36.Location = new System.Drawing.Point(186, 475);
            label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(78, 15);
            label36.TabIndex = 87;
            label36.Text = "Отправитель";
            // 
            // datePostBox
            // 
            datePostBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", dataModelBinding, "Date_post", true));
            datePostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            datePostBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            datePostBox.Location = new System.Drawing.Point(4, 423);
            datePostBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            datePostBox.Name = "datePostBox";
            datePostBox.Size = new System.Drawing.Size(174, 23);
            datePostBox.TabIndex = 100;
            datePostBox.Value = new System.DateTime(2022, 1, 10, 9, 2, 41, 0);
            // 
            // button9
            // 
            button9.Dock = System.Windows.Forms.DockStyle.Fill;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Location = new System.Drawing.Point(368, 843);
            button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(174, 75);
            button9.TabIndex = 92;
            button9.Text = "Другие документы";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", dataModelBinding, "Task", true));
            checkBox3.Location = new System.Drawing.Point(550, 808);
            checkBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(131, 19);
            checkBox3.TabIndex = 27;
            checkBox3.Text = "Постановка задачи";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label30.AutoSize = true;
            label30.Location = new System.Drawing.Point(732, 650);
            label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(125, 15);
            label30.TabIndex = 54;
            label30.Text = "Испол. производство";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(732, 55);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Фамилия";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(913, 55);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 15);
            label5.TabIndex = 126;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(1095, 55);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 15);
            label6.TabIndex = 127;
            label6.Text = "Отчество";
            // 
            // textBoxI
            // 
            textBoxI.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxI.Location = new System.Drawing.Point(913, 73);
            textBoxI.Name = "textBoxI";
            textBoxI.Size = new System.Drawing.Size(176, 23);
            textBoxI.TabIndex = 2;
            textBoxI.KeyDown += textBox1_KeyDown;
            // 
            // textBoxO
            // 
            textBoxO.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxO.Location = new System.Drawing.Point(1095, 73);
            textBoxO.Name = "textBoxO";
            textBoxO.Size = new System.Drawing.Size(176, 23);
            textBoxO.TabIndex = 3;
            textBoxO.KeyDown += textBox1_KeyDown;
            // 
            // label28
            // 
            label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(4, 650);
            label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(138, 15);
            label28.TabIndex = 52;
            label28.Text = "Добавить комментарий";
            // 
            // label29
            // 
            label29.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label29.AutoSize = true;
            label29.Location = new System.Drawing.Point(368, 650);
            label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(91, 15);
            label29.TabIndex = 53;
            label29.Text = "Добавить файл";
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(186, 125);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(136, 15);
            label15.TabIndex = 25;
            label15.Text = "Дата вступления в силу";
            // 
            // CourtExecDateBox
            // 
            CourtExecDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Court_exec_date", true));
            CourtExecDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Court_exec_date", true));
            CourtExecDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            CourtExecDateBox.Location = new System.Drawing.Point(186, 143);
            CourtExecDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CourtExecDateBox.Mask = "00/00/0000";
            CourtExecDateBox.Name = "CourtExecDateBox";
            CourtExecDateBox.Size = new System.Drawing.Size(174, 23);
            CourtExecDateBox.TabIndex = 8;
            CourtExecDateBox.ValidatingType = typeof(System.DateTime);
            CourtExecDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            CourtExecDateBox.KeyDown += textBox1_KeyDown;
            // 
            // courtDocNumBox
            // 
            courtDocNumBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Court_doc_num", true));
            courtDocNumBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Court_doc_num", true));
            courtDocNumBox.Dock = System.Windows.Forms.DockStyle.Fill;
            courtDocNumBox.Location = new System.Drawing.Point(368, 143);
            courtDocNumBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            courtDocNumBox.Name = "courtDocNumBox";
            courtDocNumBox.Size = new System.Drawing.Size(174, 23);
            courtDocNumBox.TabIndex = 10;
            courtDocNumBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            courtDocNumBox.KeyDown += textBox1_KeyDown;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(368, 125);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(123, 15);
            label10.TabIndex = 13;
            label10.Text = "№ Испол. документа";
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(550, 125);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(170, 15);
            label14.TabIndex = 24;
            label14.Text = "Дата вынесения решения/ИД";
            // 
            // courtOrderDateBox
            // 
            courtOrderDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Court_order_date", true));
            courtOrderDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Court_order_date", true));
            courtOrderDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            courtOrderDateBox.Location = new System.Drawing.Point(550, 143);
            courtOrderDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            courtOrderDateBox.Mask = "00/00/0000";
            courtOrderDateBox.Name = "courtOrderDateBox";
            courtOrderDateBox.Size = new System.Drawing.Size(174, 23);
            courtOrderDateBox.TabIndex = 9;
            courtOrderDateBox.ValidatingType = typeof(System.DateTime);
            courtOrderDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            courtOrderDateBox.KeyDown += textBox1_KeyDown;
            // 
            // fsspDocNumBox
            // 
            fsspDocNumBox.BackColor = System.Drawing.SystemColors.Window;
            fsspDocNumBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Fssp_doc_num", true));
            fsspDocNumBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Fssp_doc_num", true));
            fsspDocNumBox.Dock = System.Windows.Forms.DockStyle.Fill;
            fsspDocNumBox.Location = new System.Drawing.Point(4, 213);
            fsspDocNumBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            fsspDocNumBox.Name = "fsspDocNumBox";
            fsspDocNumBox.Size = new System.Drawing.Size(174, 23);
            fsspDocNumBox.TabIndex = 11;
            fsspDocNumBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            fsspDocNumBox.KeyDown += textBox1_KeyDown;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(4, 195);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(41, 15);
            label9.TabIndex = 12;
            label9.Text = "№ ИП";
            // 
            // label16
            // 
            label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(186, 195);
            label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(107, 15);
            label16.TabIndex = 26;
            label16.Text = "Дата возбуждения";
            // 
            // startDateBox
            // 
            startDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Start_date", true));
            startDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Start_date", true));
            startDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            startDateBox.Location = new System.Drawing.Point(186, 213);
            startDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            startDateBox.Mask = "00/00/0000";
            startDateBox.Name = "startDateBox";
            startDateBox.Size = new System.Drawing.Size(174, 23);
            startDateBox.TabIndex = 12;
            startDateBox.ValidatingType = typeof(System.DateTime);
            startDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            startDateBox.KeyDown += textBox1_KeyDown;
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(368, 195);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(162, 15);
            label17.TabIndex = 27;
            label17.Text = "Дата пост об окончании ИП";
            // 
            // finishDateBox
            // 
            finishDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Finish_date", true));
            finishDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Finish_date", true));
            finishDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            finishDateBox.Location = new System.Drawing.Point(368, 213);
            finishDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            finishDateBox.Mask = "00/00/0000";
            finishDateBox.Name = "finishDateBox";
            finishDateBox.Size = new System.Drawing.Size(174, 23);
            finishDateBox.TabIndex = 13;
            finishDateBox.ValidatingType = typeof(System.DateTime);
            finishDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            finishDateBox.KeyDown += textBox1_KeyDown;
            // 
            // label22
            // 
            label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(550, 195);
            label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(155, 15);
            label22.TabIndex = 37;
            label22.Text = "Дата отказа в возбуждении";
            // 
            // rejectDateBox
            // 
            rejectDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Reject_date", true));
            rejectDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Reject_date", true));
            rejectDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            rejectDateBox.Location = new System.Drawing.Point(550, 213);
            rejectDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rejectDateBox.Mask = "00/00/0000";
            rejectDateBox.Name = "rejectDateBox";
            rejectDateBox.Size = new System.Drawing.Size(174, 23);
            rejectDateBox.TabIndex = 14;
            rejectDateBox.ValidatingType = typeof(System.DateTime);
            rejectDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            rejectDateBox.KeyDown += textBox1_KeyDown;
            // 
            // label25
            // 
            label25.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(550, 265);
            label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(97, 15);
            label25.TabIndex = 44;
            label25.Text = "Дата и время СЗ";
            // 
            // sessionDateBox
            // 
            sessionDateBox.DataBindings.Add(new NegateBinding("ReadOnly", currentEnableds, "Session_date", true));
            sessionDateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Session_date", true));
            sessionDateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            sessionDateBox.Location = new System.Drawing.Point(550, 283);
            sessionDateBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sessionDateBox.Mask = "00/00/0000 90:00";
            sessionDateBox.Name = "sessionDateBox";
            sessionDateBox.Size = new System.Drawing.Size(174, 23);
            sessionDateBox.TabIndex = 18;
            sessionDateBox.ValidatingType = typeof(System.DateTime);
            sessionDateBox.ReadOnlyChanged += textBox_ReadOnlyChanged;
            sessionDateBox.KeyDown += textBox1_KeyDown;
            // 
            // label45
            // 
            label45.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label45.AutoSize = true;
            label45.Location = new System.Drawing.Point(4, 580);
            label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(45, 15);
            label45.TabIndex = 122;
            label45.Text = "Режим";
            // 
            // ModeCB
            // 
            ModeCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", dataModelBinding, "Mode", true));
            ModeCB.DataSource = bindingSource1;
            ModeCB.DisplayMember = "name";
            ModeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModeCB.FormattingEnabled = true;
            ModeCB.Location = new System.Drawing.Point(4, 598);
            ModeCB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ModeCB.Name = "ModeCB";
            ModeCB.Size = new System.Drawing.Size(174, 23);
            ModeCB.TabIndex = 100;
            ModeCB.ValueMember = "value";
            ModeCB.SelectedIndexChanged += SelectModeEvent;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CBMember);
            // 
            // selectDocBarcode
            // 
            selectDocBarcode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", dataModelBinding, "Doc_barcode", true));
            selectDocBarcode.DataSource = documentsBindingSource;
            selectDocBarcode.DisplayMember = "Name";
            selectDocBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            selectDocBarcode.FormattingEnabled = true;
            selectDocBarcode.Location = new System.Drawing.Point(186, 598);
            selectDocBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            selectDocBarcode.Name = "selectDocBarcode";
            selectDocBarcode.Size = new System.Drawing.Size(174, 23);
            selectDocBarcode.TabIndex = 31;
            selectDocBarcode.Visible = false;
            // 
            // documentsBindingSource
            // 
            documentsBindingSource.DataSource = typeof(FileData);
            // 
            // labelSelectDocBarcode
            // 
            labelSelectDocBarcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelSelectDocBarcode.AutoSize = true;
            labelSelectDocBarcode.Location = new System.Drawing.Point(186, 580);
            labelSelectDocBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSelectDocBarcode.Name = "labelSelectDocBarcode";
            labelSelectDocBarcode.Size = new System.Drawing.Size(124, 15);
            labelSelectDocBarcode.TabIndex = 123;
            labelSelectDocBarcode.Text = "Документ штрих-код";
            labelSelectDocBarcode.Visible = false;
            // 
            // label32
            // 
            label32.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label32.AutoSize = true;
            label32.Location = new System.Drawing.Point(368, 405);
            label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(120, 15);
            label32.TabIndex = 72;
            label32.Text = "Название документа";
            // 
            // documentNameBox
            // 
            documentNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            documentNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            documentNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", dataModelBinding, "Document_name", true));
            documentNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            documentNameBox.FormattingEnabled = true;
            documentNameBox.Items.AddRange(new object[] { "213123212" });
            documentNameBox.Location = new System.Drawing.Point(368, 423);
            documentNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            documentNameBox.Name = "documentNameBox";
            documentNameBox.Size = new System.Drawing.Size(174, 23);
            documentNameBox.TabIndex = 22;
            // 
            // button6
            // 
            button6.Dock = System.Windows.Forms.DockStyle.Fill;
            button6.Location = new System.Drawing.Point(368, 458);
            button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(174, 29);
            button6.TabIndex = 100;
            button6.Text = "Добавить в список";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(comboBox4, 0, 0);
            tableLayoutPanel3.Controls.Add(button10, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(550, 458);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(172, 28);
            tableLayoutPanel3.TabIndex = 100;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(4, 3);
            comboBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(78, 23);
            comboBox4.TabIndex = 92;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(90, 3);
            button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(78, 21);
            button10.TabIndex = 93;
            button10.Text = "Открыть";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // userTaskBox
            // 
            userTaskBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            userTaskBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            userTaskBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", dataModelBinding, "User_task", true));
            userTaskBox.DataSource = Users;
            userTaskBox.DisplayMember = "NAME";
            userTaskBox.Location = new System.Drawing.Point(550, 423);
            userTaskBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            userTaskBox.Name = "userTaskBox";
            userTaskBox.Size = new System.Drawing.Size(174, 23);
            userTaskBox.TabIndex = 23;
            userTaskBox.ValueMember = "ID";
            // 
            // label34
            // 
            label34.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(550, 405);
            label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(121, 15);
            label34.TabIndex = 74;
            label34.Text = "Исполнитель задачи";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(clearStatus, 1, 0);
            tableLayoutPanel4.Controls.Add(statusBox, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(367, 353);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(176, 29);
            tableLayoutPanel4.TabIndex = 100;
            // 
            // clearStatus
            // 
            clearStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            clearStatus.Image = Properties.Resources.ClearIcon;
            clearStatus.Location = new System.Drawing.Point(143, 3);
            clearStatus.Name = "clearStatus";
            clearStatus.Size = new System.Drawing.Size(30, 23);
            clearStatus.TabIndex = 1;
            clearStatus.UseVisualStyleBackColor = true;
            clearStatus.Click += clearStatus_Click;
            // 
            // statusBox
            // 
            statusBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            statusBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            statusBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", dataModelBinding, "Status", true));
            statusBox.DataSource = dictStatus;
            statusBox.DisplayMember = "name";
            statusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            statusBox.FormattingEnabled = true;
            statusBox.Location = new System.Drawing.Point(3, 3);
            statusBox.Name = "statusBox";
            statusBox.Size = new System.Drawing.Size(134, 23);
            statusBox.TabIndex = 0;
            statusBox.ValueMember = "code";
            // 
            // dictStatus
            // 
            dictStatus.DataSource = typeof(DictModel);
            // 
            // label27
            // 
            label27.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(368, 335);
            label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(43, 15);
            label27.TabIndex = 49;
            label27.Text = "Статус";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(checkBox4, 1, 0);
            tableLayoutPanel2.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(550, 318);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(172, 28);
            tableLayoutPanel2.TabIndex = 100;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", dataModelBinding, "Fssp", true));
            checkBox4.Location = new System.Drawing.Point(90, 3);
            checkBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(78, 19);
            checkBox4.TabIndex = 95;
            checkBox4.Text = "Приставы";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", dataModelBinding, "Check", true));
            checkBox1.Location = new System.Drawing.Point(4, 3);
            checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(78, 19);
            checkBox1.TabIndex = 70;
            checkBox1.Text = "Учёт конвертов\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", dataModelBinding, "Scan", true));
            checkBox2.Location = new System.Drawing.Point(550, 353);
            checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(62, 19);
            checkBox2.TabIndex = 100;
            checkBox2.Text = "Сканы";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // gridFiles
            // 
            gridFiles.AllowDrop = true;
            gridFiles.AllowUserToAddRows = false;
            gridFiles.AllowUserToDeleteRows = false;
            gridFiles.AutoGenerateColumns = false;
            gridFiles.BackgroundColor = System.Drawing.Color.White;
            gridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NeedBarcode, nameDataGridViewTextBoxColumn, typDataGridViewTextBoxColumn });
            tableLayoutPanel1.SetColumnSpan(gridFiles, 2);
            gridFiles.DataSource = documentsBindingSource;
            gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            gridFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            gridFiles.Location = new System.Drawing.Point(367, 668);
            gridFiles.Name = "gridFiles";
            gridFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            gridFiles.RowHeadersVisible = false;
            tableLayoutPanel1.SetRowSpan(gridFiles, 3);
            gridFiles.RowTemplate.Height = 25;
            gridFiles.Size = new System.Drawing.Size(358, 99);
            gridFiles.TabIndex = 128;
            // 
            // NeedBarcode
            // 
            NeedBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            NeedBarcode.DataPropertyName = "NeedBarcode";
            NeedBarcode.HeaderText = "Штрих";
            NeedBarcode.Name = "NeedBarcode";
            NeedBarcode.ToolTipText = "Печатать штрих код?";
            NeedBarcode.Width = 49;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название документа";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            typDataGridViewTextBoxColumn.AutoComplete = false;
            typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            typDataGridViewTextBoxColumn.DataSource = typDocumentsBindingSource;
            typDataGridViewTextBoxColumn.DisplayMember = "name";
            typDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            typDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            typDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            typDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            typDataGridViewTextBoxColumn.ValueMember = "code";
            // 
            // typDocumentsBindingSource
            // 
            typDocumentsBindingSource.DataSource = typeof(DictModel);
            // 
            // haveKD
            // 
            haveKD.AutoSize = true;
            haveKD.Location = new System.Drawing.Point(549, 493);
            haveKD.Name = "haveKD";
            haveKD.Size = new System.Drawing.Size(101, 19);
            haveKD.TabIndex = 129;
            haveKD.Text = "КД в наличии";
            haveKD.UseVisualStyleBackColor = true;
            // 
            // ScanCopyKD
            // 
            ScanCopyKD.AutoSize = true;
            ScanCopyKD.Location = new System.Drawing.Point(549, 528);
            ScanCopyKD.Name = "ScanCopyKD";
            ScanCopyKD.Size = new System.Drawing.Size(107, 19);
            ScanCopyKD.TabIndex = 130;
            ScanCopyKD.Text = "Скан копия КД";
            ScanCopyKD.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1460, 921);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(748, 721);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Входящая почта. Документооборот.";
            ((System.ComponentModel.ISupportInitialize)Users).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataModelBinding).EndInit();
            ((System.ComponentModel.ISupportInitialize)typDocBinding).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dictTyp).EndInit();
            ((System.ComponentModel.ISupportInitialize)lawActResultBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dictState).EndInit();
            ((System.ComponentModel.ISupportInitialize)dictDebtStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)lawExecResultBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentsBindingSource).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dictStatus).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)typDocumentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentEnableds).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typDocBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox contractBox;
        private System.Windows.Forms.TextBox execNumberSearchBox;
        private System.Windows.Forms.TextBox execNumberBox;
        private System.Windows.Forms.TextBox fsspDocNumBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LawActDataGridLabel;
        private System.Windows.Forms.MaskedTextBox CourtExecDateBox;
        private System.Windows.Forms.MaskedTextBox startDateBox;
        private System.Windows.Forms.MaskedTextBox finishDateBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox receiptDateBox;
        private System.Windows.Forms.MaskedTextBox returnDateBox;
        private System.Windows.Forms.MaskedTextBox restrictionToLeaveDtBox;
        private System.Windows.Forms.MaskedTextBox rejectDateBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox cancelDateBox;
        private System.Windows.Forms.MaskedTextBox correctPeriodDateBox;
        private System.Windows.Forms.MaskedTextBox sessionDateBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.MaskedTextBox courtOrderDateBox;
        private System.Windows.Forms.TextBox courtDocNumBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox documentNameBox;
        private System.Windows.Forms.ComboBox articleAndParagraphBox;
        private System.Windows.Forms.ComboBox userTaskBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox postNameBox;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox postAddressBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DateTimePicker datePostBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.BindingSource Users;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox ModeCB;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelSelectDocBarcode;
        private System.Windows.Forms.ComboBox selectDocBarcode;
        private System.Windows.Forms.BindingSource lawActResultBindingSource;
        private System.Windows.Forms.BindingSource lawExecResultBindingSource;
        private System.Windows.Forms.BindingSource dictTyp;
        private System.Windows.Forms.BindingSource dictStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button clearStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActCourtDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActCourtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecCourtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecCourtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxI;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.BindingSource typDocBinding;
        private System.Windows.Forms.BindingSource currentEnableds;
        private System.Windows.Forms.BindingSource dataModelBinding;
        private System.Windows.Forms.BindingSource dictState;
        private System.Windows.Forms.BindingSource dictDebtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActId;
        private System.Windows.Forms.DataGridViewComboBoxColumn LawActTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActFIoVz;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActPortfolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActExecNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActCourtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActTotalSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActCourtAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActStartSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActBirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActFullAdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActExecDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawActInn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecId;
        private System.Windows.Forms.DataGridViewComboBoxColumn LawExecStatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn LawExecDebtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecFioVz;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecPortfolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecFsspDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecCourtDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecTotalSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecFsspName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecFsspAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecExecNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecFullAdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecStartSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecInn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecExecDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LawExecBirthPlace;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DataGridView gridFiles;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource typDocumentsBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NeedBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox haveKD;
        private System.Windows.Forms.CheckBox ScanCopyKD;
    }
}

