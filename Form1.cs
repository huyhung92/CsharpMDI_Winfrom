using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpMDI_Winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clildFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clild Form Object 
            ChildFrom1 cf1 = new ChildFrom1();
            //Define MDI parent form
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
