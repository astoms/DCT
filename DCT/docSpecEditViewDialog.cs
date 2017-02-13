using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCT
{
    public partial class docSpecEditViewDialog : Form
    {
        public docSpecEditViewDialog()
        {
            InitializeComponent();
        }

        private void docSpecEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.docSpecBindingSource.EndEdit();

        }
    }
}