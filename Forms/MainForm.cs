using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Dialogs;
using DocumentAdder.Main;
using DocumentAdder.Models;
using DocumentAdder.Properties;
using DocumentAdder.Utils;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Windows.Forms;
using static DocumentAdder.Models.Adder;
using Action = System.Action;

namespace DocumentAdder.Forms;

public enum LawTyp
{
    LawAct,
    LawExec
}
public partial class MainForm : Form
{
    private static string path_to_list = Environment.CurrentDirectory + "\\Список_Для_Документов.txt";
    private static string path_to_list_adr = Environment.CurrentDirectory + "\\Список_Для_Адреса.txt";
    private static string path_to_list_otprav = Environment.CurrentDirectory + "\\Список_Для_Отправителя.txt";
    private static SerialPort currentPort = new SerialPort();
    private bool runed = false;
    private Dictionary<int, SettingsModel> settings_json = new();
    public DataModel current;
    private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        SerialPort sp = (SerialPort)sender;
        string indata = sp.ReadExisting();
        Action action = () =>
        {
            ClearTextBox();
            string given = indata;
            idBox.Text = given.Replace("\r", string.Empty);
            //Searcher searcher = new Searcher(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text)
            Searcher searcher = new Searcher(null, idBox.Text, "", "");
            searcher.GetTables(lawActResultBindingSource, lawExecResultBindingSource);
            if (dataGridView1.RowCount == 1)
            {
                var data = ((SortableBindingList<LawActResult>)lawActResultBindingSource.DataSource)[0];
                InstallData(data);
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
        ToolTip toolTip = new ToolTip();
        toolTip.SetToolTip(this.clearStatus, "Не менять статус");
        dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        current = new();
        dataModelBinding.DataSource = current;
        dataModelBinding.DataSourceChanged += dataModelBinding_dataModelChanged;
        current.PropertyChanged += Current_PropertyChanged;
    }

    private void Current_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        checkCurrent();
    }
    private void checkCurrent()
    {
        if (current.Id != null)
        {
            if (current.Data != null)
            {
                button2.Enabled = true;
                return;
            }
        }
        button2.Enabled = false;
    }

