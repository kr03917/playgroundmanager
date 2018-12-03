using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace playgroundManager
{
    public partial class inventory : Form
    {
        Thread th;
        public inventory()
        {
            InitializeComponent();
        }

        void fillCombo()
        {
            DbConnection db = new DbConnection();
            DataTable dataT = db.Select("SELECT itemName FROM InventoryItems;");
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                item_name_combo.Items.Add(dataT.Rows[i][0].ToString());
            }
        }

        //Add inventory item
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new welcome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (desc_txt.Text != "")
            {
                desc_list.Items.Add(desc_txt.Text);
                desc_txt.Clear();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desc_list.Items.Remove(desc_list.SelectedItem);
        }

        private void inventory_save_btn_Click(object sender, EventArgs e)
        {
            DbConnection dbc = new DbConnection();
            string desc = "";
            for (int index = 0; index < desc_list.Items.Count; index++)
            {
                if ((desc_list.Items.Count - 1) > index)
                {
                    desc = desc + desc_list.Items[index] + "/";
                }
                else
                {
                    desc = desc + desc_list.Items[index];
                }
            }
            DataTable dataT = dbc.Select("SELECT itemName FROM InventoryItems;");
            bool itemExists = false;
            foreach (DataRow row in dataT.Rows)
            {
                if (inventory_name_txt.Text == row[0].ToString())
                {
                    itemExists = true;
                }
            }
            if (itemExists == false)
            {
                dbc.Inserts("insert into InventoryItems values('" + inventory_name_txt.Text + "','" + current_txt.Text + "','" + reorder_txt.Text + "','" + desc + "')");
                MessageBox.Show("inventory successfully added!");
                inventory_name_txt.Text = String.Empty;
                current_txt.Text = String.Empty;
                reorder_txt.Text = String.Empty;
                desc_list.Items.Clear();
            }
            else
            {
                MessageBox.Show("item already exists!");
            }
            
        }
        //Update inventory
        private void add_btn2_Click(object sender, EventArgs e)
        {
            if (desc_txt2.Text != "")
            {
                desc_list2.Items.Add(desc_txt2.Text);
                desc_txt2.Clear();
            }
        }

        private void delete_btn2_Click(object sender, EventArgs e)
        {
            desc_list2.Items.Remove(desc_list2.SelectedItem);
        }

        private void item_name_combo_Click(object sender, EventArgs e)
        {
            item_name_combo.Items.Clear();
            fillCombo();
        }

        private void item_name_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            desc_list2.Items.Clear();
            DbConnection db = new DbConnection();
            DataTable dataT = db.Select("SELECT * FROM InventoryItems WHERE itemName = '"+ item_name_combo.SelectedItem.ToString() + "';");
            current_txt2.Text = dataT.Rows[0][2].ToString();
            reorder_txt2.Text = dataT.Rows[0][3].ToString();
            string[] lst = dataT.Rows[0][4].ToString().Split('/');
            foreach (string desc in lst)
            {
                desc_list2.Items.Add(desc);
            }
        }

        private void inventory_update_btn_Click(object sender, EventArgs e)
        {
            DbConnection dbc = new DbConnection();
            string desc = "";
            for (int index = 0; index < desc_list2.Items.Count; index++)
            {
                if ((desc_list2.Items.Count - 1) > index)
                {
                    desc = desc + desc_list2.Items[index] + "/";
                }
                else
                {
                    desc = desc + desc_list2.Items[index];
                }
            }
            dbc.Updates("UPDATE InventoryItems SET currentQuantity = "+ current_txt2.Text+ ", reorderLevel = " + reorder_txt2.Text +", [Description] = '"+desc+ "' WHERE itemName = '" + item_name_combo.SelectedItem.ToString() + "'");
            MessageBox.Show("inventory successfully updated!");
        }

        

        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you permanently want to remove this item?",
            "Remove",
            MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                DbConnection dbc = new DbConnection();
                dbc.Deletes("DELETE FROM InventoryItems WHERE itemName = '" + item_name_combo.SelectedItem.ToString() + "'");
                item_name_combo.SelectedItem = "";
                current_txt2.Text = String.Empty;
                reorder_txt2.Text = String.Empty;
                desc_list2.Items.Clear();
            }
        }
    }
}
