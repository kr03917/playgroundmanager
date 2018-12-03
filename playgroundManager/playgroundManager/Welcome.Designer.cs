namespace playgroundManager
{
    partial class welcome
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
            this.inventory_btn = new System.Windows.Forms.Button();
            this.workshop_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica-Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "playground management system";
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inventory_btn.Location = new System.Drawing.Point(66, 103);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(457, 47);
            this.inventory_btn.TabIndex = 1;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // workshop_btn
            // 
            this.workshop_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.workshop_btn.Location = new System.Drawing.Point(66, 175);
            this.workshop_btn.Name = "workshop_btn";
            this.workshop_btn.Size = new System.Drawing.Size(457, 47);
            this.workshop_btn.TabIndex = 2;
            this.workshop_btn.Text = "Workshop";
            this.workshop_btn.UseVisualStyleBackColor = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search_btn.Location = new System.Drawing.Point(66, 307);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(457, 47);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.workshop_btn);
            this.Controls.Add(this.inventory_btn);
            this.Controls.Add(this.label1);
            this.Name = "welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button workshop_btn;
        private System.Windows.Forms.Button search_btn;
    }
}