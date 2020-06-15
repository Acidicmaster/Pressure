namespace Pore_Pressure_Prediction
{
    partial class Pressure_Calc
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
            this.Input_Panel = new System.Windows.Forms.Panel();
            this.predict_Btn = new System.Windows.Forms.Button();
            this.Time_TextBox = new System.Windows.Forms.TextBox();
            this.maxDepth_Box = new System.Windows.Forms.TextBox();
            this.density_textBox = new System.Windows.Forms.TextBox();
            this.porosity_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_view = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Input_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_Panel
            // 
            this.Input_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Input_Panel.Controls.Add(this.label10);
            this.Input_Panel.Controls.Add(this.label9);
            this.Input_Panel.Controls.Add(this.label8);
            this.Input_Panel.Controls.Add(this.label7);
            this.Input_Panel.Controls.Add(this.label6);
            this.Input_Panel.Controls.Add(this.predict_Btn);
            this.Input_Panel.Controls.Add(this.Time_TextBox);
            this.Input_Panel.Controls.Add(this.maxDepth_Box);
            this.Input_Panel.Controls.Add(this.density_textBox);
            this.Input_Panel.Controls.Add(this.porosity_textBox);
            this.Input_Panel.Controls.Add(this.label4);
            this.Input_Panel.Controls.Add(this.label3);
            this.Input_Panel.Controls.Add(this.label2);
            this.Input_Panel.Controls.Add(this.label1);
            this.Input_Panel.Location = new System.Drawing.Point(2, 79);
            this.Input_Panel.Name = "Input_Panel";
            this.Input_Panel.Size = new System.Drawing.Size(245, 436);
            this.Input_Panel.TabIndex = 0;
            this.Input_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Panel_Paint);
            // 
            // predict_Btn
            // 
            this.predict_Btn.Location = new System.Drawing.Point(60, 255);
            this.predict_Btn.Name = "predict_Btn";
            this.predict_Btn.Size = new System.Drawing.Size(140, 36);
            this.predict_Btn.TabIndex = 8;
            this.predict_Btn.Text = "Predict";
            this.predict_Btn.UseVisualStyleBackColor = true;
            this.predict_Btn.Click += new System.EventHandler(this.predict_Btn_Click);
            // 
            // Time_TextBox
            // 
            this.Time_TextBox.Location = new System.Drawing.Point(98, 209);
            this.Time_TextBox.Name = "Time_TextBox";
            this.Time_TextBox.Size = new System.Drawing.Size(96, 20);
            this.Time_TextBox.TabIndex = 7;
            // 
            // maxDepth_Box
            // 
            this.maxDepth_Box.Location = new System.Drawing.Point(98, 173);
            this.maxDepth_Box.Name = "maxDepth_Box";
            this.maxDepth_Box.Size = new System.Drawing.Size(96, 20);
            this.maxDepth_Box.TabIndex = 6;
            this.maxDepth_Box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // density_textBox
            // 
            this.density_textBox.Location = new System.Drawing.Point(98, 136);
            this.density_textBox.Name = "density_textBox";
            this.density_textBox.Size = new System.Drawing.Size(47, 20);
            this.density_textBox.TabIndex = 5;
            // 
            // porosity_textBox
            // 
            this.porosity_textBox.Location = new System.Drawing.Point(98, 104);
            this.porosity_textBox.Name = "porosity_textBox";
            this.porosity_textBox.Size = new System.Drawing.Size(47, 20);
            this.porosity_textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transit time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Density :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max. Depth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porosity :";
            // 
            // datagrid_view
            // 
            this.datagrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_view.Location = new System.Drawing.Point(253, 79);
            this.datagrid_view.Name = "datagrid_view";
            this.datagrid_view.Size = new System.Drawing.Size(446, 436);
            this.datagrid_view.TabIndex = 1;
            this.datagrid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_view_CellContentClick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(786, 34);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 481);
            this.vScrollBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 74);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(71, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(575, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Real Time Pore Pressure Predictor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ib/cu-ft";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "millisecs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pressure --> Psig";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "shear wave velocity (ft/s)";
            // 
            // Pressure_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.datagrid_view);
            this.Controls.Add(this.Input_Panel);
            this.MaximizeBox = false;
            this.Name = "Pressure_Calc";
            this.Text = "Pressure_Calc";
            this.Load += new System.EventHandler(this.Pressure_Calc_Load);
            this.Input_Panel.ResumeLayout(false);
            this.Input_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Input_Panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox density_textBox;
        private System.Windows.Forms.TextBox porosity_textBox;
        private System.Windows.Forms.TextBox maxDepth_Box;
        private System.Windows.Forms.Button predict_Btn;
        private System.Windows.Forms.TextBox Time_TextBox;
        private System.Windows.Forms.DataGridView datagrid_view;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}