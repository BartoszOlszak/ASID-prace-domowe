﻿namespace NodeList
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 371);
            button1.Name = "button1";
            button1.Size = new Size(102, 52);
            button1.TabIndex = 0;
            button1.Text = "AddFirst";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(185, 371);
            button2.Name = "button2";
            button2.Size = new Size(102, 52);
            button2.TabIndex = 1;
            button2.Text = "AddLast";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(334, 371);
            button3.Name = "button3";
            button3.Size = new Size(102, 52);
            button3.TabIndex = 2;
            button3.Text = "RemoveFirst";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(496, 371);
            button4.Name = "button4";
            button4.Size = new Size(102, 52);
            button4.TabIndex = 3;
            button4.Text = "RemoveLast";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(645, 371);
            button5.Name = "button5";
            button5.Size = new Size(102, 52);
            button5.TabIndex = 4;
            button5.Text = "Get(index)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 33);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(520, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(520, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(227, 111);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(520, 23);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 36);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Twoja lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 287);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 11;
            label3.Text = "wprowadz liczbe lub index";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 111);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 12;
            label4.Text = "Wartosc(index)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
