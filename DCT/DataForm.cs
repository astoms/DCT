using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Xml.Serialization;

namespace DCT
{

    public partial class DataForm : Form
    {

        public bool editable = false;
        public string editable_id = "";

        private bool dc = false;
        private string place = "";

        public StartForm _StartForm;

        public string doc_id;
        public string typer;
        public string namer;

        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Page_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.SelectedIndex == 0)
            {
                tBarcode.Focus();
            }
            if (Page.SelectedIndex == 2)
            {
                GetSpec();
            }
            if (Page.SelectedIndex == 4)
            {
                who_get.Text = "";
                who_get.Focus();
            }
        }

        private void GetSpec(string Column, bool desc)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();

                DataTable t = new DataTable();
                string query = "";
                if (desc)
                {
                    query = "SELECT id, id_doc, numb, name, count_e, barcode, article, place, price FROM docSpec where id_doc=\'" + doc_id + "\' order by " + Column + " desc";
                }
                else
                {
                    query = "SELECT id, id_doc, numb, name, count_e, barcode, article, place, price FROM docSpec where id_doc=\'" + doc_id + "\' order by " + Column;
                }
                
                using (SqlCeDataAdapter a = new SqlCeDataAdapter(query, conn))
                {
                    a.Fill(t);
                    dgSpec.DataSource = t;
                }

                dgSpec.TableStyles.Clear();
                DataGridTableStyle tableStyle = new DataGridTableStyle();
                tableStyle.MappingName = t.TableName;
                foreach (DataColumn item in t.Columns)
                {
                    DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();
                    switch (item.ColumnName.ToLower())
                    {
                        case "id":
                            {
                                tbcName.Width = -1;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = item.ColumnName;
                                break;
                            }
                        case "id_doc":
                            {
                                tbcName.Width = -1;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = item.ColumnName;
                                break;
                            }
                        case "numb":
                            {
                                tbcName.Width = 20;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "№";
                                break;
                            }
                        case "name":
                            {
                                tbcName.Width = 120;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "наименование";
                                break;
                            }
                        case "count_e":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "кол-во";
                                break;
                            }
                        case "barcode":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "штрих-код";
                                break;
                            }
                        case "article":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "артикул";
                                break;
                            }
                        case "place":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "место";
                                break;
                            }
                        case "price":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "цена";
                                break;
                            }
                    }

                    tableStyle.GridColumnStyles.Add(tbcName);
                }
                dgSpec.TableStyles.Add(tableStyle);
            }
            finally
            {
                conn.Close();
            }
        }

        private void GetSpec()
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();

                DataTable t = new DataTable();
                using (SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT id, id_doc, numb, name, count_e, barcode, article, place, price FROM docSpec where id_doc=\'" + doc_id + "\'", conn))
                {
                    a.Fill(t);
                    dgSpec.DataSource = t;
                }

                dgSpec.TableStyles.Clear();
                DataGridTableStyle tableStyle = new DataGridTableStyle();
                tableStyle.MappingName = t.TableName;
                foreach (DataColumn item in t.Columns)
                {
                    DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();
                    switch (item.ColumnName.ToLower())
                    {
                        case "id":
                            {
                                tbcName.Width = -1;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = item.ColumnName;
                                break;
                            }
                        case "id_doc":
                            {
                                tbcName.Width = -1;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = item.ColumnName;
                                break;
                            }
                        case "numb":
                            {
                                tbcName.Width = 20;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "№";
                                break;
                            }
                        case "name":
                            {
                                tbcName.Width = 120;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "наименование";
                                break;
                            }
                        case "count_e":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "кол-во";
                                break;
                            }
                        case "barcode":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "штрих-код";
                                break;
                            }
                        case "article":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "артикул";
                                break;
                            }
                        case "place":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "место";
                                break;
                            }
                        case "price":
                            {
                                tbcName.Width = 50;
                                tbcName.MappingName = item.ColumnName;
                                tbcName.HeaderText = "цена";
                                break;
                            }
                    }

                    tableStyle.GridColumnStyles.Add(tbcName);
                }
                dgSpec.TableStyles.Add(tableStyle);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            _StartForm.Show();
            this.Hide();
        }

        private void Img_Src_Click(object sender, EventArgs e)
        {

        }

        private void listBoxPlace_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxKeyBoard_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void txPlace_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = true;
        }

        private void txArticle_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            txCount.Focus();
            lbPlace.Visible = false;
        }

        private void txCount_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            lbPlace.Visible = false;
        }

        private void txMesname_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = true;
            txCount.Focus();
        }

        private void txNumb_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            txCount.Focus();
            lbPlace.Visible = false;
        }

        private void txPrice_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            txCount.Focus();
            lbPlace.Visible = false;
        }

        private void txName_TextChanged(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            lbPlace.Visible = false;
        }

        private void pGetting_Click(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            lbPlace.Visible = false;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            input_go.Enabled = false;
            lbPlace.Visible = false;
            switch (typer)
            {
                case "Перемещение в зал":
                    {
                        if (txArticle.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не найден в базе.");
                            return;
                        }
                        if (txCount.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите количество.");
                            return;
                        }
                        break;
                    }
                case "Перемещение на склад":
                    {
                        if (txArticle.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не найден в базе.");
                            return;
                        }
                        if (txCount.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите количество.");
                            return;
                        }
                        if (txPlace.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите место хранения.");
                            return;
                        }
                        break;
                    }
                case "Приемка зал":
                    {
                        if (txArticle.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не найден в базе.");
                            return;
                        }
                        if (txCount.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите количество.");
                            return;
                        }
                        break;
                    }
                case "Приемка склад":
                    {
                        if (txArticle.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не найден в базе.");
                            return;
                        }
                        if (tBarcode.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не отсканирован.");
                            return;
                        }
                        if (txCount.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите количество.");
                            return;
                        }
                        if (txPlace.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите место хранения.");
                            return;
                        }
                        if (txPlace.Text.Length < 4)
                        {
                            MessageBox.Show("Ошибка добавления: Короткое имя места хранения.");
                            return;
                        }
                        if (txPlace.Text.Length > 4)
                        {
                            MessageBox.Show("Ошибка добавления: Длинное имя места хранения.");
                            return;
                        }
                        break;
                    }
                case "Инвентаризация":
                    {
                        if (txArticle.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не найден в базе.");
                            return;
                        }
                        if (txCount.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите количество.");
                            return;
                        }
                        break;
                    }
                case "Проверка цен":
                    {
                        if (txArticle.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Товар не найден в базе.");
                            return;
                        }
                        if (txCount.Text == "")
                        {
                            MessageBox.Show("Ошибка добавления: Введите количество.");
                            return;
                        }
                        break;
                    }
            }

            
            
                try
                {
                    if (editable)
                    {
                        SqlCeConnection conn = null;
                        conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                        conn.Open();
                        SqlCeCommand cmd = conn.CreateCommand();

                        cmd.CommandText = "DELETE FROM docSpec where id=\'"+ editable_id +"\'";
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        editable = false;
                        editable_id = "";
                    }
                    
                    SqlCeConnection conn3 = null;
                    conn3 = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                    conn3.Open();
                    SqlCeCommand cmd3 = conn3.CreateCommand();

                    cmd3.CommandText = "SELECT * FROM docSpec where article=\'" + txArticle.Text + "\' and id_doc =\'" + doc_id + "\'";
                    
                    SqlCeDataReader myReader = null;
                    myReader = cmd3.ExecuteReader();

                    double count_e = 0;

                    bool ext = false;

                    place = "";

                    while (myReader.Read())
                    {
                        ext = true;
                        try
                        {
                            count_e += Convert.ToDouble(myReader["count_e"].ToString());
                            place += myReader["place"].ToString();
                        }
                        catch
                        {
                        }
                    }

                    place += txPlace.Text + ';';

                    try
                    {
                        List<string> PL = new List<string>(); 
                        string[] pl = place.Split(';');
                        int j = 0;
                        while (j < pl.Length)
                        {
                            bool adv = false;
                            foreach (string value in PL)
                            {
                                if (value.ToUpper() == pl[j].ToUpper())
                                {
                                    adv = true;
                                    break;
                                }
                            }

                            if (adv == false) PL.Add(pl[j].ToUpper()); // 
                            j++;
                        }

                        place = "";

                        foreach (string value in PL)
                        {
                            if (value != "" && value != null) place += value + ';';
                        }

                    }
                    catch
                    {
                    }

                    conn3.Close();


                    if (ext)
                    {
                        if (txCount.Text == "") txCount.Text = "0";
                        count_e += Convert.ToDouble(txCount.Text);
                        SqlCeConnection conn2 = null;
                        conn2 = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                        conn2.Open();
                        SqlCeCommand cmd2 = conn2.CreateCommand();

                        cmd2.CommandText = "UPDATE docSpec set count_e = "+count_e.ToString()+", place = \'"+place.ToUpper()+"\' where id_doc = \'" + doc_id + "\' and article =\'" + txArticle.Text + "\' ";

                        cmd2.ExecuteNonQuery();

                        conn2.Close();
                    }
                    else
                    {
                        SqlCeConnection conn2 = null;
                        conn2 = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                        conn2.Open();
                        SqlCeCommand cmd2 = conn2.CreateCommand();

                        if (txCount.Text == "") txCount.Text = "0";

                        cmd2.CommandText = "INSERT INTO docSpec(id_doc, numb, name, count_e, barcode, article, place, price) values(\'" + doc_id + "\', \'" + numb.Text + "\', \'" + txName.Text + "\', \'" + txCount.Text + "\', \'" + tBarcode.Text + "\', \'" + txArticle.Text + "\', \'" + txPlace.Text.ToUpper() + ";\', \'" + txPrice.Text + "\')";

                        cmd2.ExecuteNonQuery();

                        conn2.Close();
                    }

                    
                    System.Media.SystemSounds.Hand.Play();
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    System.Media.SystemSounds.Question.Play();
                }
                txArticle.Text = "";
                txName.Text = "";
                txPlace.Text = "";
                lbPlace.Items.Clear();
                txCount.Text = "";
                txMesname.Text = "";
                txNumb.Text = "";
                txPrice.Text = "";
                numb.Text = "";
                txCount.Focus();
            /*
            else
            {
                DialogResult Res = MessageBox.Show("Отсутсвуют данные о товаре.\nИгнорировать и продолжить ?", "Внимание:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Res == DialogResult.Yes)
                {
                    try
                    {
                        if (editable)
                        {
                            SqlCeConnection conn = null;
                            conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                            conn.Open();
                            SqlCeCommand cmd = conn.CreateCommand();

                            cmd.CommandText = "DELETE FROM docSpec where id=\'" + editable_id + "\'";
                            cmd.ExecuteNonQuery();

                            conn.Close();
                            editable = false;
                            editable_id = "";
                        }
                        SqlCeConnection conn2 = null;
                        conn2 = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                        conn2.Open();
                        SqlCeCommand cmd2 = conn2.CreateCommand();

                        cmd2.CommandText = "INSERT INTO docSpec(id_doc, name, count_e, barcode, article, place, price) values(\'" + doc_id + "\', \'" + txName.Text + "\', \'" + txCount.Text + "\', \'" + tBarcode.Text + "\', \'" + txArticle.Text + "\', \'" + txPlace.Text + "\', \'" + txPrice.Text + "\')";

                        cmd2.ExecuteNonQuery();

                        conn2.Close();
                        System.Media.SystemSounds.Hand.Play();
                    }
                    catch
                    {
                        System.Media.SystemSounds.Question.Play();
                    }
                    txArticle.Text = "";
                    txName.Text = "";
                    txPlace.Text = "";
                    lbPlace.Items.Clear();
                    txCount.Text = "";
                    txMesname.Text = "";
                    txNumb.Text = "";
                    txPrice.Text = "";
                }
            }
            */
        }


        private void pbPlace_Click(object sender, EventArgs e)
        {
            txPlace.Focus();
            input_go.Enabled = false;           
            lbPlace.Visible = true; 
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
        }

        private void dgSpec_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgSpec_Click(object sender, EventArgs e)
        {
        }

        private void tBarcode_TextChanged(object sender, EventArgs e)
        {
        }

        public void FindPricer(string value)
        {
            if (value != "")
            {
                try
                {
                    SqlCeConnection conn = null;
                    conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\xxx.sdf; Persist Security Info=False");
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM dwwee where strihkod=\'" + value + "\'";

                    SqlCeDataReader myReader = null;
                    myReader = cmd.ExecuteReader();


                    bool ext_find = false;
                    while (myReader.Read())
                    {
                        if (value == myReader["strihkod"].ToString())
                        {
                            check_article.Text = myReader["article"].ToString();
                            check_names.Text = myReader["names"].ToString();
                            check_goods.Text = myReader["quantity"].ToString();
                            check_price.Text = myReader["Price"].ToString();
                            check_edism.Text = myReader["mesname"].ToString();
                            check_sut.Text = myReader["salerate"].ToString();
                            check_prod.Text = myReader["saleq"].ToString();
                            check_summ.Text = myReader["summ"].ToString();
                            ext_find = true;
                            break;
                        }
                    }

                    conn.Close();

                    if (ext_find == false)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        Page.SelectedIndex = 3;
                    }
                    else
                    {
                        System.Media.SystemSounds.Hand.Play();
                        Page.SelectedIndex = 3;
                    }
                }
                catch
                {
                    Page.SelectedIndex = 3;
                }
            }
        }

        public void FindBarcode(string value)
        {
            if (value != "")
            {
                try
                {
                    SqlCeConnection conn = null;
                    conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\xxx.sdf; Persist Security Info=False");
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM dwwee where strihkod=\'"+value+"\'";

                    SqlCeDataReader myReader = null;
                    myReader = cmd.ExecuteReader();


                    bool ext_find = false;
                    while (myReader.Read())
                    {
                        if (value == myReader["strihkod"].ToString())
                        {
                            txArticle.Text = myReader["article"].ToString();
                            string[] placer = myReader["clPlace"].ToString().Split(';');
                            lbPlace.Items.Clear();
                            lbPlace.Items.Add("");
                            foreach (string pl in placer)
                            {
                                lbPlace.Items.Add(pl);
                            }
                            txPlace.Text = "";
                            txCount.Text = "";
                            txName.Text = myReader["names"].ToString();
                            txNumb.Text = myReader["quantity"].ToString();
                            txPrice.Text = myReader["Price"].ToString();
                            txMesname.Text = myReader["mesname"].ToString();
                            ext_find = true;
                            break;
                        }
                    }

                    conn.Close();

                    if (ext_find == false)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        Page.SelectedIndex = 1;
                        txArticle.Text = "";
                        txName.Text = "";
                        txPlace.Text = "";
                        lbPlace.Items.Clear();
                        txCount.Text = "";
                        txMesname.Text = "";
                        txNumb.Text = "";
                        txPrice.Text = "";
                        numb.Text = "";
                        txCount.Focus();
                    }
                    else
                    {
                        System.Media.SystemSounds.Hand.Play();
                        Page.SelectedIndex = 1;
                        txCount.Focus();
                    }
                }
                catch
                {
                    Page.SelectedIndex = 1;
                }
            }
        }

        private void lbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            txPlace.Text = lbPlace.Items[lbPlace.SelectedIndex].ToString();
        }

        public string record_id;

        private void dgSpec_DoubleClick(object sender, EventArgs e)
        {
            DataGrid.HitTestInfo hit = dgSpec.HitTest(Control.MousePosition.X, Control.MousePosition.Y - 20);
            try
            {
                if (hit.Type == DataGrid.HitTestType.Cell)
                {
                    record_id = dgSpec[hit.Row, 0].ToString();
                    Point P = new Point(Control.MousePosition.X, Control.MousePosition.Y - 20);
                    MenuCont.Show(dgSpec, P);

                }
                else
                {
                    if (hit.Type == DataGrid.HitTestType.ColumnHeader)
                    {
                        if (dc)
                        {
                            dc = false;
                        }
                        else
                        {
                            dc = true;
                        }
                        switch (hit.Column)
                        {
                            case 2:
                            {
                                GetSpec("numb", dc);
                                break;
                            }
                            case 3:
                            {
                                GetSpec("name", dc);
                                break;
                            }
                            case 4:
                            {
                                GetSpec("count_e", dc);
                                break;
                            }
                            case 5:
                            {
                                GetSpec("barcode", dc);
                                break;
                            }
                            case 6:
                            {
                                GetSpec("article", dc);
                                break;
                            }
                            case 7:
                            {
                                GetSpec("place", dc);
                                break;
                            }
                            case 8:
                            {
                                GetSpec("price", dc);
                                break;
                            }

                            default: break;
                        }
                        
                    }
                }
            }
            catch
            { }
        }

        private void MenuCont_Popup(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (record_id != "")
            {
                string name = "";
                try
                {
                    SqlCeConnection conn = null;
                    conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * from docSpec where id=\'"+record_id+"\'";

                    SqlCeDataReader myReader = null;
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        name = myReader["name"].ToString();
                        break;
                    }

                    conn.Close();
                }
                catch
                {
                }
                DialogResult Res = MessageBox.Show(name, "Удалить запись ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Res == DialogResult.OK)
                {
                    try
                    {
                        SqlCeConnection conn = null;
                        conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                        conn.Open();
                        SqlCeCommand cmd = conn.CreateCommand();

                        cmd.CommandText = "DELETE FROM docSpec where id=\'"+record_id+"\'";

                        cmd.ExecuteNonQuery();

                        conn.Close();
                        System.Media.SystemSounds.Hand.Play();
                    }
                    catch
                    {
                        System.Media.SystemSounds.Question.Play();
                    }
                }
                Page.SelectedIndex = 0;
                Page.SelectedIndex = 2;
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (record_id != "")
            {
                editable = true;

                editable_id = record_id;

                try
                {
                    SqlCeConnection conn = null;
                    conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * from docSpec where id=\'" + record_id + "\'";

                    SqlCeDataReader myReader = null;
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        txArticle.Text = myReader["article"].ToString();
                        txName.Text = myReader["name"].ToString();
                        txPlace.Text = myReader["place"].ToString();
                        lbPlace.Items.Clear();
                        txCount.Text = myReader["count_e"].ToString();
                        txMesname.Text = "";
                        txNumb.Text = "";
                        numb.Text = myReader["numb"].ToString();
                        txPrice.Text = myReader["price"].ToString();
                        break;
                    }

                    conn.Close();
                }
                catch
                {
                }

                Page.SelectedIndex = 1;
            }
        }

        private void txCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != '.')
            {
                if (e.KeyChar == '#')
                {
                    txPlace.Focus();
                    e.Handled = true;
                }
                if (e.KeyChar == '*' && txCount.Text.IndexOf('.') == -1)
                {
                    txCount.Text += '.';
                    txCount.SelectionStart = txCount.Text.Length;
                    e.Handled = true;
                }
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.' && txCount.Text.IndexOf('.') >= 0) e.Handled = true;
            }
        }

        private void tBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) e.Handled = true;
        }

        private void tBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != System.Windows.Forms.Keys.F22)
            {
                if (tBarcode.Text.Length == 13 || e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    FindBarcode(tBarcode.Text);
                }
            }
        }

        private void pDoc_DoubleClick(object sender, EventArgs e)
        {
            if (version.Visible == false)
            {
                version.Visible = true;
            }
            else version.Visible = false;
        }

        private void dgSpec_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Отправить документ на сервер ?", "Передача документа:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes) return;

            string bdname = GetString("name", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+"\\get.ini");
            string path = GetString("path", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)+"\\get.ini");

            string src = @path+bdname;
            string dect = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + bdname;


            if (!File.Exists(src))
            {
                MessageBox.Show("Пожалуйста включите WiFi или локальную сеть!");
                return;
            }

            Page.Enabled = false;

            try
            {
                List<string> Grid = new List<string>();

                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();
                SqlCeCommand cmd = new SqlCeCommand("SELECT id, id_doc, numb, name, count_e, barcode, article, place, price FROM docSpec where id_doc = \'" + doc_id + "\'", conn);

                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (reader["id"].ToString() != "") { Grid.Add(reader["id"].ToString()); } else { Grid.Add("-"); };
                    if (reader["id_doc"].ToString() != "") { Grid.Add(reader["id_doc"].ToString()); } else { Grid.Add("-"); };
                    if (reader["numb"].ToString() != "") { Grid.Add(reader["numb"].ToString()); } else { Grid.Add("-"); };
                    if (reader["name"].ToString() != "") { Grid.Add(reader["name"].ToString()); } else { Grid.Add("-"); };
                    if (reader["count_e"].ToString() != "") { Grid.Add(reader["count_e"].ToString()); } else { Grid.Add("-"); };
                    if (reader["barcode"].ToString() != "") { Grid.Add(reader["barcode"].ToString()); } else { Grid.Add("-"); };
                    if (reader["article"].ToString() != "") { Grid.Add(reader["article"].ToString()); } else { Grid.Add("-"); };
                    if (reader["place"].ToString() != "") { Grid.Add(reader["place"].ToString()); } else { Grid.Add("-"); };
                    if (reader["price"].ToString() != "") { Grid.Add(reader["price"].ToString()); } else { Grid.Add("-"); };

                }

                XmlSerializer B = new XmlSerializer(Grid.GetType());

                TextWriter D = new StreamWriter(@path + "xml\\" + namer + "_[" + who_set.Text + "_" + who_get.Text + "]_" + DateTime.Now.ToString("dd_mm_yyyy_hh_mm_ss") + ".xml");

                B.Serialize(D, Grid);

                D.Close();

                conn.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Ошибка экспорта данных! Документ не был перемещен.\n"+exp.Message);
                Page.Enabled = true;
                return;
            }

            try
            {
                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();

                SqlCeCommand cmd = new SqlCeCommand("DELETE FROM docSpec where id_doc = \'" + doc_id + "\'", conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка связи с базой! [#1]");
            }

            try
            {
                SqlCeConnection conn = null;
                conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\yyy.sdf; Persist Security Info=False");
                conn.Open();

                SqlCeCommand cmd = new SqlCeCommand("DELETE FROM documents where id = \'" + doc_id + "\'", conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Ошибка связи с базой! [#2]");
            }

            MessageBox.Show("Документ ["+namer+"] был экспортирован!");
            Page.Enabled = true;
            _StartForm.Show();
            this.Hide();
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

        private void numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '#')
            {
                buttonAdd.Focus();
                e.Handled = true;
            }
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void txCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd_Click_1(sender, e);
            }

        }

        private void txPlace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd_Click_1(sender, e);
            }

        }

        private void txNumb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txPrice_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txNumb_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void numb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd_Click_1(sender, e);
            }

        }

        private void numb_GotFocus(object sender, EventArgs e)
        {
            input_go.Enabled = false;  
            lbPlace.Visible = false;
        }

        private void numb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txCount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txPlace_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txNumb_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txPrice_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void numb_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '#')
            {
                numb.Focus();
                e.Handled = true;
            }
        }

        private void txPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '#')
            {
                txCount.Focus();
                e.Handled = true;
            }
        }

        private void who_get_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void label5_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}