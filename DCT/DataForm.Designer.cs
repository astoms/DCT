namespace DCT
{
    partial class DataForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.Page = new System.Windows.Forms.TabControl();
            this.pBarcode = new System.Windows.Forms.TabPage();
            this.tBarcode = new System.Windows.Forms.TextBox();
            this.Img_Src = new System.Windows.Forms.PictureBox();
            this.pGetting = new System.Windows.Forms.TabPage();
            this.lbPlace = new System.Windows.Forms.ListBox();
            this.numb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPlace = new System.Windows.Forms.PictureBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.txNumb = new System.Windows.Forms.TextBox();
            this.txMesname = new System.Windows.Forms.TextBox();
            this.txCount = new System.Windows.Forms.TextBox();
            this.txPlace = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.Label();
            this.txArticle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pSpec = new System.Windows.Forms.TabPage();
            this.dgSpec = new System.Windows.Forms.DataGrid();
            this.pProof = new System.Windows.Forms.TabPage();
            this.check_summ = new System.Windows.Forms.TextBox();
            this.check_prod = new System.Windows.Forms.TextBox();
            this.check_sut = new System.Windows.Forms.TextBox();
            this.check_edism = new System.Windows.Forms.TextBox();
            this.check_price = new System.Windows.Forms.TextBox();
            this.check_goods = new System.Windows.Forms.TextBox();
            this.check_names = new System.Windows.Forms.Label();
            this.check_article = new System.Windows.Forms.TextBox();
            this.lbsummer = new System.Windows.Forms.Label();
            this.lbprod = new System.Windows.Forms.Label();
            this.lbsut = new System.Windows.Forms.Label();
            this.lbedism = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbgoods = new System.Windows.Forms.Label();
            this.lbnames = new System.Windows.Forms.Label();
            this.lbarticle = new System.Windows.Forms.Label();
            this.pDoc = new System.Windows.Forms.TabPage();
            this.who_set = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.who_get = new System.Windows.Forms.TextBox();
            this.lbprinal = new System.Windows.Forms.Label();
            this.lbsdal = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.input_go = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.MenuCont = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Page.SuspendLayout();
            this.pBarcode.SuspendLayout();
            this.pGetting.SuspendLayout();
            this.pSpec.SuspendLayout();
            this.pProof.SuspendLayout();
            this.pDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page
            // 
            this.Page.Controls.Add(this.pBarcode);
            this.Page.Controls.Add(this.pGetting);
            this.Page.Controls.Add(this.pSpec);
            this.Page.Controls.Add(this.pDoc);
            this.Page.Controls.Add(this.pProof);
            this.Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page.Location = new System.Drawing.Point(0, 0);
            this.Page.Name = "Page";
            this.Page.SelectedIndex = 0;
            this.Page.Size = new System.Drawing.Size(240, 290);
            this.Page.TabIndex = 0;
            this.Page.SelectedIndexChanged += new System.EventHandler(this.Page_SelectedIndexChanged);
            // 
            // pBarcode
            // 
            this.pBarcode.AutoScroll = true;
            this.pBarcode.BackColor = System.Drawing.Color.Bisque;
            this.pBarcode.Controls.Add(this.tBarcode);
            this.pBarcode.Controls.Add(this.Img_Src);
            this.pBarcode.Location = new System.Drawing.Point(0, 0);
            this.pBarcode.Name = "pBarcode";
            this.pBarcode.Size = new System.Drawing.Size(240, 267);
            this.pBarcode.Text = "Сканирование";
            // 
            // tBarcode
            // 
            this.tBarcode.BackColor = System.Drawing.Color.Bisque;
            this.tBarcode.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.tBarcode.Location = new System.Drawing.Point(13, 187);
            this.tBarcode.MaxLength = 22;
            this.tBarcode.Name = "tBarcode";
            this.tBarcode.Size = new System.Drawing.Size(210, 24);
            this.tBarcode.TabIndex = 2;
            this.tBarcode.TextChanged += new System.EventHandler(this.tBarcode_TextChanged);
            this.tBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBarcode_KeyUp);
            this.tBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBarcode_KeyPress);
            // 
            // Img_Src
            // 
            this.Img_Src.Image = ((System.Drawing.Image)(resources.GetObject("Img_Src.Image")));
            this.Img_Src.Location = new System.Drawing.Point(13, 7);
            this.Img_Src.Name = "Img_Src";
            this.Img_Src.Size = new System.Drawing.Size(210, 123);
            this.Img_Src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_Src.Click += new System.EventHandler(this.Img_Src_Click);
            // 
            // pGetting
            // 
            this.pGetting.BackColor = System.Drawing.Color.Bisque;
            this.pGetting.Controls.Add(this.lbPlace);
            this.pGetting.Controls.Add(this.numb);
            this.pGetting.Controls.Add(this.label4);
            this.pGetting.Controls.Add(this.pbPlace);
            this.pGetting.Controls.Add(this.txPrice);
            this.pGetting.Controls.Add(this.txNumb);
            this.pGetting.Controls.Add(this.txMesname);
            this.pGetting.Controls.Add(this.txCount);
            this.pGetting.Controls.Add(this.txPlace);
            this.pGetting.Controls.Add(this.txName);
            this.pGetting.Controls.Add(this.txArticle);
            this.pGetting.Controls.Add(this.label2);
            this.pGetting.Controls.Add(this.buttonAdd);
            this.pGetting.Controls.Add(this.label6);
            this.pGetting.Controls.Add(this.label5);
            this.pGetting.Controls.Add(this.label3);
            this.pGetting.Controls.Add(this.label1);
            this.pGetting.Location = new System.Drawing.Point(0, 0);
            this.pGetting.Name = "pGetting";
            this.pGetting.Size = new System.Drawing.Size(240, 267);
            this.pGetting.Text = "Прием";
            this.pGetting.Click += new System.EventHandler(this.pGetting_Click);
            // 
            // lbPlace
            // 
            this.lbPlace.BackColor = System.Drawing.Color.Bisque;
            this.lbPlace.Location = new System.Drawing.Point(156, 132);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(59, 72);
            this.lbPlace.TabIndex = 93;
            this.lbPlace.Visible = false;
            // 
            // numb
            // 
            this.numb.BackColor = System.Drawing.Color.Bisque;
            this.numb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.numb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numb.Location = new System.Drawing.Point(99, 162);
            this.numb.MaxLength = 8;
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(116, 24);
            this.numb.TabIndex = 83;
            this.numb.TextChanged += new System.EventHandler(this.numb_TextChanged);
            this.numb.GotFocus += new System.EventHandler(this.numb_GotFocus);
            this.numb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numb_KeyDown);
            this.numb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numb_KeyUp);
            this.numb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numb_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.Text = "Номер п/п:";
            // 
            // pbPlace
            // 
            this.pbPlace.Image = ((System.Drawing.Image)(resources.GetObject("pbPlace.Image")));
            this.pbPlace.Location = new System.Drawing.Point(190, 133);
            this.pbPlace.Name = "pbPlace";
            this.pbPlace.Size = new System.Drawing.Size(22, 22);
            this.pbPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlace.Click += new System.EventHandler(this.pbPlace_Click);
            // 
            // txPrice
            // 
            this.txPrice.BackColor = System.Drawing.Color.Bisque;
            this.txPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txPrice.Location = new System.Drawing.Point(183, 28);
            this.txPrice.Name = "txPrice";
            this.txPrice.ReadOnly = true;
            this.txPrice.Size = new System.Drawing.Size(42, 19);
            this.txPrice.TabIndex = 70;
            this.txPrice.GotFocus += new System.EventHandler(this.txPrice_GotFocus);
            this.txPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPrice_KeyDown);
            this.txPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPrice_KeyUp);
            this.txPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPrice_KeyPress);
            // 
            // txNumb
            // 
            this.txNumb.BackColor = System.Drawing.Color.Bisque;
            this.txNumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txNumb.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txNumb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txNumb.Location = new System.Drawing.Point(183, 8);
            this.txNumb.Name = "txNumb";
            this.txNumb.ReadOnly = true;
            this.txNumb.Size = new System.Drawing.Size(42, 19);
            this.txNumb.TabIndex = 69;
            this.txNumb.GotFocus += new System.EventHandler(this.txNumb_GotFocus);
            this.txNumb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNumb_KeyDown);
            this.txNumb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txNumb_KeyUp);
            this.txNumb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNumb_KeyPress);
            // 
            // txMesname
            // 
            this.txMesname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txMesname.BackColor = System.Drawing.Color.Bisque;
            this.txMesname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMesname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txMesname.Location = new System.Drawing.Point(187, 104);
            this.txMesname.Name = "txMesname";
            this.txMesname.ReadOnly = true;
            this.txMesname.Size = new System.Drawing.Size(25, 21);
            this.txMesname.TabIndex = 68;
            this.txMesname.GotFocus += new System.EventHandler(this.txMesname_GotFocus);
            // 
            // txCount
            // 
            this.txCount.BackColor = System.Drawing.Color.Bisque;
            this.txCount.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.txCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txCount.Location = new System.Drawing.Point(99, 102);
            this.txCount.MaxLength = 8;
            this.txCount.Name = "txCount";
            this.txCount.Size = new System.Drawing.Size(116, 24);
            this.txCount.TabIndex = 67;
            this.txCount.GotFocus += new System.EventHandler(this.txCount_GotFocus);
            this.txCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCount_KeyDown);
            this.txCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txCount_KeyUp);
            this.txCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCount_KeyPress);
            // 
            // txPlace
            // 
            this.txPlace.BackColor = System.Drawing.Color.Bisque;
            this.txPlace.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.txPlace.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txPlace.Location = new System.Drawing.Point(99, 132);
            this.txPlace.Name = "txPlace";
            this.txPlace.Size = new System.Drawing.Size(116, 24);
            this.txPlace.TabIndex = 66;
            this.txPlace.TextChanged += new System.EventHandler(this.txPlace_TextChanged);
            this.txPlace.GotFocus += new System.EventHandler(this.txPlace_GotFocus);
            this.txPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPlace_KeyDown);
            this.txPlace.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPlace_KeyUp);
            this.txPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPlace_KeyPress);
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txName.Location = new System.Drawing.Point(7, 46);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(218, 54);
            this.txName.TextChanged += new System.EventHandler(this.txName_TextChanged);
            this.txName.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // txArticle
            // 
            this.txArticle.BackColor = System.Drawing.Color.Bisque;
            this.txArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txArticle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txArticle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txArticle.Location = new System.Drawing.Point(76, 7);
            this.txArticle.Name = "txArticle";
            this.txArticle.ReadOnly = true;
            this.txArticle.Size = new System.Drawing.Size(58, 23);
            this.txArticle.TabIndex = 64;
            this.txArticle.GotFocus += new System.EventHandler(this.txArticle_GotFocus);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(7, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.Text = "Место:";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 210);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(208, 27);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Принять";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            this.buttonAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonAdd_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(134, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.Text = "Склад:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.Text = "Кол-во:";
            this.label5.ParentChanged += new System.EventHandler(this.label5_ParentChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.Text = "Наим-ие товара/Цена:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "Артикул:";
            // 
            // pSpec
            // 
            this.pSpec.BackColor = System.Drawing.Color.Bisque;
            this.pSpec.Controls.Add(this.dgSpec);
            this.pSpec.Location = new System.Drawing.Point(0, 0);
            this.pSpec.Name = "pSpec";
            this.pSpec.Size = new System.Drawing.Size(232, 264);
            this.pSpec.Text = "Спецификация";
            // 
            // dgSpec
            // 
            this.dgSpec.BackColor = System.Drawing.Color.Linen;
            this.dgSpec.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSpec.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.dgSpec.ForeColor = System.Drawing.Color.Black;
            this.dgSpec.GridLineColor = System.Drawing.Color.Bisque;
            this.dgSpec.HeaderBackColor = System.Drawing.Color.Peru;
            this.dgSpec.HeaderForeColor = System.Drawing.Color.Bisque;
            this.dgSpec.Location = new System.Drawing.Point(0, 0);
            this.dgSpec.Name = "dgSpec";
            this.dgSpec.RowHeadersVisible = false;
            this.dgSpec.SelectionBackColor = System.Drawing.Color.Black;
            this.dgSpec.SelectionForeColor = System.Drawing.Color.Bisque;
            this.dgSpec.Size = new System.Drawing.Size(232, 264);
            this.dgSpec.TabIndex = 0;
            this.dgSpec.DoubleClick += new System.EventHandler(this.dgSpec_DoubleClick);
            this.dgSpec.CurrentCellChanged += new System.EventHandler(this.dgSpec_CurrentCellChanged);
            this.dgSpec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgSpec_MouseMove);
            this.dgSpec.Click += new System.EventHandler(this.dgSpec_Click);
            // 
            // pProof
            // 
            this.pProof.BackColor = System.Drawing.Color.Bisque;
            this.pProof.Controls.Add(this.check_summ);
            this.pProof.Controls.Add(this.check_prod);
            this.pProof.Controls.Add(this.check_sut);
            this.pProof.Controls.Add(this.check_edism);
            this.pProof.Controls.Add(this.check_price);
            this.pProof.Controls.Add(this.check_goods);
            this.pProof.Controls.Add(this.check_names);
            this.pProof.Controls.Add(this.check_article);
            this.pProof.Controls.Add(this.lbsummer);
            this.pProof.Controls.Add(this.lbprod);
            this.pProof.Controls.Add(this.lbsut);
            this.pProof.Controls.Add(this.lbedism);
            this.pProof.Controls.Add(this.lbprice);
            this.pProof.Controls.Add(this.lbgoods);
            this.pProof.Controls.Add(this.lbnames);
            this.pProof.Controls.Add(this.lbarticle);
            this.pProof.Location = new System.Drawing.Point(0, 0);
            this.pProof.Name = "pProof";
            this.pProof.Size = new System.Drawing.Size(232, 264);
            this.pProof.Text = "Проверка цен";
            // 
            // check_summ
            // 
            this.check_summ.BackColor = System.Drawing.Color.Bisque;
            this.check_summ.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_summ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_summ.Location = new System.Drawing.Point(127, 223);
            this.check_summ.Name = "check_summ";
            this.check_summ.ReadOnly = true;
            this.check_summ.Size = new System.Drawing.Size(96, 23);
            this.check_summ.TabIndex = 15;
            // 
            // check_prod
            // 
            this.check_prod.BackColor = System.Drawing.Color.Bisque;
            this.check_prod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_prod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_prod.Location = new System.Drawing.Point(127, 196);
            this.check_prod.Name = "check_prod";
            this.check_prod.ReadOnly = true;
            this.check_prod.Size = new System.Drawing.Size(96, 23);
            this.check_prod.TabIndex = 14;
            // 
            // check_sut
            // 
            this.check_sut.BackColor = System.Drawing.Color.Bisque;
            this.check_sut.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_sut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_sut.Location = new System.Drawing.Point(127, 170);
            this.check_sut.Name = "check_sut";
            this.check_sut.ReadOnly = true;
            this.check_sut.Size = new System.Drawing.Size(96, 23);
            this.check_sut.TabIndex = 13;
            // 
            // check_edism
            // 
            this.check_edism.BackColor = System.Drawing.Color.Bisque;
            this.check_edism.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_edism.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_edism.Location = new System.Drawing.Point(127, 144);
            this.check_edism.Name = "check_edism";
            this.check_edism.ReadOnly = true;
            this.check_edism.Size = new System.Drawing.Size(96, 23);
            this.check_edism.TabIndex = 12;
            // 
            // check_price
            // 
            this.check_price.BackColor = System.Drawing.Color.Bisque;
            this.check_price.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_price.Location = new System.Drawing.Point(127, 118);
            this.check_price.Name = "check_price";
            this.check_price.ReadOnly = true;
            this.check_price.Size = new System.Drawing.Size(96, 23);
            this.check_price.TabIndex = 11;
            // 
            // check_goods
            // 
            this.check_goods.BackColor = System.Drawing.Color.Bisque;
            this.check_goods.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_goods.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_goods.Location = new System.Drawing.Point(127, 91);
            this.check_goods.Name = "check_goods";
            this.check_goods.ReadOnly = true;
            this.check_goods.Size = new System.Drawing.Size(96, 23);
            this.check_goods.TabIndex = 10;
            // 
            // check_names
            // 
            this.check_names.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_names.Location = new System.Drawing.Point(7, 53);
            this.check_names.Name = "check_names";
            this.check_names.Size = new System.Drawing.Size(226, 35);
            // 
            // check_article
            // 
            this.check_article.BackColor = System.Drawing.Color.Bisque;
            this.check_article.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.check_article.ForeColor = System.Drawing.SystemColors.Highlight;
            this.check_article.Location = new System.Drawing.Point(127, 3);
            this.check_article.Name = "check_article";
            this.check_article.ReadOnly = true;
            this.check_article.Size = new System.Drawing.Size(96, 23);
            this.check_article.TabIndex = 8;
            // 
            // lbsummer
            // 
            this.lbsummer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbsummer.Location = new System.Drawing.Point(3, 223);
            this.lbsummer.Name = "lbsummer";
            this.lbsummer.Size = new System.Drawing.Size(143, 24);
            this.lbsummer.Text = "сумма за период:";
            // 
            // lbprod
            // 
            this.lbprod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbprod.Location = new System.Drawing.Point(7, 196);
            this.lbprod.Name = "lbprod";
            this.lbprod.Size = new System.Drawing.Size(125, 24);
            this.lbprod.Text = "прод. за период:";
            // 
            // lbsut
            // 
            this.lbsut.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbsut.Location = new System.Drawing.Point(7, 170);
            this.lbsut.Name = "lbsut";
            this.lbsut.Size = new System.Drawing.Size(114, 23);
            this.lbsut.Text = "ср. сут.:";
            // 
            // lbedism
            // 
            this.lbedism.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbedism.Location = new System.Drawing.Point(7, 144);
            this.lbedism.Name = "lbedism";
            this.lbedism.Size = new System.Drawing.Size(114, 23);
            this.lbedism.Text = "ед. изм.:";
            // 
            // lbprice
            // 
            this.lbprice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbprice.Location = new System.Drawing.Point(7, 118);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(114, 23);
            this.lbprice.Text = "цена:";
            // 
            // lbgoods
            // 
            this.lbgoods.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbgoods.Location = new System.Drawing.Point(7, 91);
            this.lbgoods.Name = "lbgoods";
            this.lbgoods.Size = new System.Drawing.Size(114, 23);
            this.lbgoods.Text = "остаток:";
            // 
            // lbnames
            // 
            this.lbnames.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbnames.Location = new System.Drawing.Point(7, 33);
            this.lbnames.Name = "lbnames";
            this.lbnames.Size = new System.Drawing.Size(114, 20);
            this.lbnames.Text = "наименование:";
            // 
            // lbarticle
            // 
            this.lbarticle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbarticle.Location = new System.Drawing.Point(7, 4);
            this.lbarticle.Name = "lbarticle";
            this.lbarticle.Size = new System.Drawing.Size(114, 20);
            this.lbarticle.Text = "артикул:";
            // 
            // pDoc
            // 
            this.pDoc.BackColor = System.Drawing.Color.Bisque;
            this.pDoc.Controls.Add(this.who_set);
            this.pDoc.Controls.Add(this.send_btn);
            this.pDoc.Controls.Add(this.who_get);
            this.pDoc.Controls.Add(this.lbprinal);
            this.pDoc.Controls.Add(this.lbsdal);
            this.pDoc.Controls.Add(this.version);
            this.pDoc.Controls.Add(this.exit_btn);
            this.pDoc.Location = new System.Drawing.Point(0, 0);
            this.pDoc.Name = "pDoc";
            this.pDoc.Size = new System.Drawing.Size(232, 264);
            this.pDoc.Text = "Документ";
            this.pDoc.DoubleClick += new System.EventHandler(this.pDoc_DoubleClick);
            this.pDoc.GotFocus += new System.EventHandler(this.pDoc_GotFocus);
            // 
            // who_set
            // 
            this.who_set.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.who_set.ForeColor = System.Drawing.SystemColors.Highlight;
            this.who_set.Location = new System.Drawing.Point(7, 61);
            this.who_set.Name = "who_set";
            this.who_set.Size = new System.Drawing.Size(215, 24);
            this.who_set.TabIndex = 10;
            this.who_set.TextChanged += new System.EventHandler(this.who_set_TextChanged);
            this.who_set.GotFocus += new System.EventHandler(this.who_set_GotFocus);
            this.who_set.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.who_set_KeyPress);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(7, 150);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(215, 39);
            this.send_btn.TabIndex = 6;
            this.send_btn.Text = "передать на сервер";
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            this.send_btn.GotFocus += new System.EventHandler(this.send_btn_GotFocus);
            // 
            // who_get
            // 
            this.who_get.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.who_get.ForeColor = System.Drawing.SystemColors.Highlight;
            this.who_get.Location = new System.Drawing.Point(7, 111);
            this.who_get.Name = "who_get";
            this.who_get.Size = new System.Drawing.Size(215, 24);
            this.who_get.TabIndex = 5;
            this.who_get.TextChanged += new System.EventHandler(this.who_get_TextChanged);
            this.who_get.GotFocus += new System.EventHandler(this.who_get_GotFocus);
            this.who_get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.who_get_KeyPress);
            // 
            // lbprinal
            // 
            this.lbprinal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbprinal.Location = new System.Drawing.Point(7, 88);
            this.lbprinal.Name = "lbprinal";
            this.lbprinal.Size = new System.Drawing.Size(100, 20);
            this.lbprinal.Text = "принял:";
            // 
            // lbsdal
            // 
            this.lbsdal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbsdal.Location = new System.Drawing.Point(7, 38);
            this.lbsdal.Name = "lbsdal";
            this.lbsdal.Size = new System.Drawing.Size(100, 20);
            this.lbsdal.Text = "сдал:";
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(7, 4);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(215, 20);
            this.version.Text = "Версия программы: v0.9";
            this.version.Visible = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(7, 226);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(215, 28);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "главное меню";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.GotFocus += new System.EventHandler(this.exit_btn_GotFocus);
            // 
            // MenuCont
            // 
            this.MenuCont.MenuItems.Add(this.menuItem1);
            this.MenuCont.MenuItems.Add(this.menuItem2);
            this.MenuCont.Popup += new System.EventHandler(this.MenuCont_Popup);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "редактировать";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "удалить";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(240, 290);
            this.Controls.Add(this.Page);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DataForm";
            this.Text = "Mile | терминал сбора данных";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.Closed += new System.EventHandler(this.DataForm_Closed);
            this.Page.ResumeLayout(false);
            this.pBarcode.ResumeLayout(false);
            this.pGetting.ResumeLayout(false);
            this.pSpec.ResumeLayout(false);
            this.pProof.ResumeLayout(false);
            this.pDoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl Page;
        public System.Windows.Forms.TabPage pBarcode;
        public System.Windows.Forms.TabPage pGetting;
        public System.Windows.Forms.TabPage pSpec;
        public System.Windows.Forms.TabPage pDoc;
        public System.Windows.Forms.TabPage pProof;
        public System.Windows.Forms.TextBox tBarcode;
        public System.Windows.Forms.PictureBox Img_Src;
        public System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.TextBox txArticle;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txName;
        public System.Windows.Forms.TextBox txPlace;
        public System.Windows.Forms.TextBox txCount;
        public System.Windows.Forms.TextBox txNumb;
        public System.Windows.Forms.TextBox txMesname;
        public System.Windows.Forms.TextBox txPrice;
        public Microsoft.WindowsCE.Forms.InputPanel input_go;
        public System.Windows.Forms.PictureBox pbPlace;
        public System.Windows.Forms.DataGrid dgSpec;
        private System.Windows.Forms.ContextMenu MenuCont;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label lbsut;
        private System.Windows.Forms.Label lbedism;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbgoods;
        private System.Windows.Forms.Label lbnames;
        private System.Windows.Forms.Label lbarticle;
        private System.Windows.Forms.Label lbsummer;
        private System.Windows.Forms.Label lbprod;
        public System.Windows.Forms.Label check_names;
        public System.Windows.Forms.TextBox check_article;
        public System.Windows.Forms.TextBox check_summ;
        public System.Windows.Forms.TextBox check_prod;
        public System.Windows.Forms.TextBox check_sut;
        public System.Windows.Forms.TextBox check_edism;
        public System.Windows.Forms.TextBox check_price;
        public System.Windows.Forms.TextBox check_goods;
        private System.Windows.Forms.Label lbsdal;
        private System.Windows.Forms.TextBox who_get;
        private System.Windows.Forms.Label lbprinal;
        private System.Windows.Forms.Button send_btn;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox numb;
        public System.Windows.Forms.ListBox lbPlace;
        public System.Windows.Forms.TextBox who_set;
    }
}