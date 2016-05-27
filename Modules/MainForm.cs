using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunningTracker {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
        }
        void baseMapBtn_Click(object sender, EventArgs e) {
            BaseMapEditForm form = new BaseMapEditForm();
            form.ShowDialog();
        }
    }
}
