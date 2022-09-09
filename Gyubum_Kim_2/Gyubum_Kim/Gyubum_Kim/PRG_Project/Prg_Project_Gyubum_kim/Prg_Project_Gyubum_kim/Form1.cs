using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_Project_Gyubum_kim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUserEdit frmUserEdit = new FrmUserEdit();
            frmUserEdit.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
        }
    }
}
