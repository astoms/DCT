namespace DCT
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.Label();
            this.doc_num = new System.Windows.Forms.Label();
            this.num_doc = new System.Windows.Forms.TextBox();
            this.fio_doc = new System.Windows.Forms.TextBox();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.doc_list = new System.Windows.Forms.ListBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.input_go = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.uploader = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(122, 256);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(115, 20);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "выход";
            this.exit_btn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(3, 10);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(96, 20);
            this.fio.Text = "ФИО:";
            this.fio.ParentChanged += new System.EventHandler(this.fio_ParentChanged);
            // 
            // doc_num
            // 
            this.doc_num.Location = new System.Drawing.Point(122, 10);
            this.doc_num.Name = "doc_num";
            this.doc_num.Size = new System.Drawing.Size(96, 20);
            this.doc_num.Text = "№ документа:";
            this.doc_num.ParentChanged += new System.EventHandler(this.doc_num_ParentChanged);
            // 
            // num_doc
            // 
            this.num_doc.BackColor = System.Drawing.Color.Bisque;
            this.num_doc.Location = new System.Drawing.Point(122, 33);
            this.num_doc.MaxLength = 12;
            this.num_doc.Name = "num_doc";
            this.num_doc.Size = new System.Drawing.Size(115, 21);
            this.num_doc.TabIndex = 3;
            this.num_doc.TextChanged += new System.EventHandler(this.num_doc_TextChanged);
            this.num_doc.GotFocus += new System.EventHandler(this.num_doc_GotFocus);
            this.num_doc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_doc_KeyUp);
            this.num_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_doc_KeyPress);
            // 
            // fio_doc
            // 
            this.fio_doc.BackColor = System.Drawing.Color.Bisque;
            this.fio_doc.Location = new System.Drawing.Point(3, 33);
            this.fio_doc.MaxLength = 25;
            this.fio_doc.Name = "fio_doc";
            this.fio_doc.Size = new System.Drawing.Size(115, 21);
            this.fio_doc.TabIndex = 4;
            this.fio_doc.TextChanged += new System.EventHandler(this.fio_doc_TextChanged);
            this.fio_doc.GotFocus += new System.EventHandler(this.fio_doc_GotFocus);
            this.fio_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fio_doc_KeyPress);
            // 
            // combobox
            // 
            this.combobox.BackColor = System.Drawing.Color.Bisque;
            this.combobox.Items.Add("Перемещение в зал");
            this.combobox.Items.Add("Перемещение на склад");
            this.combobox.Items.Add("Приемка зал");
            this.combobox.Items.Add("Приемка склад");
            this.combobox.Items.Add("Инвентаризация");
            this.combobox.Items.Add("Проверка цен");
            this.combobox.Location = new System.Drawing.Point(3, 60);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(156, 22);
            this.combobox.TabIndex = 5;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            this.combobox.GotFocus += new System.EventHandler(this.combobox_GotFocus);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(165, 60);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(72, 22);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "добавить";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.GotFocus += new System.EventHandler(this.add_btn_GotFocus);
            // 
            // doc_list
            // 
            this.doc_list.BackColor = System.Drawing.Color.Bisque;
            this.doc_list.Location = new System.Drawing.Point(3, 88);
            this.doc_list.Name = "doc_list";
            this.doc_list.Size = new System.Drawing.Size(234, 128);
            this.doc_list.TabIndex = 7;
            this.doc_list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.doc_list.GotFocus += new System.EventHandler(this.doc_list_GotFocus);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(3, 225);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(234, 20);
            this.next_btn.TabIndex = 8;
            this.next_btn.Text = "начать/продолжить";
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            this.next_btn.GotFocus += new System.EventHandler(this.next_btn_GotFocus);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(3, 256);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(115, 20);
            this.refresh_btn.TabIndex = 9;
            this.refresh_btn.Text = "обновить";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // uploader
            // 
            this.uploader.Location = new System.Drawing.Point(3, 225);
            this.uploader.Name = "uploader";
            this.uploader.Size = new System.Drawing.Size(234, 20);
            this.uploader.Visible = false;
            this.uploader.ParentChanged += new System.EventHandler(this.uploader_ParentChanged);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(240, 290);
            this.ControlBox = false;
            this.Controls.Add(this.uploader);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.doc_list);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.fio_doc);
            this.Controls.Add(this.num_doc);
            this.Controls.Add(this.doc_num);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "Mile | терминал сбора данных";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.Activated += new System.EventHandler(this.StartForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Label doc_num;
        private System.Windows.Forms.TextBox num_doc;
        private System.Windows.Forms.TextBox fio_doc;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListBox doc_list;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button refresh_btn;
        private Microsoft.WindowsCE.Forms.InputPanel input_go;
        private System.Windows.Forms.ProgressBar uploader;
    }
}