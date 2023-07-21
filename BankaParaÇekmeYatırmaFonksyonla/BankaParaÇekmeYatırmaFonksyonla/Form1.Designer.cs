namespace BankaParaÇekmeYatırmaFonksyonla
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
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 18);
            label1.Name = "label1";
            label1.Size = new Size(270, 35);
            label1.TabIndex = 0;
            label1.Text = "Bankamıza Hoşgeldiniz";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 380);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(167, 307);
            label4.Name = "label4";
            label4.Size = new Size(34, 28);
            label4.TabIndex = 6;
            label4.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 307);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 5;
            label5.Text = "kalan hak";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 178);
            button1.Name = "button1";
            button1.Size = new Size(127, 60);
            button1.TabIndex = 4;
            button1.Text = "giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 112);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 1;
            label2.Text = "isim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(387, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 380);
            panel2.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(207, 197);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(75, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "onayla";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(207, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(162, 294);
            label7.Name = "label7";
            label7.Size = new Size(116, 46);
            label7.TabIndex = 7;
            label7.Text = "bakiye";
            label7.Click += label7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(207, 77);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "onayla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(315, 294);
            label6.Name = "label6";
            label6.Size = new Size(56, 46);
            label6.TabIndex = 5;
            label6.Text = "00";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(18, 277);
            button4.Name = "button4";
            button4.Size = new Size(102, 58);
            button4.TabIndex = 2;
            button4.Text = "bakiye görüntüle";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(18, 154);
            button3.Name = "button3";
            button3.Size = new Size(102, 58);
            button3.TabIndex = 1;
            button3.Text = "para yatırma";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 34);
            button2.Name = "button2";
            button2.Size = new Size(102, 58);
            button2.TabIndex = 0;
            button2.Text = "para çekme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(896, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox3;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private CheckBox checkBox2;
        private TextBox textBox4;
    }
}