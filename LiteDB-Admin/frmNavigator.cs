using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiteDB_Admin {
    public partial class frmNavigator : WeifenLuo.WinFormsUI.Docking.DockContent {

        public frmNavigator() {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            treeView1.Nodes.Add(new TreeNode("sadf"));
        }
    }
}
