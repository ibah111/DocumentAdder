using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> spis = File.ReadLines(Environment.CurrentDirectory + "\\Список.txt").ToList();
            comboBox5.DataSource = spis;
            Settings.json = File.ReadAllText(Environment.CurrentDirectory + "\\Data\\config.json");
            panel1.AllowDrop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JObject o = JObject.Parse(Settings.json);
            for (int a = 0; a < o.Count; a++)
                comboBox1.Items.Add(o[(string)a.ToString()]["тип_документа"]);
            this.Text = FromStart.DownloadInfo();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox5.Text = DateTime.Now.ToShortDateString();
            string a = comboBox1.SelectedIndex.ToString();
            JObject o = JObject.Parse(Settings.json);
            textBox7.Enabled = (bool)o[a]["номер_кд"];
            textBox8.Enabled = (bool)o[a]["номер_дела"];
            textBox9.Enabled = (bool)o[a]["номер_ип"];
            textBox10.Enabled = (bool)o[a]["номер_испол"];
            maskedTextBox1.Enabled = (bool)o[a]["дата_вынесения_решения"];
            maskedTextBox2.Enabled = (bool)o[a]["дата_вступления_в_силу"];
            maskedTextBox3.Enabled = (bool)o[a]["дата_возбуждения"];
            maskedTextBox4.Enabled = (bool)o[a]["дата_пост_об_окончании_ип"];
            maskedTextBox5.Enabled = (bool)o[a]["дата_получения_агентством"];
            maskedTextBox6.Enabled = (bool)o[a]["дата_возврата"];
            maskedTextBox7.Enabled = (bool)o[a]["дата_ограничения_выезда"];
            maskedTextBox8.Enabled = (bool)o[a]["дата_отказа_в_возбуждении"];
            maskedTextBox9.Enabled = (bool)o[a]["дата_отмены_сп"];
            maskedTextBox10.Enabled = (bool)o[a]["дата_исполнения_недостатков"];
            maskedTextBox11.Enabled = (bool)o[a]["дата_и_время_сз"];
        }

        private void maskedTextBox8_EnabledChanged(object sender, EventArgs e)
        {
            if(sender is TextBox)
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
            if(e.KeyCode == Keys.Enter)
            {
                Searcher searcher = new Searcher(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                searcher.GetTables(dataGridView1, dataGridView2, dataSet1);
            }
            if (e.Control && e.KeyCode == Keys.D)
                ClearTextBox();
            if (e.Control && e.KeyCode == Keys.Q)
            {
                Adder.file.Clear();
                MessageBox.Show("Все файлы удалены!", "Удачно!");
            }
            if(e.Control && e.Shift && e.KeyCode == Keys.D)
            {
                ClearTextBox();
                Adder.file.Clear();
                MessageBox.Show("Все файлы удалены, Поля очищены!", "Удачно!");
            }
        }

        private void ClearTextBox()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = "";
                if ((control is MaskedTextBox) && (control.Name != "maskedTextBox12"))
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
                textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(); //Суд
                textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); //реестр
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); //взыск
                string vkl = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); //ID Дела
                string int_vkl = GetIntKvl(vkl);
                JObject o = JObject.Parse(Settings.json);
                string status_text = (string)o[comboBox1.SelectedIndex.ToString()]["вкладка_и_статус"][int_vkl];
                comboBox2.SelectedIndex = Convert.ToInt32(int_vkl);
                int status_get = GetStatusBible(status_text);
                if (status_get == 99999)
                    comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
                else
                    comboBox3.SelectedIndex = status_get - 1;
                maskedTextBox5.Text = DateTime.Now.ToShortDateString();
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
            if(!string.IsNullOrWhiteSpace(Settings.debt_id))
            {
                Form2 testDialog = new Form2();
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
                Adder.file.Add(file, file_name); //Путь до файла | Название файла
                MessageBox.Show($"Добавлен новый файл!\r\n\r\nНазвание файла: {file_name}\r\n\r\nПуть до файла: {file}\r\n\r\nВсего файлов: {Adder.file.Count}", "Добавлен файл!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(files.Length != 0)
            {
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            foreach (KeyValuePair<string, string> key in Adder.file)
                ls.Add($"Название файла: {key.Value}\r\nПуть: {key.Key}\r\n");
            MessageBox.Show($"Всего добавлено {Adder.file.Count} файлов\r\n\r\n" + string.Join("\r\n", ls));
            ls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(CheckMasked() == false)
            {
                MessageBox.Show("ДАТЫ не заполнены или заполнены некорректно!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            } 
            if(comboBox1.Text.Contains("ПОВИП") && string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Поле № ИП не заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox2.SelectedIndex == 4)
                Data.vkl_string = "law_exec";
            else
                Data.vkl_string = "law_act";
            Data.vkl_int = comboBox2.SelectedIndex;
            Data.id = textBox4.Text;

            List<string> ls= Data.Update(textBox7, textBox8, textBox9, textBox10,textBox11,
                maskedTextBox1, maskedTextBox2, maskedTextBox3, maskedTextBox4, maskedTextBox5,
                maskedTextBox6, maskedTextBox7, maskedTextBox8, maskedTextBox9, maskedTextBox10, maskedTextBox11,comboBox3.Text);
            ls.Add("\r\n\r\n");
            File.AppendAllText(Environment.CurrentDirectory + "\\SQL.txt", string.Join("\r\n", ls));
            int errors = 0;
            
            foreach(string str in ls)
            {
                try
                {
                    OdbcCommand command = new OdbcCommand(str);
                        command.Connection = Program.Conn;
                        command.ExecuteReader();
                }
                catch (Exception ex){ errors++; File.AppendAllText(Environment.CurrentDirectory + "\\ErrorsSQL.txt", $"{str}\r\n{ex.Message}\r\n\r\n"); }
            }
            
            foreach (KeyValuePair<string, string> key in Adder.file)
            {
                string file = key.Value; //Название файла.pdf
                string file_dir = key.Key; //Расположение файла
                string type = file.Split('.').Last(); //расширение файла
                string free_dir = GetFreeDir(); //свободная папка для залива
                Guid guid = Guid.NewGuid();
                string uuid = guid.ToString(); //НОВЫЙ GUID
                string new_file = uuid + $".{type}"; //guid.pdf
                File.Copy(file_dir, free_dir + $"\\{uuid}.{type}");
                string sql_file = GetSqlFile(new_file, free_dir.Split('\\').Last(), file);
                OdbcCommand command = new OdbcCommand(sql_file);
                    command.Connection = Program.Conn;
                    command.ExecuteReader();
            }
            Adder.file.Clear();
            if (errors == 0)
            {
                MessageBox.Show("Успешно добавлено!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*try
                {
                    WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
                    var vm = new { token = "123", date_post = textBox1.Text, Convert = textBox2.Text, adres_otprav = textBox3.Text, otprav = textBox4.Text };
                    var dataString = JsonConvert.SerializeObject(vm);
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    var response = client.UploadString(new Uri("http://192.168.0.20:1228/123"), "POST", dataString);
                }
                catch
                {
                    MessageBox.Show("Данные в таблицу не занесены!");
                }*/
            }
                
            else
                MessageBox.Show($"Возникли непредвиденные ошибки\r\nКол-во: {errors}\r\nВсе ошибки находятся в ErrorsSQL.txt");
        }

        private bool CheckMasked()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is MaskedTextBox)
                    if (control.Enabled == true && ((MaskedTextBox)control).MaskCompleted == false)
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
                    $"(46, {Data.id}, \'{old_file}\', \'{old_file}\', 1, 0, 1, {Settings.user_id}, getdate(), \'{new_file}\', \'\\{index}\\\',getdate(),2)\r\n" +
                    $"insert into law_act_protokol (dt,typ,parent_id,r_user_id,dsc) values (getdate(), 23, {Data.id}, {Settings.user_id}, \'Вложение: {old_file}\')";
            else
                return "insert into doc_attach " +
                    "(obj_id,r_id,name,filename,vers1,vers2,is_active,r_user_id,dt,FILE_SERVER_NAME,REL_SERVER_PATH,CHANGE_DT,SAVE_MODE) values " +
                    $"(47, {Data.id}, \'{old_file}\', \'{old_file}\', 1, 0, 1, {Settings.user_id}, getdate(), \'{new_file}\', \'\\{index}\\\',getdate(),2)" +
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
            textBox13.Text = dataGridView2.Rows[e.RowIndex].Cells[12].Value.ToString(); //Суд
            textBox15.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(); //реестр
            textBox14.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString(); //взыск
                JObject o = JObject.Parse(Settings.json);
            string status_text = (string)o[comboBox1.SelectedIndex.ToString()]["вкладка_и_статус"]["4"];
            comboBox2.SelectedIndex = 4;
            int status_get = GetStatusBible(status_text);
            if (status_get == 99999)
                comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
            else
                comboBox3.SelectedIndex = status_get - 1;
            maskedTextBox5.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.debt_id = textBox4.Text;
            Settings.vkl = comboBox2.SelectedIndex;
            if (!string.IsNullOrWhiteSpace(Settings.debt_id))
            {
                Form3 testDialog = new Form3();
                testDialog.Show();
            }
            else
                MessageBox.Show("Для поиска протокола необходим ID Дела", "Ошибка!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Невозможно создать банкротство без ID Дела\r\nаналогичного должника");
                return;
            }
            string sql = $"insert into law_act (r_person_id,typ,fd,delivery_typ,court_order_delivery,status,full_strength,act_status,deadline,currency,load_dt,PRE_ACT_STATUS) values ((select r_person_id from law_act where id = {textBox4.Text}),4,getdate(),0,0,1,1,1,getdate(),1,getdate(),1);" +
                $"SELECT SCOPE_IDENTITY();";
            OdbcCommand command = new OdbcCommand(sql);
                command.Connection = Program.Conn;
                int id = Convert.ToInt32(command.ExecuteScalar());
            command.CommandText = $"insert into law_act_person_link (R_LAW_ACT_ID, LINK_TYPE, PERSON_ROLE, PERSON_ID) values ({id},1,1,(select r_person_id from law_act where id = {id}));";
            command.ExecuteNonQuery();
            MessageBox.Show("Банкротство успешно создано!");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
