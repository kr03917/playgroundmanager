namespace playgroundManager
{
    partial class Workshops
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
            this.label1 = new System.Windows.Forms.Label();
            this.workshop = new System.Windows.Forms.TabControl();
            this.addworkshop_tab = new System.Windows.Forms.TabPage();
            this.updateworkshop_tab = new System.Windows.Forms.TabPage();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.workshopname_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addinstructor_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.capacity_txt = new System.Windows.Forms.TextBox();
            this.workshop.SuspendLayout();
            this.addworkshop_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica-Normal", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "workshop manager";
            // 
            // workshop
            // 
            this.workshop.Controls.Add(this.addworkshop_tab);
            this.workshop.Controls.Add(this.updateworkshop_tab);
            this.workshop.Location = new System.Drawing.Point(4, 48);
            this.workshop.Name = "workshop";
            this.workshop.SelectedIndex = 0;
            this.workshop.Size = new System.Drawing.Size(659, 555);
            this.workshop.TabIndex = 1;
            // 
            // addworkshop_tab
            // 
            this.addworkshop_tab.Controls.Add(this.capacity_txt);
            this.addworkshop_tab.Controls.Add(this.label4);
            this.addworkshop_tab.Controls.Add(this.addinstructor_btn);
            this.addworkshop_tab.Controls.Add(this.comboBox1);
            this.addworkshop_tab.Controls.Add(this.label3);
            this.addworkshop_tab.Controls.Add(this.workshopname_txt);
            this.addworkshop_tab.Controls.Add(this.label2);
            this.addworkshop_tab.Location = new System.Drawing.Point(4, 26);
            this.addworkshop_tab.Name = "addworkshop_tab";
            this.addworkshop_tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addworkshop_tab.Size = new System.Drawing.Size(651, 525);
            this.addworkshop_tab.TabIndex = 0;
            this.addworkshop_tab.Text = "add workshop";
            this.addworkshop_tab.UseVisualStyleBackColor = true;
            // 
            // updateworkshop_tab
            // 
            this.updateworkshop_tab.Location = new System.Drawing.Point(4, 29);
            this.updateworkshop_tab.Name = "updateworkshop_tab";
            this.updateworkshop_tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.updateworkshop_tab.Size = new System.Drawing.Size(651, 522);
            this.updateworkshop_tab.TabIndex = 1;
            this.updateworkshop_tab.Text = "update workshop";
            this.updateworkshop_tab.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(46, 617);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(173, 35);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "workshop name:";
            // 
            // workshopname_txt
            // 
            this.workshopname_txt.Location = new System.Drawing.Point(180, 36);
            this.workshopname_txt.Name = "workshopname_txt";
            this.workshopname_txt.Size = new System.Drawing.Size(405, 25);
            this.workshopname_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "instructor name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // addinstructor_btn
            // 
            this.addinstructor_btn.Location = new System.Drawing.Point(474, 70);
            this.addinstructor_btn.Name = "addinstructor_btn";
            this.addinstructor_btn.Size = new System.Drawing.Size(111, 37);
            this.addinstructor_btn.TabIndex = 4;
            this.addinstructor_btn.Text = "add instructor";
            this.addinstructor_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "capacity:";
            // 
            // capacity_txt
            // 
            this.capacity_txt.Location = new System.Drawing.Point(179, 114);
            this.capacity_txt.Name = "capacity_txt";
            this.capacity_txt.Size = new System.Drawing.Size(142, 25);
            this.capacity_txt.TabIndex = 6;
            // 
            // Workshops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(663, 665);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.workshop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica-Normal", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Workshops";
            this.Text = "Workshops";
            this.workshop.ResumeLayout(false);
            this.addworkshop_tab.ResumeLayout(false);
            this.addworkshop_tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl workshop;
        private System.Windows.Forms.TabPage addworkshop_tab;
        private System.Windows.Forms.TabPage updateworkshop_tab;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox capacity_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addinstructor_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workshopname_txt;
        private System.Windows.Forms.Label label2;
    }
}