namespace WindowsFormsApplication1
{
    partial class options
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chance_input = new System.Windows.Forms.TextBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cheat_mode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wait_bx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(149, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "easy";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the dificulty: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the chance of a random event:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chance_input
            // 
            this.chance_input.Location = new System.Drawing.Point(237, 130);
            this.chance_input.Name = "chance_input";
            this.chance_input.Size = new System.Drawing.Size(33, 20);
            this.chance_input.TabIndex = 3;
            this.chance_input.Text = "10";
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(195, 257);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 4;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "please enter a number between 1 and 100 \r\nfor the random events and\r\nless than 10" +
    " for the wait time";
            this.label3.Visible = false;
            // 
            // cheat_mode
            // 
            this.cheat_mode.AutoSize = true;
            this.cheat_mode.Location = new System.Drawing.Point(255, 196);
            this.cheat_mode.Name = "cheat_mode";
            this.cheat_mode.Size = new System.Drawing.Size(15, 14);
            this.cheat_mode.TabIndex = 6;
            this.cheat_mode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "cheat mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "set the wait time in seconds: ";
            // 
            // wait_bx
            // 
            this.wait_bx.Location = new System.Drawing.Point(184, 64);
            this.wait_bx.Name = "wait_bx";
            this.wait_bx.Size = new System.Drawing.Size(33, 20);
            this.wait_bx.TabIndex = 9;
            this.wait_bx.Text = "4";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 313);
            this.Controls.Add(this.wait_bx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cheat_mode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.chance_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chance_input;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cheat_mode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wait_bx;
    }
}