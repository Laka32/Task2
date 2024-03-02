namespace Task2
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "16";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F);
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 1;
            label1.Text = "Size X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "Size Y";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "16";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(246, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14F);
            button1.Location = new Point(2, 192);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 5;
            button1.Text = "Select file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(246, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "File:      ";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Times New Roman", 14F);
            button2.Location = new Point(113, 192);
            button2.Name = "button2";
            button2.Size = new Size(120, 45);
            button2.TabIndex = 7;
            button2.Text = "Visualize";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "64";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(12, 37);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 9;
            label4.Text = "Bytes to read";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Times New Roman", 14F);
            button3.Location = new Point(21, 257);
            button3.Name = "button3";
            button3.Size = new Size(183, 35);
            button3.TabIndex = 10;
            button3.Text = "Save To File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 406);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private Button button3;
    }
}
