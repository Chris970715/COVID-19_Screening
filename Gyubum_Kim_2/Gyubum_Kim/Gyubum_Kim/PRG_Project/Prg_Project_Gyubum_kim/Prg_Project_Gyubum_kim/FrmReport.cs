using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace Prg_Project_Gyubum_kim
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.database1DataSet.DataTable1);
            // TODO: This line of code loads data into the 'database1DataSet.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);

        }

        private void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillBySearch(this.database1DataSet.DataTable1,Convert.ToString(textBox1.Text));
            }
            catch
            {

            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.database1DataSet.DataTable1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            
            string path = @"file.txt";
            
            this.database1DataSet.WriteXml(path);

            
        }
    }
}
