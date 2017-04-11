using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;
using MCSSLibNet;
using M3PSSLibNetCla;
using System.Runtime.InteropServices;  
using System.Threading;              
using System.Text.RegularExpressions;

namespace DCT
{
    public partial class StartForm : Form
    {
        public MCSSLibNet.ScannerControl ScanCtrl;
        public M3PSSLibNetCla.ScannerControl ScanCtrl2;
        public bool m_bReading;
        public bool m_bKeyFlag;
        public bool m_bSyncMode;
        public bool m_bResult;
        public int m_nResult;

        public bool Scan_MC = false;
        public bool Scan_M3 = false;

        public DataForm _DataForm;

        public string src;
        public string dect;

        public StartForm()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            _DataForm = new DataForm();

            _DataForm.FormBorderStyle = FormBorderStyle.None;

            _DataForm._StartForm = this;
            _DataForm.txArticle.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.txArticle.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.txPlace.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.txPlace.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.numb.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.numb.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.txCount.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.txCount.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.lbPlace.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.lbPlace.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.txNumb.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.txNumb.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.txPrice.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.txPrice.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.buttonAdd.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.buttonAdd.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.tBarcode.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.tBarcode.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.Page.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.Page.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.pBarcode.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.pBarcode.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.pGetting.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.pGetting.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.pSpec.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.pSpec.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.dgSpec.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.dgSpec.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.pProof.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.pProof.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_article.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_article.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_goods.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_goods.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_price.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_price.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_edism.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_edism.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_sut.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_sut.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_prod.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_prod.KeyUp += Tab_M3Scanner_KeyUp;

            _DataForm.check_summ.KeyDown += Tab_M3Scanner_KeyDown;
            _DataForm.check_summ.KeyUp += Tab_M3Scanner_KeyUp;
             
            // от сканера   
            ScanCtrl = new MCSSLibNet.ScannerControl();
            ScanCtrl2 = new M3PSSLibNetCla.ScannerControl();
            ScanCtrl.ScannerDataEvent += new MCSSLibNet.ScannerDataDelegate(OnScanRead);
            ScanCtrl2.ScannerDataEvent += new M3PSSLibNetCla.ScannerDataDelegate(OnScanRead2);
        }

