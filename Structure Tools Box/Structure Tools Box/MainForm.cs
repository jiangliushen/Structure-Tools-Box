using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structure_Tools_Box
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsbMergeExcel_Click(object sender, EventArgs e)
        {
            MergeForm mergeForm = new MergeForm();
            mergeForm.ShowDialog();
        }

        private void tsbParentCount_Click(object sender, EventArgs e)
        {
            ParentCountForm parentCountForm = new ParentCountForm();
            parentCountForm.ShowDialog();
        }
    }
}
