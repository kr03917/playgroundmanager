namespace playgroundManager
{
    partial class inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_btn = new System.Windows.Forms.Button();
            this.inventorymanager = new System.Windows.Forms.TabControl();
            this.add_inventory = new System.Windows.Forms.TabPage();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.inventory_save_btn = new System.Windows.Forms.Button();
            this.desc_list = new System.Windows.Forms.ListBox();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.reorder_txt = new System.Windows.Forms.TextBox();
            this.current_txt = new System.Windows.Forms.TextBox();
            this.inventory_name_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_inventory = new System.Windows.Forms.TabPage();
            this.remove_btn = new System.Windows.Forms.Button();
            this.item_name_combo = new System.Windows.Forms.ComboBox();
            this.delete_btn2 = new System.Windows.Forms.Button();
            this.add_btn2 = new System.Windows.Forms.Button();
            this.inventory_update_btn = new System.Windows.Forms.Button();
            this.desc_list2 = new System.Windows.Forms.ListBox();
            this.desc_txt2 = new System.Windows.Forms.TextBox();
            this.reorder_txt2 = new System.Windows.Forms.TextBox();
            this.current_txt2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inventorymanager.SuspendLayout();
            this.add_inventory.SuspendLayout();
            this.update_inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(24, 585);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(196, 39);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // inventorymanager
            // 
            this.inventorymanager.Controls.Add(this.add_inventory);
            this.inventorymanager.Controls.Add(this.update_inventory);
            this.inventorymanager.Location = new System.Drawing.Point(2, 39);
            this.inventorymanager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inventorymanager.Name = "inventorymanager";
            this.inventorymanager.SelectedIndex = 0;
            this.inventorymanager.Size = new System.Drawing.Size(688, 540);
            this.inventorymanager.TabIndex = 1;
            // 
            // add_inventory
            // 
            this.add_inventory.Controls.Add(this.delete_btn);
            this.add_inventory.Controls.Add(this.add_btn);
            this.add_inventory.Controls.Add(this.inventory_save_btn);
            this.add_inventory.Controls.Add(this.desc_list);
            this.add_inventory.Controls.Add(this.desc_txt);
            this.add_inventory.Controls.Add(this.reorder_txt);
            this.add_inventory.Controls.Add(this.current_txt);
            this.add_inventory.Controls.Add(this.inventory_name_txt);
            this.add_inventory.Controls.Add(this.label5);
            this.add_inventory.Controls.Add(this.label4);
            this.add_inventory.Controls.Add(this.label3);
            this.add_inventory.Controls.Add(this.label2);
            this.add_inventory.Location = new System.Drawing.Point(4, 26);
            this.add_inventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_inventory.Name = "add_inventory";
            this.add_inventory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_inventory.Size = new System.Drawing.Size(680, 510);
            this.add_inventory.TabIndex = 0;
            this.add_inventory.Text = "add inventory";
            this.add_inventory.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(548, 213);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(108, 36);
            this.delete_btn.TabIndex = 11;
            this.delete_btn.Text = "remove";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(548, 163);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 29);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // inventory_save_btn
            // 
            this.inventory_save_btn.Location = new System.Drawing.Point(422, 453);
            this.inventory_save_btn.Name = "inventory_save_btn";
            this.inventory_save_btn.Size = new System.Drawing.Size(108, 36);
            this.inventory_save_btn.TabIndex = 9;
            this.inventory_save_btn.Text = "save";
            this.inventory_save_btn.UseVisualStyleBackColor = true;
            this.inventory_save_btn.Click += new System.EventHandler(this.inventory_save_btn_Click);
            // 
            // desc_list
            // 
            this.desc_list.FormattingEnabled = true;
            this.desc_list.ItemHeight = 17;
            this.desc_list.Location = new System.Drawing.Point(207, 213);
            this.desc_list.Name = "desc_list";
            this.desc_list.Size = new System.Drawing.Size(323, 225);
            this.desc_list.TabIndex = 8;
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(204, 163);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(326, 25);
            this.desc_txt.TabIndex = 7;
            // 
            // reorder_txt
            // 
            this.reorder_txt.Location = new System.Drawing.Point(204, 118);
            this.reorder_txt.Name = "reorder_txt";
            this.reorder_txt.Size = new System.Drawing.Size(116, 25);
            this.reorder_txt.TabIndex = 6;
            // 
            // current_txt
            // 
            this.current_txt.Location = new System.Drawing.Point(204, 74);
            this.current_txt.Name = "current_txt";
            this.current_txt.Size = new System.Drawing.Size(116, 25);
            this.current_txt.TabIndex = 5;
            // 
            // inventory_name_txt
            // 
            this.inventory_name_txt.Location = new System.Drawing.Point(204, 31);
            this.inventory_name_txt.Name = "inventory_name_txt";
            this.inventory_name_txt.Size = new System.Drawing.Size(452, 25);
            this.inventory_name_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "reorder quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "current quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "name:";
            // 
            // update_inventory
            // 
            this.update_inventory.Controls.Add(this.remove_btn);
            this.update_inventory.Controls.Add(this.item_name_combo);
            this.update_inventory.Controls.Add(this.delete_btn2);
            this.update_inventory.Controls.Add(this.add_btn2);
            this.update_inventory.Controls.Add(this.inventory_update_btn);
            this.update_inventory.Controls.Add(this.desc_list2);
            this.update_inventory.Controls.Add(this.desc_txt2);
            this.update_inventory.Controls.Add(this.reorder_txt2);
            this.update_inventory.Controls.Add(this.current_txt2);
            this.update_inventory.Controls.Add(this.label6);
            this.update_inventory.Controls.Add(this.label7);
            this.update_inventory.Controls.Add(this.label8);
            this.update_inventory.Controls.Add(this.label9);
            this.update_inventory.Location = new System.Drawing.Point(4, 26);
            this.update_inventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_inventory.Name = "update_inventory";
            this.update_inventory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_inventory.Size = new System.Drawing.Size(680, 510);
            this.update_inventory.TabIndex = 1;
            this.update_inventory.Text = "update inventory";
            this.update_inventory.UseVisualStyleBackColor = true;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(296, 448);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(108, 36);
            this.remove_btn.TabIndex = 25;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // item_name_combo
            // 
            this.item_name_combo.FormattingEnabled = true;
            this.item_name_combo.Location = new System.Drawing.Point(204, 27);
            this.item_name_combo.Name = "item_name_combo";
            this.item_name_combo.Size = new System.Drawing.Size(451, 25);
            this.item_name_combo.TabIndex = 24;
            this.item_name_combo.SelectedValueChanged += new System.EventHandler(this.item_name_combo_SelectedValueChanged);
            this.item_name_combo.Click += new System.EventHandler(this.item_name_combo_Click);
            // 
            // delete_btn2
            // 
            this.delete_btn2.Location = new System.Drawing.Point(548, 208);
            this.delete_btn2.Name = "delete_btn2";
            this.delete_btn2.Size = new System.Drawing.Size(108, 36);
            this.delete_btn2.TabIndex = 23;
            this.delete_btn2.Text = "delete";
            this.delete_btn2.UseVisualStyleBackColor = true;
            this.delete_btn2.Click += new System.EventHandler(this.delete_btn2_Click);
            // 
            // add_btn2
            // 
            this.add_btn2.Location = new System.Drawing.Point(548, 158);
            this.add_btn2.Name = "add_btn2";
            this.add_btn2.Size = new System.Drawing.Size(108, 29);
            this.add_btn2.TabIndex = 22;
            this.add_btn2.Text = "add";
            this.add_btn2.UseVisualStyleBackColor = true;
            this.add_btn2.Click += new System.EventHandler(this.add_btn2_Click);
            // 
            // inventory_update_btn
            // 
            this.inventory_update_btn.Location = new System.Drawing.Point(422, 448);
            this.inventory_update_btn.Name = "inventory_update_btn";
            this.inventory_update_btn.Size = new System.Drawing.Size(108, 36);
            this.inventory_update_btn.TabIndex = 21;
            this.inventory_update_btn.Text = "update";
            this.inventory_update_btn.UseVisualStyleBackColor = true;
            this.inventory_update_btn.Click += new System.EventHandler(this.inventory_update_btn_Click);
            // 
            // desc_list2
            // 
            this.desc_list2.FormattingEnabled = true;
            this.desc_list2.ItemHeight = 17;
            this.desc_list2.Location = new System.Drawing.Point(207, 208);
            this.desc_list2.Name = "desc_list2";
            this.desc_list2.Size = new System.Drawing.Size(323, 225);
            this.desc_list2.TabIndex = 20;
            // 
            // desc_txt2
            // 
            this.desc_txt2.Location = new System.Drawing.Point(204, 158);
            this.desc_txt2.Name = "desc_txt2";
            this.desc_txt2.Size = new System.Drawing.Size(326, 25);
            this.desc_txt2.TabIndex = 19;
            // 
            // reorder_txt2
            // 
            this.reorder_txt2.Location = new System.Drawing.Point(204, 113);
            this.reorder_txt2.Name = "reorder_txt2";
            this.reorder_txt2.Size = new System.Drawing.Size(116, 25);
            this.reorder_txt2.TabIndex = 18;
            // 
            // current_txt2
            // 
            this.current_txt2.Location = new System.Drawing.Point(204, 69);
            this.current_txt2.Name = "current_txt2";
            this.current_txt2.Size = new System.Drawing.Size(116, 25);
            this.current_txt2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "reorder quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "current quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica-Normal", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "inventory manager";
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(725, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventorymanager);
            this.Controls.Add(this.cancel_btn);
            this.Font = new System.Drawing.Font("Helvetica-Normal", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "inventory";
            this.Text = "inventory";
            this.inventorymanager.ResumeLayout(false);
            this.add_inventory.ResumeLayout(false);
            this.add_inventory.PerformLayout();
            this.update_inventory.ResumeLayout(false);
            this.update_inventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TabControl inventorymanager;
        private System.Windows.Forms.TabPage add_inventory;
        private System.Windows.Forms.TabPage update_inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button inventory_save_btn;
        private System.Windows.Forms.ListBox desc_list;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.TextBox reorder_txt;
        private System.Windows.Forms.TextBox current_txt;
        private System.Windows.Forms.TextBox inventory_name_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox item_name_combo;
        private System.Windows.Forms.Button delete_btn2;
        private System.Windows.Forms.Button add_btn2;
        private System.Windows.Forms.Button inventory_update_btn;
        private System.Windows.Forms.ListBox desc_list2;
        private System.Windows.Forms.TextBox desc_txt2;
        private System.Windows.Forms.TextBox reorder_txt2;
        private System.Windows.Forms.TextBox current_txt2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button remove_btn;
    }
}