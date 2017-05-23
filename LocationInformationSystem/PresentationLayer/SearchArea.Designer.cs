namespace PresentationLayer
{
    partial class SearchArea
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
            this.Restarauntrb = new System.Windows.Forms.RadioButton();
            this.pharmacyrb = new System.Windows.Forms.RadioButton();
            this.ShoppingMallrb = new System.Windows.Forms.RadioButton();
            this.hospitalrb = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Restarauntrb
            // 
            this.Restarauntrb.AutoSize = true;
            this.Restarauntrb.Location = new System.Drawing.Point(152, 45);
            this.Restarauntrb.Name = "Restarauntrb";
            this.Restarauntrb.Size = new System.Drawing.Size(77, 17);
            this.Restarauntrb.TabIndex = 11;
            this.Restarauntrb.TabStop = true;
            this.Restarauntrb.Text = "Restaraunt";
            this.Restarauntrb.UseVisualStyleBackColor = true;
            // 
            // pharmacyrb
            // 
            this.pharmacyrb.AutoSize = true;
            this.pharmacyrb.Location = new System.Drawing.Point(152, -6);
            this.pharmacyrb.Name = "pharmacyrb";
            this.pharmacyrb.Size = new System.Drawing.Size(72, 17);
            this.pharmacyrb.TabIndex = 10;
            this.pharmacyrb.TabStop = true;
            this.pharmacyrb.Text = "Pharmacy";
            this.pharmacyrb.UseVisualStyleBackColor = true;
            // 
            // ShoppingMallrb
            // 
            this.ShoppingMallrb.AutoSize = true;
            this.ShoppingMallrb.Location = new System.Drawing.Point(20, 45);
            this.ShoppingMallrb.Name = "ShoppingMallrb";
            this.ShoppingMallrb.Size = new System.Drawing.Size(89, 17);
            this.ShoppingMallrb.TabIndex = 9;
            this.ShoppingMallrb.TabStop = true;
            this.ShoppingMallrb.Text = "ShoppingMall";
            this.ShoppingMallrb.UseVisualStyleBackColor = true;
            // 
            // hospitalrb
            // 
            this.hospitalrb.AutoSize = true;
            this.hospitalrb.Location = new System.Drawing.Point(20, -6);
            this.hospitalrb.Name = "hospitalrb";
            this.hospitalrb.Size = new System.Drawing.Size(63, 17);
            this.hospitalrb.TabIndex = 8;
            this.hospitalrb.TabStop = true;
            this.hospitalrb.Text = "Hospital";
            this.hospitalrb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Area";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restarauntrb);
            this.Controls.Add(this.pharmacyrb);
            this.Controls.Add(this.ShoppingMallrb);
            this.Controls.Add(this.hospitalrb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchArea";
            this.Text = "SearchArea";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Restarauntrb;
        private System.Windows.Forms.RadioButton pharmacyrb;
        private System.Windows.Forms.RadioButton ShoppingMallrb;
        private System.Windows.Forms.RadioButton hospitalrb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}