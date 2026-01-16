namespace Vermeulen_Lars_SB1
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Voer de naam van de comedyshow in:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(421, 39);
            textBox2.TabIndex = 1;
            textBox2.Text = "Score van de show:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(421, 39);
            textBox3.TabIndex = 2;
            textBox3.Text = "Gemiddelde score";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(49, 316);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(421, 39);
            textBox4.TabIndex = 3;
            textBox4.Text = "Laatste Show";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(49, 372);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(421, 39);
            textBox5.TabIndex = 4;
            textBox5.Text = "Aantal Shows";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 257);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 5;
            label1.Text = "Gem score";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 316);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 6;
            label2.Text = "Laatste Show";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 372);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 7;
            label3.Text = "Aantal Shows";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(199, 169);
            button1.Name = "button1";
            button1.Size = new Size(404, 50);
            button1.TabIndex = 8;
            button1.Text = "Show Toevoegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(533, 33);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 39);
            textBox6.TabIndex = 9;
            textBox6.Text = "......";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(533, 92);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(189, 39);
            textBox7.TabIndex = 10;
            textBox7.Text = "......";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}
