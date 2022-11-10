﻿using DocumentAdder.Dialogs;
using DocumentAdder.Main;
using DocumentAdder.Models;
using DocumentAdder.Properties;
using DocumentAdder.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static DocumentAdder.Models.Adder;

namespace DocumentAdder.Forms
{
    public partial class MainForm : Form
    {
        private static string path_to_list = Environment.CurrentDirectory + "\\Список_Для_Документов.txt";
        private static string path_to_list_adr = Environment.CurrentDirectory + "\\Список_Для_Адреса.txt";
        private static string path_to_list_otprav = Environment.CurrentDirectory + "\\Список_Для_Отправителя.txt";
        private static SerialPort currentPort = new SerialPort();
        private bool runed = false;
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Action action = () =>
            {
                ClearTextBox();
                string given = indata;
                textBox4.Text = given.Replace("\r", string.Empty);
                //Searcher searcher = new Searcher(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text)
                Searcher searcher = new Searcher("", "", "", textBox4.Text, "", "");
                searcher.GetTables(dataGridView1, dataGridView2, dataSet1);
                comboBox1.SelectedIndex = 12;
                if (dataGridView1.RowCount == 1)
                {
                    textBox4.Text = dataGridView1.Rows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[0].Cells[6].Value.ToString().Split(' ')[0]; //Фамилия
                    textBox2.Text = dataGridView1.Rows[0].Cells[6].Value.ToString().Split(' ')[1]; //Имя
                    textBox3.Text = dataGridView1.Rows[0].Cells[6].Value.ToString().Split(' ')[2]; //Отчество
                    textBox7.Text = dataGridView1.Rows[0].Cells[8].Value.ToString(); // № КД
                    textBox8.Text = dataGridView1.Rows[0].Cells[9].Value.ToString(); //№ Дела
                    textBox5.Text = dataGridView1.Rows[0].Cells[8].Value.ToString(); // № КД
                    textBox6.Text = dataGridView1.Rows[0].Cells[9].Value.ToString(); //№ Дела
                    textBox12.Text = dataGridView1.Rows[0].Cells[12].Value.ToString(); //Коммент
                    textBox15.Text = dataGridView1.Rows[0].Cells[5].Value.ToString(); //реестр
                    textBox14.Text = dataGridView1.Rows[0].Cells[3].Value.ToString(); //взыск
                    string vkl = dataGridView1.Rows[0].Cells[1].Value.ToString(); //Вкладка
                    string int_vkl = GetIntKvl(vkl);
                    Dictionary<string, SettingsModel> o = JsonConvert.DeserializeObject<Dictionary<string, SettingsModel>>(Settings.json);
                    string status_text = o[comboBox1.SelectedIndex.ToString()].вкладка_и_статус[int_vkl];
                    comboBox2.SelectedIndex = Convert.ToInt32(int_vkl);
                    int status_get = GetStatusBible(status_text);
                    if (status_get == 99999)
                        comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
                    else
                        comboBox3.SelectedIndex = status_get - 1;
                    maskedTextBox5.Text = DateTime.Now.ToShortDateString();
                }
                indata = String.Empty;


            };
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public void Loader()
        {
            if (!runed)
            {
                List<CBMember> cBMembers = new List<CBMember>();
                Documents.DataSource = Adder.files;
                cBMembers.Add(new CBMember() { name = "Входящая почта", value = 1 });
                cBMembers.Add(new CBMember() { name = "Госпочта", value = 2 });
                cBMembers.Add(new CBMember() { name = "Мейл(Суд)", value = 3 });
                cBMembers.Add(new CBMember() { name = "Мейл(ФССП)", value = 4 });
                bindingSource1.DataSource = cBMembers;
                //ModeCB.DataSource = bindingSource1;

                LoadList();
                currentPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                comboBox4.DataSource = SerialPort.GetPortNames();

                if (File.Exists(path_to_list))
                {
                    List<string> spis = File.ReadLines(path_to_list).ToList();
                    comboBox5.DataSource = spis;
                }
                else
                {
                    File.CreateText(path_to_list);
                }
                if (File.Exists(path_to_list_adr))
                {
                    List<string> spis1 = File.ReadLines(path_to_list_adr).ToList();
                    comboBox8.DataSource = spis1;
                }
                else
                {
                    File.CreateText(path_to_list_adr);
                }
                if (File.Exists(path_to_list_otprav))
                {
                    List<string> spis2 = File.ReadLines(path_to_list_otprav).ToList();
                    comboBox9.DataSource = spis2;
                }
                else
                {
                    File.CreateText(path_to_list_otprav);
                }
                Settings.json = Resources.config;
                panel1.AllowDrop = true;
                Dictionary<string, SettingsModel> o = JsonConvert.DeserializeObject<Dictionary<string, SettingsModel>>(Settings.json);
                for (int a = 0; a < o.Count; a++)
                    comboBox1.Items.Add(o[(string)a.ToString()].тип_документа);
                this.Text = FromStart.DownloadInfo();
                comboBox1.SelectedIndex = 0;
                //LoadPeople();
                runed = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox5.Text = DateTime.Now.ToShortDateString();
            string a = comboBox1.SelectedIndex.ToString();
            Dictionary<string, SettingsModel> o = JsonConvert.DeserializeObject<Dictionary<string, SettingsModel>>(Settings.json);
            textBox7.Enabled = o[a].номер_кд;
            textBox8.Enabled = o[a].номер_дела;
            textBox9.Enabled = o[a].номер_ип;
            textBox10.Enabled = o[a].номер_испол;
            maskedTextBox1.Enabled = o[a].дата_вынесения_решения;
            maskedTextBox2.Enabled = o[a].дата_вступления_в_силу;
            maskedTextBox3.Enabled = o[a].дата_возбуждения;
            maskedTextBox4.Enabled = o[a].дата_пост_об_окончании_ип;
            maskedTextBox5.Enabled = o[a].дата_получения_агентством;
            maskedTextBox6.Enabled = o[a].дата_возврата;
            maskedTextBox7.Enabled = o[a].дата_ограничения_выезда;
            maskedTextBox8.Enabled = o[a].дата_отказа_в_возбуждении;
            maskedTextBox9.Enabled = o[a].дата_отмены_сп;
            maskedTextBox10.Enabled = o[a].дата_исполнения_недостатков;
            maskedTextBox11.Enabled = o[a].дата_и_время_сз;
            Data.int_color = o[a].цвет_карточки;
            Settings.barcode = o[a].штрих_код;
            if (Settings.barcode == true)
            {
                if (Utils.Printer.CheckCom())
                {
                    selectDocBarcode.Enabled = true;
                }
                else { selectDocBarcode.Enabled = false; }
            }
            else
            {
                selectDocBarcode.Enabled = false;
            }

            if (comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                        || comboBox1.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                        || comboBox1.Text.Contains("ИЛ в НАШУ пользу")
                        || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу")
                        || comboBox1.Text.Contains("Дубликат ИД(Правопреемство)/Дубликат ИД + Определение о выдаче дубликата")
                        || comboBox1.Text.Contains("ИД/Дубликат ИД/Исп. надпись с ПОИП+АКТ (мы взыскатель)")
                        || comboBox1.Text.Contains("Постановление об отказе в возбуждении ИП с ИД")
                        )
            {
                textBox21.Enabled = true;
                textBox23.Enabled = true;
                textBox19.Enabled = true;
                textBox20.Enabled = true;
                maskedTextBox12.Enabled = true;
                textBox16.Enabled = true;
                innMb.Enabled = true;
                execDateMb.Enabled = true;
            }
            else
            {
                textBox21.Enabled = false;
                textBox23.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                //maskedTextBox12.Enabled = false;
                //textBox16.Enabled = false;
                innMb.Enabled = false;
                execDateMb.Enabled = false;
            }

            if (comboBox1.Text.Contains("Дубликат ИД(Правопреемство)/Дубликат ИД + Определение о выдаче дубликата")
                || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу")
                || comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу"))
            {
                Settings.dateId = true;
            }
            else
                Settings.dateId = false;
        }

        private void maskedTextBox8_EnabledChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Enabled == true)
                    ((TextBox)sender).BackColor = Color.White;
                else
                    ((TextBox)sender).BackColor = Color.Red;
            }
            else
            {
                if (((MaskedTextBox)sender).Enabled == true)
                    ((MaskedTextBox)sender).BackColor = Color.White;
                else
                    ((MaskedTextBox)sender).BackColor = Color.Red;
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searcher searcher = new Searcher(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                searcher.GetTables(dataGridView1, dataGridView2, dataSet1);
            }
            if (e.Control && e.KeyCode == Keys.D)
                ClearTextBox();
            if (e.Control && e.KeyCode == Keys.Q)
            {
                Adder.files.Clear();
                Documents.ResetBindings(true);
                MessageBox.Show("Все файлы удалены!", "Удачно!");
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.D)
            {
                ClearTextBox();
                Adder.files.Clear();
                Documents.ResetBindings(true);
                MessageBox.Show("Все файлы удалены, Поля очищены!", "Удачно!");
            }
            if (e.KeyCode == Keys.PageDown)
                textBox11.SelectionStart = textBox11.Text.Length;
        }

