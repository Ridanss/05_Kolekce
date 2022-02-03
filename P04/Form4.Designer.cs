namespace P04
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lichy_toggle = new System.Windows.Forms.RadioButton();
            this.sudy_toggle = new System.Windows.Forms.RadioButton();
            this.zapornych_toggle = new System.Windows.Forms.RadioButton();
            this.execute = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Panel();
            this.input.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "-8";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "12";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "3";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "-2";
            // 
            // lichy_toggle
            // 
            this.lichy_toggle.AutoSize = true;
            this.lichy_toggle.Checked = true;
            this.lichy_toggle.Location = new System.Drawing.Point(59, 201);
            this.lichy_toggle.Name = "lichy_toggle";
            this.lichy_toggle.Size = new System.Drawing.Size(115, 20);
            this.lichy_toggle.TabIndex = 5;
            this.lichy_toggle.TabStop = true;
            this.lichy_toggle.Text = "Průměr lichých";
            this.lichy_toggle.UseVisualStyleBackColor = true;
            // 
            // sudy_toggle
            // 
            this.sudy_toggle.AutoSize = true;
            this.sudy_toggle.Location = new System.Drawing.Point(59, 227);
            this.sudy_toggle.Name = "sudy_toggle";
            this.sudy_toggle.Size = new System.Drawing.Size(117, 20);
            this.sudy_toggle.TabIndex = 6;
            this.sudy_toggle.Text = "Průměr sudých";
            this.sudy_toggle.UseVisualStyleBackColor = true;
            // 
            // zapornych_toggle
            // 
            this.zapornych_toggle.AutoSize = true;
            this.zapornych_toggle.Location = new System.Drawing.Point(59, 253);
            this.zapornych_toggle.Name = "zapornych_toggle";
            this.zapornych_toggle.Size = new System.Drawing.Size(136, 20);
            this.zapornych_toggle.TabIndex = 7;
            this.zapornych_toggle.Text = "Průměr záporných";
            this.zapornych_toggle.UseVisualStyleBackColor = true;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(202, 105);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 8;
            this.execute.Text = "Průměr";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(283, 108);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(10, 16);
            this.output.TabIndex = 9;
            this.output.Text = ":";
            // 
            // input
            // 
            this.input.Controls.Add(this.textBox5);
            this.input.Controls.Add(this.textBox1);
            this.input.Controls.Add(this.textBox2);
            this.input.Controls.Add(this.textBox3);
            this.input.Controls.Add(this.textBox4);
            this.input.Location = new System.Drawing.Point(44, 24);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(130, 171);
            this.input.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.output);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.zapornych_toggle);
            this.Controls.Add(this.sudy_toggle);
            this.Controls.Add(this.lichy_toggle);
            this.Controls.Add(this.input);
            this.Name = "Form4";
            this.Text = "Form1";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton lichy_toggle;
        private System.Windows.Forms.RadioButton sudy_toggle;
        private System.Windows.Forms.RadioButton zapornych_toggle;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Panel input;
    }
}