    private void dataModelBinding_dataModelChanged(object sender, EventArgs e)
    {
        var binding = (BindingSource)sender;
        var data = (DataModel)binding.DataSource;
        if (data.Data.Person != null)
        {
            textBoxF.Text = data.Data.Person.f;
            textBoxI.Text = data.Data.Person.i;
            textBoxO.Text = data.Data.Person.o;
        }
        if (data.Id != null)
        {
            idBox.Text = data.Id.ToString();

        }
        if (data.Data.Debt != null)
        {
            contractBox.Text = data.Data.Debt.contract;
        }
        execNumberSearchBox.Text = data.Exec_number;
        checkCurrent();
    }
    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (this.dataGridView1.Columns[e.ColumnIndex].Name == nameof(LawActStatus))
        {
            var data = (SortableBindingList<LawActResult>)lawActResultBindingSource.DataSource;
            var item = data[e.RowIndex];
            if (item.typ == 1)
            {
                if (item.status == null)
                    return;
                e.Value = Settings.dicts[getIntDict(item.typ.Value)][item.status.Value].name;
            }
            else if (item.typ > 1)
            {
                if (item.act_status == null)
                    return;
                e.Value = Settings.dicts[getIntDict(item.typ.Value)][item.act_status.Value].name;
            }

        }
    }
    public void Loader()
    {
        if (!runed)
        {
            this.Text = FromStart.DownloadInfo();
            List<CBMember> cBMembers = new List<CBMember>();
            Documents.DataSource = Adder.files;
            dictTyp.DataSource = Settings.dicts[405].Values.ToList();
            dictDebtStatus.DataSource = Settings.dicts[6].Values.ToList();
            dictState.DataSource = Settings.dicts[77].Values.ToList();
            cBMembers.Add(new CBMember() { name = "Входящая почта", value = 1 });
            cBMembers.Add(new CBMember() { name = "Госпочта", value = 2 });
            cBMembers.Add(new CBMember() { name = "Мейл(Суд)", value = 3 });
            cBMembers.Add(new CBMember() { name = "Мейл(ФССП)", value = 4 });
            cBMembers.Add(new CBMember() { name = "Мейл(ИНТЕРНЕТ-ПРИЕМНАЯ)", value = 5 });
            bindingSource1.DataSource = cBMembers;
            //ModeCB.DataSource = bindingSource1;

            LoadList();
            currentPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            comboBox4.DataSource = SerialPort.GetPortNames();

            if (File.Exists(path_to_list))
            {
                List<string> spis = File.ReadLines(path_to_list).ToList();
                documentNameBox.DataSource = spis;
            }
            else
            {
                File.CreateText(path_to_list);
            }
            if (File.Exists(path_to_list_adr))
            {
                List<string> spis1 = File.ReadLines(path_to_list_adr).ToList();
                postNameBox.DataSource = spis1;
            }
            else
            {
                File.CreateText(path_to_list_adr);
            }
            if (File.Exists(path_to_list_otprav))
            {
                List<string> spis2 = File.ReadLines(path_to_list_otprav).ToList();
                postAddressBox.DataSource = spis2;
            }
            else
            {
                File.CreateText(path_to_list_otprav);
            }
            Settings.json = Resources.config;
            panel1.AllowDrop = true;
            var o = JsonConvert.DeserializeObject<List<SettingsModel>>(Settings.json).ToDictionary(x => x.Id);
            settings_json = o;
            typDocBinding.DataSource = settings_json.Values.ToList();
            typDocBox.SelectedValue = null;
            //LoadPeople();
            runed = true;
        }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        receiptDateBox.Text = DateTime.Now.ToShortDateString();
        var settings = (SettingsModel)typDocBox.SelectedItem;
        currentEnableds.DataSource = settings;
        if (settings != null)
        {
            Settings.barcode = settings.Barcode;
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
        }
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
            Searcher searcher = new Searcher(new NamePerson() { f = textBoxF.Text, i = textBoxI.Text, o = textBoxO.Text }, idBox.Text, contractBox.Text, execNumberSearchBox.Text);
            searcher.GetTables(lawActResultBindingSource, lawExecResultBindingSource);
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
    private void InstallData(LawActResult data)
    {
        var typ = current.Typ_doc;
        var binding = createData(data.data);
        binding.Typ_doc = typ;
        var dict = getIntDict(binding.Data.LawAct.typ);
        dictStatus.DataSource = Settings.dicts[dict].Values.ToList();
        var settings = settings_json[typ];
        if (!(settings.without_act_status.ContainsKey(dict)
            && settings.without_act_status[dict].Contains(getIntStatus(data).Value))
            && settings.act_status.ContainsKey(data.typ.Value))
        {
            binding.Status = settings.act_status[data.typ.Value];
        }
        else
        {
            binding.Status = null;
        }

        if (settings.user_task != null)
        {
            binding.User_task = settings.user_task;
        }
        if (settings.document_name != null)
        {
            binding.Document_name = settings.document_name;
        }
        current = binding;
        dataModelBinding.DataSource = current;
        current.PropertyChanged += Current_PropertyChanged;
    }
    private int getIntDict(int? typ = 0)
    {
        if (typ == 1) return 18;
        else if (typ > 1) return 25;
        return 0;
    }
    private int? getIntStatus(LawActResult data)
    {
        if (data.typ == 1) return data.status;
        else if (data.typ > 1) return data.act_status;
        return data.act_status;
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        ClearTextBox();
        if (e.RowIndex >= 0)
        {
            var data = ((SortableBindingList<LawActResult>)lawActResultBindingSource.DataSource)[e.RowIndex];
            InstallData(data);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var testDialog = new Dialogs.DebtCalc(current.Typ, current.Id.Value);
        testDialog.Show();
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


        if (typDocBox.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                    || typDocBox.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                    || typDocBox.Text.Contains("ИЛ в НАШУ пользу")
                    || typDocBox.Text.Contains("Дубликат ИЛ в НАШУ пользу")
                    || typDocBox.Text.Contains("Дубликат ИД(Правопреемство)/Дубликат ИД + Определение о выдаче дубликата")
                    || typDocBox.Text.Contains("ИД/Дубликат ИД/Исп. надпись с ПОИП+АКТ (мы взыскатель)")
                    || typDocBox.Text.Contains("Постановление об отказе в возбуждении ИП с ИД")
                    )
        {

        }
        if (CheckMasked() == false)
        {
            MessageBox.Show("ДАТЫ не заполнены или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (typDocBox.Text.Contains("ПОВИП") && string.IsNullOrWhiteSpace(courtDocNumBox.Text))
        {
            MessageBox.Show("Поле № ИП не заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (typDocBox.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                   || typDocBox.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                   || typDocBox.Text.Contains("ИЛ в НАШУ пользу")
                   || typDocBox.Text.Contains("Дубликат ИЛ в НАШУ пользу")
                    || typDocBox.Text.Contains("Дубликат ИД(Правопреемство)/Дубликат ИД + Определение о выдаче дубликата")
                    || typDocBox.Text.Contains("ИД/Дубликат ИД/Исп. надпись с ПОИП+АКТ (мы взыскатель)")
                    || typDocBox.Text.Contains("Постановление об отказе в возбуждении ИП с ИД")
                    )
        {
            //TODO: надо исправить
            //var personInfo = new PersonInfo(current);
            //try
            //{
            //    var (error, message) = VTBAdder.CreateExcel();
            //    if (error)
            //    {
            //        MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    else
            //        VTBAdder.Add(personInfo);
            //}
            //catch
            //{
            //    MessageBox.Show(this, "Строчка не добавлена, скорее всего открыт Excel файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        using var db = Program.factory_db.CreateDbContext();
        using var transaction = db.Database.BeginTransaction();
        Data.Update(db, current, (SettingsModel)currentEnableds.DataSource);
        db.SaveChanges();
        int errors = 0;
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
                File.Copy(file_dir, segmentation + $"{typDocBox.SelectedItem.ToString().Replace("/", "")}" + $"\\Test{file}");
            }
            catch (Exception exeption)
            {
                File.AppendAllText(Environment.CurrentDirectory + "\\ErrorsSQL.txt", $"Файл: {file} не был сохранен. {exeption.Message}");
            }
            int result = GetSqlFile(db, new_file, free_dir.Split('\\').Last(), file);
            if (result > 0)
            {
                if (value == current.Doc_barcode)
                {
                    var doc = new ClientDoc() { doc = result, barcode = true, title = current.Exec_number, date = current.Data?.LawExec?.court_date?.ToShortDateString() };
                    if (current.Typ == LawTyp.LawExec)
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
                    docs.Add(new ClientDoc() { doc = result, barcode = false });
                }
            }
        }

        Adder.files.Clear();
        Documents.ResetBindings(true);
        int[] ints = { 2, 3, 4, 5 };

        if (ints.Contains(
        (int)ModeCB.SelectedValue))
        {
            Mail f = new Mail((int)ModeCB.SelectedValue, this, ref errors, checkBox3.Checked, docs, transaction);
            f.ShowDialog(this);
        }
        else
        {

            if (checkBox3.Checked == true)
            {
                newTask(errors, docs, transaction);
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
                    transaction.Commit();
                    MessageBox.Show("Успешно добавлено!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                }
                else
                {
                    transaction.Rollback();
                    MessageBox.Show($"Возникли непредвиденные ошибки\r\nКол-во: {errors}\r\nВсе ошибки находятся в ErrorsSQL.txt");
                }

                errors = 0;
            }
        }
    }

    public void newTask(int errors, List<ClientDoc> docs, IDbContextTransaction transaction)
    {
        var personInfo = new PersonInfo(current);
        Tasks f = new Tasks(ref errors, this, personInfo, docs, transaction);
        f.ShowDialog(this);
        ClearTextBox();
    }

    public object getRequest(string typ, List<ClientDoc> docs = null, MailModel mail = null)
    {
        docs = docs ?? new List<ClientDoc>();
        string desc = $"{textBox11.Text}";
        if (correctPeriodDateBox.Enabled == true)
            desc += $" {correctPeriodDateBox.Text}";
        var result = new
        {
            date_post = current.Date_post.ToString("o").Replace("+03:00", ""),
            Convert = current.Check,
            pristavi = current.Fssp,
            adr_otp = current.Post_address,
            otprav = current.Post_name,
            reestr = current.Data.Debt.portfolio,
            doc_name = current.Document_name,
            id_dela = current.Id,
            st_pnkt = current.Article_and_paragraph,
            gd = current.Exec_number,
            fio_dol = current.Data.Person.fio,
            kd = contractBox.Text,
            ispol_zadach = userTaskBox.Text,
            id_ispol_zadach = userTaskBox.SelectedValue,
            vsisk = current.Data.Debt.fio_vz,
            kto_obrabotal = Settings.username,
            id_kto_obrabotal = Settings.user_id,
            nal_skan = current.Scan,
            action = typ,
            user_id = current.User_task,
            template_id = current.Task_id,
            name = $"{current.Data.Person.fio} {current.Data.Debt.contract} {current.Data.Debt.portfolio}",
            desc = current.Dsc,
            mode = current.Mode,

            ist = mail?.Debtor,
            dateDoc = mail?.Court_date,
            ecp = mail?.Cert,
            adres = mail?.From_mail,
            mail = mail?.From_mail,
            docs
        };
        //result.dateDoc = Settings.dateDoc;
        return result;
    }

    private bool CheckMasked()
    {
        return true;
    }

    private string GetFreeDir()
    {
        using var db = Program.factory_db.CreateDbContext();
        int a = 0;
        string main_dir = db.ConstValue.Where(x => x.name == "DocAttach.SavePath").Select(x => x.value).First();
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


    private int GetSqlFile(i_collectContext db, string new_file, string index, string old_file)
    {
        if (current.Typ == LawTyp.LawAct)
        {
            var docAttach = new DatabaseContact.Models.DocAttach
            {
                obj_id = 46,
                r_id = current.Id.Value,
                name = old_file,
                filename = old_file,
                vers1 = 0,
                vers2 = 0,
                is_active = 1,
                r_user_id = Settings.user_id,
                dt = DateTime.Now,
                FILE_SERVER_NAME = new_file,
                REL_SERVER_PATH = index,
                CHANGE_DT = DateTime.Now,
                SAVE_MODE = 2,
            };
            db.DocAttach.Add(docAttach);
            db.LawActProtokol.Add(new LawActProtokol() { dt = DateTime.Now, typ = 23, parent_id = current.Id, r_user_id = Settings.user_id, dsc = $"Вложение: {old_file}" });
            db.SaveChanges();
            return docAttach.id;
        }
        else
        {

            var docAttach = new DatabaseContact.Models.DocAttach
            {
                obj_id = 47,
                r_id = current.Id.Value,
                name = old_file,
                filename = old_file,
                vers1 = 0,
                vers2 = 0,
                is_active = 1,
                r_user_id = Settings.user_id,
                dt = DateTime.Now,
                FILE_SERVER_NAME = new_file,
                REL_SERVER_PATH = index,
                CHANGE_DT = DateTime.Now,
                SAVE_MODE = 2,
            };
            db.DocAttach.Add(docAttach);
            db.LawExecProtokol.Add(new LawExecProtokol() { dt = DateTime.Now, typ = 9, parent_id = current.Id, r_user_id = Settings.user_id, dsc = $"Вложение: {old_file}" });
            db.SaveChanges();
            return docAttach.id;
        }
    }
    private DataModel createData(ActDataModel data)
    {
        return new DataModel(data, current.Date_post)
        {
            Document_name = current.Document_name,
            User_task = current.User_task,
            Scan = current.Scan,
            Fssp = current.Fssp,
            Task = current.Task,
            Check = current.Check
        };

    }
    private void InstallData(LawExecResult data)
    {
        var typ = current.Typ_doc;
        var binding = createData(data.data);
        binding.Typ_doc = typ;
        var settings = settings_json[typ];
        dictStatus.DataSource = Settings.dicts[77].Values.ToList();
        binding.Typ_doc = typ;
        if (!settings.without_exec_status.Contains(data.Status.Value) && settings.exec_status != null)
        {
            binding.Status = settings.exec_status;
        }
        else
        {
            binding.Status = null;
        }

        if (settings.user_task != null)
        {
            binding.User_task = settings.user_task;
        }
        if (settings.document_name != null)
        {
            binding.Document_name = settings.document_name;
        }
        current = binding;
        dataModelBinding.DataSource = current;
        current.PropertyChanged += Current_PropertyChanged;
    }

    private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        ClearTextBox();
        if (e.RowIndex >= 0)
        {
            var data = ((SortableBindingList<LawExecResult>)lawExecResultBindingSource.DataSource)[e.RowIndex];
            InstallData(data);
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var testDialog = new Dialogs.DocAttach(current.Typ, current.Id.Value);
        testDialog.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(idBox.Text, out var law_id))
            throw new Exception("ID дела неправильное");
        using var db = Program.factory_db.CreateDbContext();
        using var transaction = db.Database.BeginTransaction();
        if (string.IsNullOrWhiteSpace(idBox.Text))
        {
            MessageBox.Show("Невозможно создать банкротство без ID Дела\r\nаналогичного должника");
            return;
        }
        var person_id = db.LawAct.Where(x => x.id == law_id).Select(x => x.r_person_id).First();
        var LawAct = new LawAct()
        {
            r_person_id = person_id,
            typ = 4,
            fd = DateTime.Now,
            delivery_typ = 0,
            court_order_delivery = 0,
            status = 1,
            full_strength = 1,
            act_status = 1,
            deadline = DateTime.Now,
            currency = 1,
            load_dt = DateTime.Now,
            PRE_ACT_STATUS = 1
        };
        db.LawAct.Add(LawAct);
        db.SaveChanges();
        db.LawActPersonLink.Add(new LawActPersonLink() { PERSON_ID = person_id, LINK_TYPE = 1, PERSON_ROLE = 1, R_LAW_ACT_ID = LawAct.id });
        db.SaveChanges();
        transaction.Commit();
        MessageBox.Show("Банкротство успешно создано!");
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if ((documentNameBox.Text == " ") || (documentNameBox.Text == ""))
            MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
        else
        {
            StreamWriter sw = new StreamWriter(path_to_list, true);
            sw.WriteLine($"{documentNameBox.Text}");
            sw.Close();
            List<string> spis = File.ReadLines(path_to_list).ToList();
            documentNameBox.DataSource = spis;
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        if ((postNameBox.Text == " ") || (postNameBox.Text == ""))
            MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
        else
        {
            StreamWriter sw = new StreamWriter(path_to_list_adr, true);
            sw.WriteLine($"{postNameBox.Text}");
            sw.Close();
            List<string> spis1 = File.ReadLines(path_to_list_adr).ToList();
            postNameBox.DataSource = spis1;
        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        if ((postAddressBox.Text == " ") || (postAddressBox.Text == ""))
            MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
        else
        {
            File.AppendAllText(path_to_list_otprav, postAddressBox.Text + "\n");
            List<string> spis2 = File.ReadLines(path_to_list_otprav).ToList();
            postAddressBox.DataSource = spis2;
        }
    }

    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        textBox11.Text = textBox11.Text.Replace("\t", " ").Replace("\r\n", " ");
    }

    private void button9_Click(object sender, EventArgs e)
    {
        OtherDocs f = new OtherDocs(current);
        f.Show();
    }

    private void LoadList()
    {

        try
        {
            var vm = new { action = "users" };
            string old_text = userTaskBox.Text;
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
            if ((int)m.SelectedValue == 2 || (int)m.SelectedValue == 3)
            {
                postNameBox.Enabled = false;
            }
            else
            {
                postNameBox.Enabled = true;
            }
    }

    private void clearStatus_Click(object sender, EventArgs e)
    {
        statusBox.SelectedIndex = -1;
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
