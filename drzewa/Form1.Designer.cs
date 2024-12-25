namespace drzewa
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
            treeView1 = new TreeView();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(13, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(302, 283);
            treeView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(346, 29);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 4;
            button1.Text = "dodaj";
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(568, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(447, 29);
            button2.Name = "button2";
            button2.Size = new Size(95, 37);
            button2.TabIndex = 5;
            button2.Text = "usun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(346, 82);
            button3.Name = "button3";
            button3.Size = new Size(95, 42);
            button3.TabIndex = 6;
            button3.Text = "wyswietl";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 360);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(540, 23);
            textBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(12, 301);
            button4.Name = "button4";
            button4.Size = new Size(95, 42);
            button4.TabIndex = 8;
            button4.Text = "PreOrder";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 349);
            button5.Name = "button5";
            button5.Size = new Size(95, 42);
            button5.TabIndex = 9;
            button5.Text = "InOrder";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 397);
            button6.Name = "button6";
            button6.Size = new Size(95, 42);
            button6.TabIndex = 10;
            button6.Text = "PostOrder";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
