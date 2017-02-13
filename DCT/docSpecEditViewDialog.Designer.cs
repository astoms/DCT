namespace DCT
{
    partial class docSpecEditViewDialog
    {
        public static docSpecEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new DCT.docSpecEditViewDialog();
                defaultInstance.docSpecBindingSource.DataSource = bindingSource;
            }
            defaultInstance.id_docTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.docSpecBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static docSpecEditViewDialog defaultInstance;
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
            System.Windows.Forms.Label id_docLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label count_eLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label placeLabel;
            System.Windows.Forms.Label priceLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.docSpecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_docTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.count_eTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
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
            // id_docLabel
            // 
            id_docLabel.Dock = System.Windows.Forms.DockStyle.Top;
            id_docLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            id_docLabel.Location = new System.Drawing.Point(4, 4);
            id_docLabel.Name = "id_docLabel";
            id_docLabel.Size = new System.Drawing.Size(48, 21);
            id_docLabel.Text = "id doc:";
            // 
            // id_docTextBox
            // 
            this.id_docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "id_doc", true));
            this.id_docTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.id_docTextBox.Location = new System.Drawing.Point(4, 18);
            this.id_docTextBox.Name = "id_docTextBox";
            this.id_docTextBox.Size = new System.Drawing.Size(100, 21);
            this.id_docTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(4, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 21);
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(4, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 3;
            // 
            // count_eLabel
            // 
            count_eLabel.Dock = System.Windows.Forms.DockStyle.Top;
            count_eLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            count_eLabel.Location = new System.Drawing.Point(4, 96);
            count_eLabel.Name = "count_eLabel";
            count_eLabel.Size = new System.Drawing.Size(58, 21);
            count_eLabel.Text = "count e:";
            // 
            // count_eTextBox
            // 
            this.count_eTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "count_e", true));
            this.count_eTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.count_eTextBox.Location = new System.Drawing.Point(4, 110);
            this.count_eTextBox.Name = "count_eTextBox";
            this.count_eTextBox.Size = new System.Drawing.Size(100, 21);
            this.count_eTextBox.TabIndex = 5;
            // 
            // barcodeLabel
            // 
            barcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            barcodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            barcodeLabel.Location = new System.Drawing.Point(4, 142);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(60, 21);
            barcodeLabel.Text = "barcode:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "barcode", true));
            this.barcodeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeTextBox.Location = new System.Drawing.Point(4, 156);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.barcodeTextBox.TabIndex = 7;
            // 
            // articleLabel
            // 
            articleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            articleLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            articleLabel.Location = new System.Drawing.Point(4, 188);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(48, 21);
            articleLabel.Text = "article:";
            // 
            // articleTextBox
            // 
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "article", true));
            this.articleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleTextBox.Location = new System.Drawing.Point(4, 202);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(100, 21);
            this.articleTextBox.TabIndex = 9;
            // 
            // placeLabel
            // 
            placeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            placeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            placeLabel.Location = new System.Drawing.Point(4, 234);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(42, 21);
            placeLabel.Text = "place:";
            // 
            // placeTextBox
            // 
            this.placeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "place", true));
            this.placeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeTextBox.Location = new System.Drawing.Point(4, 248);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(100, 21);
            this.placeTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            priceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            priceLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            priceLabel.Location = new System.Drawing.Point(4, 280);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(40, 21);
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docSpecBindingSource, "price", true));
            this.priceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceTextBox.Location = new System.Drawing.Point(4, 294);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 21);
            this.priceTextBox.TabIndex = 13;
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
            // docSpecEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.articleTextBox);
            this.Controls.Add(articleLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.count_eTextBox);
            this.Controls.Add(count_eLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.id_docTextBox);
            this.Controls.Add(id_docLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "docSpecEditViewDialog";
            this.Text = "docSpecEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.docSpecEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.docSpecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource docSpecBindingSource;
        private System.Windows.Forms.TextBox id_docTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox count_eTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}