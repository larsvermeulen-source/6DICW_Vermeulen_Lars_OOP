namespace Dobbelsteen
{
    partial class StartForm
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
            this.dobbelsteen6Button = new System.Windows.Forms.Button();
            this.dobbelsteen12Button = new System.Windows.Forms.Button();
            this.dobbelsteenXButton = new System.Windows.Forms.Button();
            this.zijdenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.zijdenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dobbelsteen6Button
            // 
            this.dobbelsteen6Button.Location = new System.Drawing.Point(282, 35);
            this.dobbelsteen6Button.Name = "dobbelsteen6Button";
            this.dobbelsteen6Button.Size = new System.Drawing.Size(190, 86);
            this.dobbelsteen6Button.TabIndex = 0;
            this.dobbelsteen6Button.Text = "6-zijdige dobbelsteen";
            this.dobbelsteen6Button.UseVisualStyleBackColor = true;
            this.dobbelsteen6Button.Click += new System.EventHandler(this.dobbelsteen6Button_Click);
            // 
            // dobbelsteen12Button
            // 
            this.dobbelsteen12Button.Location = new System.Drawing.Point(288, 144);
            this.dobbelsteen12Button.Name = "dobbelsteen12Button";
            this.dobbelsteen12Button.Size = new System.Drawing.Size(184, 78);
            this.dobbelsteen12Button.TabIndex = 1;
            this.dobbelsteen12Button.Text = "12-zijdige dobbelsteen";
            this.dobbelsteen12Button.UseVisualStyleBackColor = true;
            this.dobbelsteen12Button.Click += new System.EventHandler(this.dobelsteen12Button_Click);
            // 
            // dobbelsteenXButton
            // 
            this.dobbelsteenXButton.Location = new System.Drawing.Point(255, 343);
            this.dobbelsteenXButton.Name = "dobbelsteenXButton";
            this.dobbelsteenXButton.Size = new System.Drawing.Size(248, 77);
            this.dobbelsteenXButton.TabIndex = 2;
            this.dobbelsteenXButton.Text = "x-zijdige dobbelsteen";
            this.dobbelsteenXButton.UseVisualStyleBackColor = true;
            this.dobbelsteenXButton.Click += new System.EventHandler(this.dobbelsteenXButton_Click);
            // 
            // zijdenNumericUpDown
            // 
            this.zijdenNumericUpDown.Location = new System.Drawing.Point(246, 292);
            this.zijdenNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zijdenNumericUpDown.Name = "zijdenNumericUpDown";
            this.zijdenNumericUpDown.Size = new System.Drawing.Size(275, 31);
            this.zijdenNumericUpDown.TabIndex = 3;
            this.zijdenNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zijdenNumericUpDown);
            this.Controls.Add(this.dobbelsteenXButton);
            this.Controls.Add(this.dobbelsteen12Button);
            this.Controls.Add(this.dobbelsteen6Button);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.zijdenNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dobbelsteen6Button;
        private System.Windows.Forms.Button dobbelsteen12Button;
        private System.Windows.Forms.Button dobbelsteenXButton;
        private System.Windows.Forms.NumericUpDown zijdenNumericUpDown;
    }
}