        private void doc_num_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            Application.Exit();
        }

        private void fio_ParentChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fio_doc_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = true;
        }

        private void num_doc_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = true;
        }

        private void combobox_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;
        }

        private void doc_list_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;
        }

        private void next_btn_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void add_btn_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            DialogResult result;
            if (fio_doc.Text == "" || num_doc.Text == "" || combobox.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните пустые поля!");
                return;
            }

            /* */
            string f = fio_doc.Text;
            string n = num_doc.Text;
            string p = combobox.Text;
            /* */

            try
            {
                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                string value = p + '_' + f + '_' + n; 
                cmd.CommandText = "SELECT name FROM documents WHERE name = \'" + value + "\' ";

                SqlCeDataReader myReader = null;
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader["name"].ToString() == value)
                    {
                        MessageBox.Show("Документ с таким именем уже существует!");
                        conn.Close();
                        return;
                    }

                }

            }
            catch
            {
                MessageBox.Show("Ошибка 0cx00. Пожалуйста сообщите об этом системному администратору!");
                return;
            }

            

            result = MessageBox.Show("Начать работу с новым документом ?", "Новый документ:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO documents(name, type, docid) values(\'" + p + '_' + f + '_' + n + "\', \'" + p + "\', \'" + n + "\')";

                cmd.ExecuteNonQuery();

                fio_doc.Text = "";
                num_doc.Text = "";
                combobox.Text = "";
                doc_list.Items.Add(p + '_' + f + '_' + n);
                doc_list.SelectedIndex = doc_list.Items.Count - 1;

                conn.Close();

                next_btn_Click(sender, e);
            }
            else
            {
                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO documents(name, type, docid) values(\'" + p + '_' + f + '_' + n + "\', \'" + p + "\', \'" + n + "\')";

                cmd.ExecuteNonQuery();

                fio_doc.Text = "";
                num_doc.Text = "";
                combobox.Text = "";
                doc_list.Items.Add(p + '_' + f + '_' + n);
                doc_list.SelectedIndex = doc_list.Items.Count - 1;

                conn.Close();
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (doc_list.SelectedIndex != -1)
            {
                string typer = "";
                if (doc_list.Items[doc_list.SelectedIndex].ToString() != "")
                {
                    try
                    {
                        SqlCeConnection conn = null;
                        conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                        conn.Open();
                        SqlCeCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT * FROM documents where name=\'" + doc_list.Items[doc_list.SelectedIndex].ToString() + "\'";

                        SqlCeDataReader myReader = null;
                        myReader = cmd.ExecuteReader();

                        doc_list.Items.Clear();

                        while (myReader.Read())
                        {
                            if (myReader["id"].ToString() != "")
                            {
                                _DataForm.doc_id = myReader["id"].ToString();
                                _DataForm.typer = myReader["type"].ToString();
                                _DataForm.namer = myReader["name"].ToString();
                                string[] named = myReader["name"].ToString().Split('_');
                                _DataForm.family = named[1];
                                _DataForm.who_set.Text = named[1].ToUpper();

                                typer = myReader["type"].ToString();
                                break;
                            }
                        }
                        conn.Close();
                    }
                    catch
                    {
                    }
                    input_go.Enabled = false;
                    _DataForm.Show();
                    if (typer != "Проверка цен")
                    {
                        _DataForm.Page.SelectedIndex = 0;
                    }
                    else _DataForm.Page.SelectedIndex = 4;
                    this.Hide();
                }
            }
        }

        private bool FileCompare(string file1, string file2)
        {
            FileInfo f1 = new FileInfo(file1);
            FileInfo f2 = new FileInfo(file2);

            string updstr = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\update.ini";


            if (!File.Exists(updstr))
            {
                string s = f1.Length.ToString();
                StreamWriter SW = new StreamWriter(new FileStream(updstr, FileMode.Create, FileAccess.Write));
                SW.Write(s);
                SW.Close();
                return false;
            }
            else
            {
                StreamReader SR = new StreamReader(new FileStream(updstr, FileMode.Open, FileAccess.Read));

                string updver = SR.ReadLine();

                string s = f1.Length.ToString();

                SR.Close();

                if (updver == s)
                {
                    return true;
                }
                else
                {
                    try
                    {
                        File.Delete(updstr);
                    }
                    catch { }
                    StreamWriter SW = new StreamWriter(new FileStream(updstr, FileMode.Create, FileAccess.Write));
                    SW.Write(s);
                    SW.Close();
                    return false;
                }
            }   
        }

        private string GetString(string param, string file)
        {
            try
            {
                StreamReader fs = new StreamReader(file);
                string s = "";
                while (s != null)
                {
                    s = fs.ReadLine();
                    string[] text = s.Split('=');
                    if (text[0] == param)
                    {
                        return text[1];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы используете не полную версию программы. Пожалуйста сообщите об этом системному администратору!");
                return "";
            }
            return "";
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Начать обновление базы ?", "База данных:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes) return;
               
            string bdname = GetString("name", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+"\\get.ini");
            string path = GetString("path", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+"\\get.ini");

            src = @path+bdname;
            dect = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + bdname;


            if (!File.Exists(src))
            {
                MessageBox.Show("Файлы обновления недоступны. Пожалуйста включите WiFi или локальную сеть!");
                return;
            }

            if (File.Exists(dect))
            {
                if (FileCompare(src, dect))
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Вы используете актуальную версию базы.\nОбновление не требуется!");
                    return;
                }
                else
                {
                    try
                    {
                        File.Delete(dect);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка! Файл \n" + dect + "\n не был удалён. Удалите его вручную.");
                    }
                }
            }
            else
            {
                FileInfo f1 = new FileInfo(src);
                string updstr = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\update.ini";
                try
                {
                    File.Delete(updstr);
                }
                catch { }
                string s = f1.Length.ToString();
                StreamWriter SW = new StreamWriter(new FileStream(updstr, FileMode.Create, FileAccess.Write));
                SW.Write(s);
                SW.Close();
            }

            uploader.Visible = true;

            CustomFileCopier fc = new CustomFileCopier(src, dect);

            fc.OnProgressChanged += new ProgressChangeDelegate(fc_OnProgressChanged);
            fc.OnComplete += new Completedelegate(fc_OnComplete);
            uploader.Value = 0;

            AsyncMethodCaller caller = new AsyncMethodCaller(fc.Copy);
            uploader.BeginInvoke(caller);
        }

        void fc_OnComplete(bool canceled)
        {
            if (!canceled)
            {
                try
                {
                    SqlCeConnection conn = null;
                    conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\xxx.sdf; Persist Security Info=False");
                    conn.Open();
                    SqlCeCommand cmd = new SqlCeCommand("CREATE INDEX _dwwee ON dwwee(strihkod, article, names, clPlace, price, clQty, clEdlsm, name, quantity, salerate, saleq, summ, mesname);", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch
                {
                }
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(500);
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(500);
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(500);
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(500);
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(500);
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(500);

                MessageBox.Show("Обновление базы прошло успешно!");
                uploader.Visible = false;


            }
        }

        void fc_OnProgressChanged(double Persentage, ref bool Cancel)
        {
            try
            {
                uploader.Value = (int)Persentage;
            }
            catch
            {
                System.Media.SystemSounds.Question.Play();
                string updstr = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\update.ini";
                try
                {
                    File.Delete(updstr);
                }
                catch { }
                MessageBox.Show("Ошибка! Загрузка обновления была прервана.");
                uploader.Visible = false;
            }
        }

        private void fio_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (e.KeyChar != 8 && (l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void num_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (num_doc.Text.Length < 2)
            {
                if (e.KeyChar != 8 && (l < 'А' || l > 'я') && l != '\b' && l != '.') e.Handled = true;
            }
            else
            {
                if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) e.Handled = true;
            }
        }

        private void num_doc_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void fio_doc_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StartForm_Activated(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM documents";

                SqlCeDataReader myReader = null;
                myReader = cmd.ExecuteReader();

                doc_list.Items.Clear();

                while (myReader.Read())
                {
                    doc_list.Items.Add(myReader["name"].ToString());
                }
                doc_list.SelectedIndex = doc_list.Items.Count - 1;

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Установлена поврежденная версия DCT. Пожалуйста сообщите об этом системному администратору!");
                input_go.Enabled = false;
                Application.Exit();
            }
        }

        public void OnScanRead(object sender, MCSSLibNet.ScannerDataArgs e)
        {
            try
            {
                if (e.ScanData != "")
                {
                    if (_DataForm.Page.SelectedIndex == 0 || _DataForm.Page.SelectedIndex == 1 || _DataForm.Page.SelectedIndex == 2)
                    {
                        _DataForm.editable = false;
                        _DataForm.tBarcode.Text = e.ScanData;
                        _DataForm.FindBarcode(e.ScanData);
                    }
                    if (_DataForm.Page.SelectedIndex == 4)
                    {
                        _DataForm.FindPricer(e.ScanData);
                    }
                }
            }
            catch
            {
            }

            m_bReading = false;
        }

        public void OnScanRead2(object sender, M3PSSLibNetCla.ScannerDataArgs e)
        {
            try
            {
                if (e.ScanData != "")
                {
                    if (_DataForm.Page.SelectedIndex == 0 || _DataForm.Page.SelectedIndex == 1 || _DataForm.Page.SelectedIndex == 2)
                    {
                        _DataForm.editable = false;
                        _DataForm.tBarcode.Text = e.ScanData;
                        _DataForm.FindBarcode(e.ScanData);
                    }
                    if (_DataForm.Page.SelectedIndex == 4)
                    {
                        _DataForm.FindPricer(e.ScanData);
                    }
                }
            }
            catch
            {
            }

            m_bReading = false;
        }

        public void ScanRead()
        {
            if (m_bReading == true)
            {
                if (Scan_MC)
                {
                    ScanCtrl.ScanReadCancel();
                }
                if (Scan_M3)
                {
                    ScanCtrl2.ScanReadCancel();
                }
                m_bReading = false;
                return;
            }

            m_bReading = false;

            if (Scan_MC)
            {
                ScanCtrl.ScanRead();
            }
            if (Scan_M3)
            {
                ScanCtrl2.ScanRead();
            }
        }

        public void Tab_M3Scanner_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F22)
            {
                if (m_bKeyFlag == true)
                {
                    m_bKeyFlag = false;
                    if (m_bSyncMode == false)
                    {
                        if (Scan_MC)
                        {
                            ScanCtrl.ScanReadCancel();
                        }
                        if (Scan_M3)
                        {
                            ScanCtrl2.ScanReadCancel();
                        }
                        Thread.Sleep(10);
                        m_bReading = false;
                    }
                }
            }
        }

        public void Tab_M3Scanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F22)
            {
                if (m_bKeyFlag == false)
                {
                    m_bKeyFlag = true;
                    ScanRead();
                    Thread.Sleep(10);
                }
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            try
            {
                // инициализация сканера
                m_nResult = ScanCtrl.ScanInit();
                if (m_nResult != 0)
                {
                    try
                    {
                        if (!ScanCtrl2.ScanOpen())
                        {
                            MessageBox.Show("Ошибка инициализации сканера!");
                        }
                        else
                        {
                            Scan_M3 = true;
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    Scan_MC = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка инициализации DLL сканера!");
            }
        }

        private void uploader_ParentChanged(object sender, EventArgs e)
        {

        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void num_doc_TextChanged(object sender, EventArgs e)
        {
            num_doc.Text = num_doc.Text.ToUpper();
            num_doc.SelectionStart = num_doc.Text.Length;
        }

        private void fio_doc_TextChanged(object sender, EventArgs e)
        {
            fio_doc.Text = fio_doc.Text.ToUpper();
            fio_doc.SelectionStart = fio_doc.Text.Length;
        }
    }
}