namespace DCT
{
    partial class docSpecSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static docSpecSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new DCT.docSpecSummaryViewDialog();
                defaultInstance.docSpecBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.docSpecBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static docSpecSummaryViewDialog defaultInstance;
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_docLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label count_eLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label placeLabel;
            System.Windows.Forms.Label priceLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.docSpecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabel1 = new System.Windows.Forms.Label();
            this.id_docLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.count_eLabel1 = new System.Windows.Forms.Label();
            this.barcodeLabel1 = new System.Windows.Forms.Label();
            this.articleLabel1 = new System.Windows.Forms.Label();
            this.placeLabel1 = new System.Windows.Forms.Label();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            id_docLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            count_eLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            articleLabel = new System.Windows.Forms.Label();
            placeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.docSpecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // idLabel
            // 
            idLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "id", true));
            idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            idLabel.Location = new System.Drawing.Point(4, 4);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 21);
            idLabel.Text = "id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "id", true));
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "id", true));
            this.idLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel1.Location = new System.Drawing.Point(4, 18);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // id_docLabel
            // 
            id_docLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "id_doc", true));
            id_docLabel.Dock = System.Windows.Forms.DockStyle.Top;
            id_docLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            id_docLabel.Location = new System.Drawing.Point(4, 49);
            id_docLabel.Name = "id_docLabel";
            id_docLabel.Size = new System.Drawing.Size(48, 21);
            id_docLabel.Text = "id doc:";
            // 
            // id_docLabel1
            // 
            this.id_docLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "id_doc", true));
            this.id_docLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "id_doc", true));
            this.id_docLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.id_docLabel1.Location = new System.Drawing.Point(4, 63);
            this.id_docLabel1.Name = "id_docLabel1";
            this.id_docLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // nameLabel
            // 
            nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "name", true));
            nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(4, 94);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 21);
            nameLabel.Text = "name:";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "name", true));
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "name", true));
            this.nameLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel1.Location = new System.Drawing.Point(4, 108);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // count_eLabel
            // 
            count_eLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "count_e", true));
            count_eLabel.Dock = System.Windows.Forms.DockStyle.Top;
            count_eLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            count_eLabel.Location = new System.Drawing.Point(4, 139);
            count_eLabel.Name = "count_eLabel";
            count_eLabel.Size = new System.Drawing.Size(58, 21);
            count_eLabel.Text = "count e:";
            // 
            // count_eLabel1
            // 
            this.count_eLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "count_e", true));
            this.count_eLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "count_e", true));
            this.count_eLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.count_eLabel1.Location = new System.Drawing.Point(4, 153);
            this.count_eLabel1.Name = "count_eLabel1";
            this.count_eLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // barcodeLabel
            // 
            barcodeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "barcode", true));
            barcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            barcodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            barcodeLabel.Location = new System.Drawing.Point(4, 184);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(60, 21);
            barcodeLabel.Text = "barcode:";
            // 
            // barcodeLabel1
            // 
            this.barcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "barcode", true));
            this.barcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "barcode", true));
            this.barcodeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeLabel1.Location = new System.Drawing.Point(4, 198);
            this.barcodeLabel1.Name = "barcodeLabel1";
            this.barcodeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // articleLabel
            // 
            articleLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "article", true));
            articleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            articleLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            articleLabel.Location = new System.Drawing.Point(4, 229);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(48, 21);
            articleLabel.Text = "article:";
            // 
            // articleLabel1
            // 
            this.articleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "article", true));
            this.articleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "article", true));
            this.articleLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleLabel1.Location = new System.Drawing.Point(4, 243);
            this.articleLabel1.Name = "articleLabel1";
            this.articleLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // placeLabel
            // 
            placeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "place", true));
            placeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            placeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            placeLabel.Location = new System.Drawing.Point(4, 274);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(42, 21);
            placeLabel.Text = "place:";
            // 
            // placeLabel1
            // 
            this.placeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "place", true));
            this.placeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "place", true));
            this.placeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeLabel1.Location = new System.Drawing.Point(4, 288);
            this.placeLabel1.Name = "placeLabel1";
            this.placeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // priceLabel
            // 
            priceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "price", true));
            priceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            priceLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            priceLabel.Location = new System.Drawing.Point(4, 319);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(40, 21);
            priceLabel.Text = "price:";
            // 
            // priceLabel1
            // 
            this.priceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "price", true));
            this.priceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.docSpecBindingSource, "price", true));
            this.priceLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceLabel1.Location = new System.Drawing.Point(4, 333);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(100, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // docSpecSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.priceLabel1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.placeLabel1);
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.articleLabel1);
            this.Controls.Add(articleLabel);
            this.Controls.Add(this.barcodeLabel1);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.count_eLabel1);
            this.Controls.Add(count_eLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.id_docLabel1);
            this.Controls.Add(id_docLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "docSpecSummaryViewDialog";
            this.Text = "docSpecSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.docSpecSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.docSpecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource docSpecBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label id_docLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label count_eLabel1;
        private System.Windows.Forms.Label barcodeLabel1;
        private System.Windows.Forms.Label articleLabel1;
        private System.Windows.Forms.Label placeLabel1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}