        public void ClearTextBox()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = "";
                if ((control is MaskedTextBox)/* && (control.Name != "maskedTextBox12")*/)
                    (control as MaskedTextBox).Clear();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBox();
            if (e.RowIndex >= 0)
            {
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Split(' ')[0]; //Фамилия
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Split(' ')[1]; //Имя
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Split(' ')[2]; //Отчество
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(); // № КД
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(); //№ Дела
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(); // № КД
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(); //№ Дела
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString(); //Коммент
                textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); //реестр
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); //взыск
                string vkl = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); //ID Дела
                string int_vkl = GetIntKvl(vkl);
                Dictionary<int, SettingsModel> o = JsonConvert.DeserializeObject<Dictionary<int, SettingsModel>>(Settings.json);
                string status_text = o[comboBox1.SelectedIndex].вкладка_и_статус[int_vkl];
                comboBox2.SelectedIndex = Convert.ToInt32(int_vkl);
                int status_get = GetStatusBible(status_text);
                if (o[comboBox1.SelectedIndex].без_смены.Contains(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    status_get = 99999;
                }
                if (status_get == 99999)
                    comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
                else
                    comboBox3.SelectedIndex = status_get - 1;
                maskedTextBox5.Text = DateTime.Now.ToShortDateString();

                maskedTextBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                //textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                //textBox25.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                textBox23.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                textBox19.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                textBox20.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
                textBox21.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
                textBox22.Text = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
                textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString().Split(' ')[0];
                execDateMb.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
                innMb.Text = dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();
            }
        }

        private int GetStatusBible(string status_text)
        {
            if (status_text == "Без статуса")
                return 99999;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    return Settings.status[0].FirstOrDefault(x => x.Value == status_text).Key;
                case 1:
                    return Settings.status[1].FirstOrDefault(x => x.Value == status_text).Key;
                case 2:
                    return Settings.status[1].FirstOrDefault(x => x.Value == status_text).Key;
                case 4:
                    return Settings.status[2].FirstOrDefault(x => x.Value == status_text).Key;
            }
            return 0;
        }

        private string GetIntKvl(string vkl)
        {
            switch (vkl)
            {
                case "Приказ":
                    return "0";
                case "Иск":
                    return "1";
                case "Правопреемство":
                    return "2";
                case "Банкротство":
                    return "3";
            }
            return "0";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox3.Items.Clear();
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        foreach (KeyValuePair<int, string> key in Settings.status[0])
                            comboBox3.Items.Add(key.Value);
                        comboBox3.Items.Add("Без статуса");
                        break;
                    case 1:
                        foreach (KeyValuePair<int, string> key in Settings.status[1])
                            comboBox3.Items.Add(key.Value);
                        comboBox3.Items.Add("Без статуса");
                        break;
                    case 2:
                        foreach (KeyValuePair<int, string> key in Settings.status[1])
                            comboBox3.Items.Add(key.Value);
                        comboBox3.Items.Add("Без статуса");
                        break;
                    case 3:
                        comboBox3.Items.Add("Без статуса");
                        break;
                    case 4:
                        foreach (KeyValuePair<int, string> key in Settings.status[2])
                            comboBox3.Items.Add(key.Value);
                        comboBox3.Items.Add("Без статуса");
                        comboBox3.SelectedIndex = 0;
                        break;
                }
                Data.vkl_int = comboBox2.SelectedIndex;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.debt_id = textBox4.Text;
            Settings.vkl = comboBox2.SelectedIndex;
            if (!string.IsNullOrWhiteSpace(Settings.debt_id))
            {
                DebtCalc testDialog = new DebtCalc();
                testDialog.Show();
            }
            else
                MessageBox.Show("Для поиска платежей необходим ID Дела", "Ошибка!");
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                string file = files[0];
                string file_name = files[0].Split('\\').Last();
                Adder.files.Add(new FileItem() { path = file, name = file_name }); //Путь до файла | Название файла
                Documents.ResetBindings(true);
                MessageBox.Show($"Добавлен новый файл!\r\n\r\nНазвание файла: {file_name}\r\n\r\nПуть до файла: {file}\r\n\r\nВсего файлов: {Adder.files.Count}", "Добавлен файл!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length != 0)
            {
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            foreach (var value in Adder.files)
                ls.Add($"Название файла: {value.name}\r\nПуть: {value.path}\r\n");
            MessageBox.Show($"Всего добавлено {Adder.files.Count} файлов\r\n\r\n" + string.Join("\r\n", ls));
            ls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vvvv = comboBox1.SelectedItem.ToString();


            if (comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                        || comboBox1.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                        || comboBox1.Text.Contains("ИЛ в НАШУ пользу")
                        || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу")
                        || comboBox1.Text.Contains("Дубликат ИД(Правопреемство)/Дубликат ИД + Определение о выдаче дубликата")
                        || comboBox1.Text.Contains("ИД/Дубликат ИД/Исп. надпись с ПОИП+АКТ (мы взыскатель)")
                        || comboBox1.Text.Contains("Постановление об отказе в возбуждении ИП с ИД")
                        )
            {
                if (/*String.IsNullOrEmpty(textBox21.Text) || */String.IsNullOrEmpty(textBox23.Text) || /*String.IsNullOrEmpty(textBox19.Text) || String.IsNullOrEmpty(textBox20.Text) ||*/ String.IsNullOrEmpty(textBox8.Text) || String.IsNullOrEmpty(maskedTextBox12.Text) || String.IsNullOrEmpty(textBox16.Text) || /*String.IsNullOrEmpty(comboBox9.Text) ||*/ String.IsNullOrEmpty(comboBox8.Text))
                {
                    MessageBox.Show("Поля для ВТБ не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (CheckMasked() == false)
            {
                MessageBox.Show("ДАТЫ не заполнены или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.Text.Contains("ПОВИП") && string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Поле № ИП не заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                       || comboBox1.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                       || comboBox1.Text.Contains("ИЛ в НАШУ пользу")
                       || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу")
                        || comboBox1.Text.Contains("Дубликат ИД(Правопреемство)/Дубликат ИД + Определение о выдаче дубликата")
                        || comboBox1.Text.Contains("ИД/Дубликат ИД/Исп. надпись с ПОИП+АКТ (мы взыскатель)")
                        || comboBox1.Text.Contains("Постановление об отказе в возбуждении ИП с ИД")
                        )
            {
                PersonInfo personInfo = new PersonInfo()
                {
                    court_doc_num = textBox16.Text,
                    court_date = maskedTextBox12.Text,
                    exec_number = textBox8.Text,
                    fio = $"{textBox1.Text} {textBox2.Text} {textBox3.Text}",
                    birth_date = textBox18.Text,
                    birth_place = textBox21.Text,
                    series = textBox19.Text,
                    number = textBox20.Text,
                    inn = innMb.Text,
                    sum = textBox23.Text,
                    /*exec_date = execDateMb.Text,
                    name = comboBox9.Text*/
                };
                try
                {
                    var (error, message) = VTBAdder.CreateExcel();
                    if (error)
                    {
                        MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        VTBAdder.Add(personInfo);
                }
                catch
                {
                    MessageBox.Show(this, "Строчка не добавлена, скорее всего открыт Excel файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (comboBox2.SelectedIndex == 4)
                Data.vkl_string = "law_exec";
            else
                Data.vkl_string = "law_act";
            Data.vkl_int = comboBox2.SelectedIndex;
            Data.id = textBox4.Text;

            List<string> ls = Data.Update(textBox7, textBox8, textBox9, textBox10, textBox11,
                maskedTextBox1, maskedTextBox2, maskedTextBox3, maskedTextBox4, maskedTextBox5,
                maskedTextBox6, maskedTextBox7, maskedTextBox8, maskedTextBox9, maskedTextBox10, maskedTextBox11, textBox23, comboBox3.Text);
            ls.Add("\r\n\r\n");
            File.AppendAllText(Environment.CurrentDirectory + "\\SQL.txt", string.Join("\r\n", ls));
            int errors = 0;

            foreach (string str in ls)
            {
                try
                {
                    using (OdbcCommand command = new OdbcCommand(str))
                    {
                        command.Connection = Program.Conn;

                        if (command.Connection.State == System.Data.ConnectionState.Closed)
                        {
                            command.Connection.Open();
                        }

                        command.ExecuteReader();
                    }
                }
                catch (Exception ex) { errors++; File.AppendAllText(Environment.CurrentDirectory + "\\ErrorsSQL.txt", $"{str}\r\n{ex.Message}\r\n\r\n"); }
            }
            List<ClientDoc> docs = new List<ClientDoc>();
            foreach (var value in Adder.files)
            {
                string segmentation = @"\\usb\all\shara\Сегментация обучение\";

                string file = value.name; //Название файла.pdf
                string file_dir = value.path; //Расположение файла
                string type = file.Split('.').Last(); //расширение файла
                string free_dir = GetFreeDir(); //свободная папка для залива
                Guid guid = Guid.NewGuid();
                string uuid = guid.ToString(); //НОВЫЙ GUID
                string new_file = uuid + $".{type}"; //guid.pdf
                File.Copy(file_dir, free_dir + $"\\{uuid}.{type}");

                try
                {
                    File.Copy(file_dir, segmentation + $"{comboBox1.SelectedItem.ToString().Replace("/", "")}" + $"\\Test{file}");
                }
                catch (Exception exeption)
                {
                    File.AppendAllText(Environment.CurrentDirectory + "\\ErrorsSQL.txt", $"Файл: {file} не был сохранен. {exeption.Message}");
                }
                int returnValue = -1;
                string sql_file = GetSqlFile(new_file, free_dir.Split('\\').Last(), file);
                using (OdbcCommand command = new OdbcCommand(sql_file))
                {
                    command.Connection = Program.Conn;

                    if (command.Connection.State == System.Data.ConnectionState.Closed)
                    {
                        command.Connection.Open();
                    }

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out returnValue);
                    }
                    if (returnValue > 0)
                    {
                        if (value == (FileItem)selectDocBarcode.SelectedItem & selectDocBarcode.Enabled == true)
                        {
                            var doc = new ClientDoc() { doc = returnValue, barcode = true, title = textBox16.Text, date = maskedTextBox12.Text };
                            if (Data.vkl_int == 4)
                            {
                                doc.type = 2;
                            }
                            else
                            {
                                doc.type = 1;
                            }
                            docs.Add(doc);
                        }
                        else
                        {
                            docs.Add(new ClientDoc() { doc = returnValue, barcode = false });
                        }
                    }
                }
            }
            Adder.files.Clear();
            Documents.ResetBindings(true);
            int[] ints = { 2, 3, 4 };

            if (ints.Contains(
            (int)ModeCB.SelectedValue))
            {
                Mail f = new Mail((int)ModeCB.SelectedValue, this, ref errors, checkBox3.Checked, docs);
                f.Show(this);
            }
            else
            {

                if (checkBox3.Checked == true)
                {
                    newTask(errors, docs);
                }
                else
                {

                    //if (comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                    //        || comboBox1.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                    //        || comboBox1.Text.Contains("ИЛ в НАШУ пользу")
                    //        || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу"))
                    //{
                    //    bool r = SberAdder();
                    //    if (!r)
                    //    {
                    //        errors += 1;
                    //    }
                    //}
                    try
                    {
                        var vm = getRequest("without_task", docs: docs);
                        var request = new RestRequest("/123").AddJsonBody(vm);
                        var response = Program.client.Post<ServerResults>(request);
                        if (response.Barcodes != null)
                            foreach (var barcode in response.Barcodes)
                                Utils.Printer.PrintBarCode(barcode.barcode);
                    }
                    catch (Exception ee)
                    {
                        errors += 1;
                        MessageBox.Show($"Ошибка:{ee}\r\nДанные в таблицу не занесены!");
                    }
                    if (errors == 0)
                    {
                        MessageBox.Show("Успешно добавлено!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                    }
                    else
                        MessageBox.Show($"Возникли непредвиденные ошибки\r\nКол-во: {errors}\r\nВсе ошибки находятся в ErrorsSQL.txt");
                    errors = 0;
                }
            }
        }

        public void newTask(int errors, List<ClientDoc> docs)
        {
            PersonInfo personInfo = new PersonInfo()
            {
                court_doc_num = textBox16.Text,
                court_date = maskedTextBox12.Text,
                exec_number = textBox8.Text,
                fio = $"{textBox1.Text} {textBox2.Text} {textBox3.Text}",
                birth_date = textBox18.Text,
                birth_place = textBox21.Text,
                series = textBox19.Text,
                number = textBox20.Text,
                inn = innMb.Text,
                sum = textBox23.Text,
                exec_date = execDateMb.Text,
                name = comboBox9.Text
            };
            Tasks f = new Tasks(ref errors, this, personInfo, docs);
            f.Show();
            f.FormClosed += F_FormClosed;
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearTextBox();
        }

        public object getRequest(string typ, string id_task = "0", List<ClientDoc> docs = null)
        {
            docs = docs ?? new List<ClientDoc>();
            bool pristavi = false;
            if (checkBox4.Checked == true)
                pristavi = true;
            bool convert = false;
            if (checkBox1.Checked == true)
                convert = true;
            bool nal_skan = false;
            if (checkBox2.Checked == true)
                nal_skan = true;
            if (Settings.mode < 1)
                Settings.mode = 1;
            DateTime? dateDoc = null;
            if (!string.IsNullOrEmpty(Settings.dateDoc))
                dateDoc = DateTime.Parse(Settings.dateDoc);
            string desc = $"{textBox11.Text}";
            if (maskedTextBox10.Enabled == true)
                desc += $" {maskedTextBox10.Text}";
            var result = new { token = Settings.token, date_post = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()), Convert = convert, pristavi = pristavi, adr_otp = comboBox8.Text, otprav = comboBox9.Text, reestr = textBox15.Text, doc_name = comboBox5.Text, id_dela = textBox4.Text, st_pnkt = comboBox6.Text, gd = textBox6.Text, fio_dol = $"{textBox1.Text} {textBox2.Text} {textBox3.Text}", kd = textBox5.Text, ispol_zadach = comboBox7.Text, id_ispol_zadach = comboBox7.SelectedValue, vsisk = textBox14.Text, kto_obrabotal = $"{Settings.username}", id_kto_obrabotal = $"{Settings.user_id}", nal_skan = nal_skan, action = typ, user_id = comboBox7.SelectedValue, template_id = id_task, name = $"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox5.Text} {textBox15.Text}", desc, Settings.mode, Settings.ist, dateDoc = dateDoc, Settings.ecp, Settings.adres, Settings.mail, docs };
            //result.dateDoc = Settings.dateDoc;
            return result;
        }

        private bool CheckMasked()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is MaskedTextBox)
                    if (control.Enabled == true && ((MaskedTextBox)control).MaskCompleted == false && control.Name != "maskedTextBox12" && control.Name != "execDateMb" && control.Name != "innMb")
                        return false;
            }
            return true;
        }

        private string GetFreeDir()
        {
            int a = 0;
            string main_dir = Settings.main;
            string[] dirs = Directory.GetDirectories(main_dir);
            foreach (string b in dirs)
            {
                if (Regex.IsMatch(b.Split('\\').Last(), @"\D+"))
                    continue;
                if (Convert.ToInt32(b.Split('\\').Last()) > a)
                    a = Convert.ToInt32(b.Split('\\').Last());
            }
            string path = main_dir + "\\" + a.ToString();
            if (Directory.GetFiles(path).Length >= 1000)
            {
                Directory.CreateDirectory(main_dir + "\\" + (a + 1).ToString());
                return main_dir + "\\" + (a + 1).ToString();
            }
            return main_dir + "\\" + a.ToString();
        }


        private string GetSqlFile(string new_file, string index, string old_file)
        {
            if (Data.vkl_int != 4)
                return "insert into doc_attach " +
                    "(obj_id,r_id,name,filename,vers1,vers2,is_active,r_user_id,dt,FILE_SERVER_NAME,REL_SERVER_PATH,CHANGE_DT,SAVE_MODE) values " +
                    $"(46, {Data.id}, \'{old_file}\', \'{old_file}\', 1, 0, 1, {Settings.user_id}, getdate(), \'{new_file}\', \'\\{index}\\\',getdate(),2);" +
                    $"SELECT SCOPE_IDENTITY();\r\n" +
                    $"insert into law_act_protokol (dt,typ,parent_id,r_user_id,dsc) values (getdate(), 23, {Data.id}, {Settings.user_id}, \'Вложение: {old_file}\');";
            else
                return "insert into doc_attach " +
                    "(obj_id,r_id,name,filename,vers1,vers2,is_active,r_user_id,dt,FILE_SERVER_NAME,REL_SERVER_PATH,CHANGE_DT,SAVE_MODE) values " +
                    $"(47, {Data.id}, \'{old_file}\', \'{old_file}\', 1, 0, 1, {Settings.user_id}, getdate(), \'{new_file}\', \'\\{index}\\\',getdate(),2);" +
                    $"SELECT SCOPE_IDENTITY();" +
                    $"insert into law_exec_protokol (dt,typ,parent_id,r_user_id,dsc) values (getdate(), 9, {Data.id}, {Settings.user_id}, \'Вложение: {old_file}\')";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.status = comboBox3.SelectedIndex;
            Data.status_text = comboBox3.SelectedItem.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBox();
            if (e.RowIndex >= 0)
            {
                textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString().Split(' ')[0];
                textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString().Split(' ')[1];
                textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString().Split(' ')[2];
                textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[13].Value.ToString();
                textBox10.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[13].Value.ToString();
                textBox12.Text = dataGridView2.Rows[e.RowIndex].Cells[14].Value.ToString();
                textBox15.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(); //реестр
                textBox14.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString(); //взыск
                Dictionary<string, SettingsModel> o = JsonConvert.DeserializeObject<Dictionary<string, SettingsModel>>(Settings.json);
                string status_text = o[comboBox1.SelectedIndex.ToString()].вкладка_и_статус["4"];
                comboBox2.SelectedIndex = 4;
                int status_get = GetStatusBible(status_text);
                if (status_get == 99999)
                    comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
                else
                    comboBox3.SelectedIndex = status_get - 1;
                maskedTextBox5.Text = DateTime.Now.ToShortDateString();

                maskedTextBox12.Text = dataGridView2.Rows[e.RowIndex].Cells[15].Value.ToString();
                textBox16.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
                //textBox17.Text = dataGridView2.Rows[e.RowIndex].Cells[12].Value.ToString();
                //textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells[16].Value.ToString();
                textBox23.Text = dataGridView2.Rows[e.RowIndex].Cells[17].Value.ToString();
                textBox18.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString().Split(' ')[0];
                textBox19.Text = dataGridView2.Rows[e.RowIndex].Cells[18].Value.ToString();
                textBox20.Text = dataGridView2.Rows[e.RowIndex].Cells[19].Value.ToString();
                textBox21.Text = dataGridView2.Rows[e.RowIndex].Cells[20].Value.ToString();
                textBox22.Text = dataGridView2.Rows[e.RowIndex].Cells[21].Value.ToString();
                innMb.Text = dataGridView2.Rows[e.RowIndex].Cells[23].Value.ToString();
                execDateMb.Text = dataGridView2.Rows[e.RowIndex].Cells[22].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.debt_id = textBox4.Text;
            Settings.vkl = comboBox2.SelectedIndex;
            if (!string.IsNullOrWhiteSpace(Settings.debt_id))
            {
                DocAttach testDialog = new DocAttach();
                testDialog.Show();
            }
            else
                MessageBox.Show("Для поиска протокола необходим ID Дела", "Ошибка!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Невозможно создать банкротство без ID Дела\r\nаналогичного должника");
                return;
            }
            string sql = $"insert into law_act (r_person_id,typ,fd,delivery_typ,court_order_delivery,status,full_strength,act_status,deadline,currency,load_dt,PRE_ACT_STATUS) values ((select r_person_id from law_act where id = {textBox4.Text}),4,getdate(),0,0,1,1,1,getdate(),1,getdate(),1);" +
                $"SELECT SCOPE_IDENTITY();";
            using (OdbcCommand command = new OdbcCommand(sql))
            {
                command.Connection = Program.Conn;

                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                int id = Convert.ToInt32(command.ExecuteScalar());
                command.CommandText = $"insert into law_act_person_link (R_LAW_ACT_ID, LINK_TYPE, PERSON_ROLE, PERSON_ID) values ({id},1,1,(select r_person_id from law_act where id = {id}));";
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Банкротство успешно создано!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((comboBox5.Text == " ") || (comboBox5.Text == ""))
                MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
            else
            {
                StreamWriter sw = new StreamWriter(path_to_list, true);
                sw.WriteLine($"{comboBox5.Text}");
                sw.Close();
                List<string> spis = File.ReadLines(path_to_list).ToList();
                comboBox5.DataSource = spis;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((comboBox8.Text == " ") || (comboBox8.Text == ""))
                MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
            else
            {
                StreamWriter sw = new StreamWriter(path_to_list_adr, true);
                sw.WriteLine($"{comboBox8.Text}");
                sw.Close();
                List<string> spis1 = File.ReadLines(path_to_list_adr).ToList();
                comboBox8.DataSource = spis1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((comboBox9.Text == " ") || (comboBox9.Text == ""))
                MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
            else
            {
                File.AppendAllText(path_to_list_otprav, comboBox9.Text + "\n");
                List<string> spis2 = File.ReadLines(path_to_list_otprav).ToList();
                comboBox9.DataSource = spis2;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = textBox11.Text.Replace("\t", " ").Replace("\r\n", " ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool convert = false;
            if (checkBox1.Checked == true)
                convert = true;
            bool nal_skan = false;
            if (checkBox2.Checked == true)
                nal_skan = true;
            Settings.conv = convert;
            Settings.nal_skan = nal_skan;
            Settings.adr_otp = comboBox8.Text;
            Settings.otprav = comboBox9.Text;
            Settings.doc_name = comboBox5.Text;
            Settings.date_post = dateTimePicker1.Value.ToShortDateString();
            OtherDocs f = new OtherDocs(Settings.mode);
            if (Settings.mode < 1)
                Settings.mode = 1;
            f.mode = Settings.mode;
            f.Show();
        }

        private void LoadList()
        {

            try
            {
                var vm = new { token = Settings.token, action = "users" };
                string old_text = comboBox7.Text;
                var request = new RestRequest("/123").AddJsonBody(vm);
                var response = Program.client.Post<List<ServerUser>>(request);
                if (response.Count > 0)
                {
                    Users.DataSource = response;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Ошибка при получении данных:{ee}");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (button10.Text)
            {
                case "Открыть":
                    if (currentPort.IsOpen)
                        currentPort.Close();
                    currentPort.PortName = comboBox4.Text;
                    try
                    {
                        currentPort.Open();
                        button10.Text = "Закрыть";
                        comboBox4.Enabled = false;
                    }
                    catch
                    {
                        currentPort.Close();
                        MessageBox.Show("Сканер не обнаружен");
                    }
                    break;
                case "Закрыть":
                    comboBox4.Enabled = true;
                    currentPort.Close();
                    button10.Text = "Открыть";
                    break;

            }
        }

        private void SelectModeEvent(object sender, EventArgs e)
        {
            var m = sender as ComboBox;
            if (m.SelectedValue != null)
                Settings.mode = (int)m.SelectedValue;
            if (m.SelectedValue != null)
                if ((int)m.SelectedValue == 2 || (int)m.SelectedValue == 3)
                {
                    comboBox8.Enabled = false;
                }
                else
                {
                    comboBox8.Enabled = true;
                }
        }


        //public bool SberAdder()
        //{
        //    try
        //    {
        //        if (!String.IsNullOrEmpty(textBox21.Text) && !String.IsNullOrEmpty(textBox23.Text) && !String.IsNullOrEmpty(textBox19.Text) && !String.IsNullOrEmpty(textBox20.Text) && !String.IsNullOrEmpty(textBox8.Text) && !String.IsNullOrEmpty(maskedTextBox12.Text) && !String.IsNullOrEmpty(textBox16.Text) && !String.IsNullOrEmpty(comboBox9.Text) && !String.IsNullOrEmpty(comboBox8.Text)) {
        //        string fl = FilePath();
        //        List<string> stringer = File.ReadAllLines(fl).ToList();
        //        string r = "[ \t]+";
        //        string f1 = $"|id = 1 |osblist = 9042 |actype = 2 |ispnum = {textBox8.Text.Replace("№", string.Empty)} |ISPdate = {maskedTextBox12.Text} |ExecNum = {textBox16.Text} " +
        //                    $"|Debtorlastname = {textBox1.Text} |DebtorFirstName= {textBox2.Text} |DebtorSecondName= {textBox3.Text} |debtorbirth = {textBox18.Text} " +
        //                    $"|PassportSeries = {textBox19.Text} |PassportNum = {textBox20.Text} |debtorBirthAddres = {textBox21.Text} " +
        //                    $"|debtorAddres = {textBox22.Text.Replace("\r\n", string.Empty).Replace(";", string.Empty).Replace("\n", string.Empty)} |bailiff= Купцов Андрей Владимирович/8 (912) 82-81-87 " +
        //                    $"|summ = {textBox23.Text} |orgName= {comboBox9.Text} |OrgAddress= {comboBox8.Text.Replace("\r\n", string.Empty)} " +
        //                    $"|receivTitle = ООО «НБК» |receivAddres = 610001, г Киров, ул. Красина д.5 к.4 |inn = 4345197098 |kpp = 434501001 " +
        //                    $"|account = 40702810700130009755 |ls = null |bik = 043304711 |korrAcc = 30101810100000000711 |bankname = ОАО КБ «ХЛЫНОВ» " +
        //                    $"|kbk = null |oktmo = null |uin = null |debtorinn = |accountCurrency= rub" + "\r\n";
        //        string f2 = $"|id = {stringer.Count + 1} |osblist = 9042 |actype = 2 |ispnum = {textBox8.Text.Replace("№", string.Empty)} |ISPdate = {maskedTextBox12.Text} |ExecNum = {textBox16.Text} " +
        //                    $"|Debtorlastname = {textBox1.Text} |DebtorFirstName= {textBox2.Text} |DebtorSecondName= {textBox3.Text} |debtorbirth = {textBox18.Text} " +
        //                    $"|PassportSeries = {textBox19.Text} |PassportNum = {textBox20.Text} |debtorBirthAddres = {textBox21.Text} " +
        //                    $"|debtorAddres = {textBox22.Text.Replace("\r\n", string.Empty).Replace(";", string.Empty).Replace("\n", string.Empty)} |bailiff= Купцов Андрей Владимирович/8 (912) 82-81-87 " +
        //                    $"|summ = {textBox23.Text} |orgName= {comboBox9.Text} |OrgAddress= {comboBox8.Text.Replace("\r\n", string.Empty)} " +
        //                    $"|receivTitle = ООО «НБК» |receivAddres = 610001, г Киров, ул. Красина д.5 к.4 |inn = 4345197098 |kpp = 434501001 " +
        //                    $"|account = 40702810700130009755 |ls = null |bik = 043304711 |korrAcc = 30101810100000000711 |bankname = ОАО КБ «ХЛЫНОВ» " +
        //                    $"|kbk = null |oktmo = null |uin = null |debtorinn = |accountCurrency= rub" + "\r\n";
        //        f1 = Regex.Replace(f1, r, " ").Replace(";", string.Empty);
        //        f2 = Regex.Replace(f2, r, " ").Replace(";", string.Empty);
        //        if (stringer.Count == 0)
        //        {
        //            File.AppendAllText(fl, f1);
        //        }
        //        else
        //        {
        //            File.AppendAllText(fl, f2);
        //        }
        //        return true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Заполнены не все поля для создания файла для Сбербанка");
        //            return false;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        //private string FilePath()
        //{
        //    string currentDate = DateTime.Now.Date.ToString().Split(' ')[0];
        //    string fl = $"\\\\192.168.0.162\\source\\Сбер_запрос" + $"\\{currentDate}" + $"\\Result {Settings.username}.txt";
        //    if (!Directory.Exists($"\\\\192.168.0.162\\source\\Сбер_запрос" + $"\\{currentDate}"))
        //        Directory.CreateDirectory($"\\\\192.168.0.162\\source\\Сбер_запрос" + $"\\{currentDate}");
        //    if (!File.Exists(fl))
        //        File.Create(fl).Close();
        //    return fl;
        //}
    }
}
