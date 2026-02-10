namespace drielagenmodel_kindvoorspeller_Lars_Vermeulen
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Tag = "lengte man";
            label1.Text = "lengte man in cm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 1;
            label2.Tag = "lengte vrouw";
            label2.Text = "lengte vrouw in cm:";
            // 
            // button1
            // 
            button1.Location = new Point(721, 152);
            button1.Name = "button1";
            button1.Size = new Size(307, 44);
            button1.TabIndex = 2;
            button1.Tag = "bereken dochter";
            button1.Text = "bereken lengte dochter\r\n\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(721, 218);
            button2.Name = "button2";
            button2.Size = new Size(307, 41);
            button2.TabIndex = 3;
            button2.Tag = "bereken zoon";
            button2.Text = "bereken lengte zoon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Arial", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(299, 348);
            label3.Name = "label3";
            label3.Size = new Size(0, 80);
            label3.TabIndex = 4;
            label3.Tag = "Lengte baby";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 564);
            label4.Name = "label4";
            label4.Size = new Size(286, 32);
            label4.TabIndex = 5;
            label4.Tag = "Aantal voorspellingen";
            label4.Text = "Nog geen voorspellingen\r\n";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 39);
            textBox1.TabIndex = 6;
            textBox1.Tag = "lengte man";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 39);
            textBox2.TabIndex = 7;
            textBox2.Tag = "lengte vrouw";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kind;
            ClientSize = new Size(1054, 642);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}
