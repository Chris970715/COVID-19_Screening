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
    public partial class FrmUserEdit : Form
    {
        Boolean t = true;
        Boolean f = false;


        public FrmUserEdit()
        {
            InitializeComponent();
        }

        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ScreeningTable' table. You can move, or remove it, as needed.
            this.screeningTableTableAdapter.Fill(this.database1DataSet.ScreeningTable);

        }

        private void screeningTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.screeningTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.screeningTableTableAdapter.InsertQueryScreening(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToBoolean(closeContactComboBox.SelectedItem), Convert.ToBoolean(travelledComboBox.SelectedItem), Convert.ToBoolean(symptomsComboBox.SelectedItem), textBox6.Text);

                if (Convert.ToBoolean(travelledComboBox.SelectedItem) == t && Convert.ToBoolean(travelledComboBox.SelectedItem) == t && Convert.ToBoolean(symptomsComboBox.SelectedItem) == t)
                {
                    this.screeningTableTableAdapter.InsertQueryUserFlagged(Convert.ToInt32(textBox2.Text));
                }

            }
            catch 
            {

            }

            this.screeningTableTableAdapter.Fill(this.database1DataSet.ScreeningTable);

            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeContactComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void travelledComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void symptomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (Convert.ToInt32(this.screeningTableTableAdapter.ScalarQueryUserFlaggedValue(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text))) == 1)
                {
                    MessageBox.Show("WARNING!!!! YOU HAVE JUST TRIED TO EDIT A FLAGGED DATA !!!!!");
                }
                else 
                {
                    this.screeningTableTableAdapter.UpdateQueryScreening(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToBoolean(closeContactComboBox.SelectedItem), Convert.ToBoolean(travelledComboBox.SelectedItem), Convert.ToBoolean(symptomsComboBox.SelectedItem), textBox6.Text, Convert.ToInt32(textBox3.Text));

                    if (Convert.ToBoolean(travelledComboBox.SelectedItem) == t && Convert.ToBoolean(travelledComboBox.SelectedItem) == t && Convert.ToBoolean(symptomsComboBox.SelectedItem) == t)
                    {
                        this.screeningTableTableAdapter.InsertQueryUserFlagged(Convert.ToInt32(textBox3.Text));
                    }
                }
                
                

                
            }
            catch
            {

            }


            
            this.screeningTableTableAdapter.Fill(this.database1DataSet.ScreeningTable);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.screeningTableTableAdapter.ScalarQueryUserFlaggedValue(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text))) == 1)
                {
                    MessageBox.Show("WARNING!!!! YOU HAVE JUST TRIED TO delete A FLAGGED DATA !!!!!");
                }
                else
                {
                    this.screeningTableTableAdapter.DeleteQueryScreening(Convert.ToInt32(textBox3.Text));
                }
                    
            }
            catch
            {

            }

            this.screeningTableTableAdapter.Fill(this.database1DataSet.ScreeningTable);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.screeningTableTableAdapter.Fill(this.database1DataSet.ScreeningTable);
        }
    }
}
