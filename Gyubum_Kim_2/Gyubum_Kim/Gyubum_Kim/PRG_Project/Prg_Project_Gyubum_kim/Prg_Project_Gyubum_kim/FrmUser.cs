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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);

        }

        private void userTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.InsertQueryUser(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToString(userTypeComboBox.SelectedItem), Convert.ToInt32(textBox4.Text));
            }
            catch
            {

            }

            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            try 
            {
                this.userTableTableAdapter.UpdateQueryUser(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToString(userTypeComboBox.SelectedItem), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text));
            }
            catch
            {

            }

            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.DeleteQueryUser(Convert.ToInt32(textBox3.Text));
            }
            catch
            {

            }
            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.UpdateQueryFlagged(Convert.ToInt32(textBox3.Text));
            }
            catch
            {

            }
            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.userTableTableAdapter.Fill(this.database1DataSet.UserTable);
        }
    }
}
