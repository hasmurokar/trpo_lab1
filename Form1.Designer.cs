namespace trpo_lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label_volume = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.textBox_thickness = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(129, 129);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(184, 23);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(426, 129);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(273, 23);
            this.textBox_cost.TabIndex = 1;
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(686, 359);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(13, 15);
            this.label_volume.TabIndex = 2;
            this.label_volume.Text = "0";
            this.label_volume.Click += new System.EventHandler(this.label_volume_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Стоимость в руб:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(426, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стоимость бетона за 1 куб.м";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип бетона";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(504, 227);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(115, 44);
            this.button.TabIndex = 6;
            this.button.Text = "Рассчитать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Необходимый объем бетона в куб.м:";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(686, 460);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(13, 15);
            this.label_cost.TabIndex = 8;
            this.label_cost.Text = "0";
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(138, 203);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(100, 23);
            this.textBox_length.TabIndex = 9;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(138, 248);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 23);
            this.textBox_width.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Длина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ширина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Толщина";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(166, 274);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(47, 15);
            this.label0.TabIndex = 15;
            this.label0.Text = "Высота";
            // 
            // textBox_thickness
            // 
            this.textBox_thickness.Location = new System.Drawing.Point(138, 339);
            this.textBox_thickness.Name = "textBox_thickness";
            this.textBox_thickness.Size = new System.Drawing.Size(100, 23);
            this.textBox_thickness.TabIndex = 14;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(138, 292);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 23);
            this.textBox_height.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.textBox_thickness);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox;
        private TextBox textBox_cost;
        private Label label_volume;
        private Label label6;
        private Label label1;
        private Label label2;
        private Button button;
        private Label label3;
        private Label label_cost;
        private TextBox textBox_length;
        private TextBox textBox_width;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label0;
        private TextBox textBox_thickness;
        private TextBox textBox_height;
    }
}