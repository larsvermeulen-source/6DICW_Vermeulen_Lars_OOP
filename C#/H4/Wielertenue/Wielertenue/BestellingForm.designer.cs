namespace Wielertenue
{
    partial class BestellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingForm));
            this.wielertruiPictureBox = new System.Windows.Forms.PictureBox();
            this.wielertenuePictureBox = new System.Windows.Forms.PictureBox();
            this.aantalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.waterdichtZakjeCheckBox = new System.Windows.Forms.CheckBox();
            this.broekCheckBox = new System.Windows.Forms.CheckBox();
            this.superzeemCheckBox = new System.Windows.Forms.CheckBox();
            this.prijsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // wielertruiPictureBox
            // 
            this.wielertruiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertruiPictureBox.Image")));
            this.wielertruiPictureBox.Location = new System.Drawing.Point(32, 17);
            this.wielertruiPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.wielertruiPictureBox.Name = "wielertruiPictureBox";
            this.wielertruiPictureBox.Size = new System.Drawing.Size(716, 663);
            this.wielertruiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertruiPictureBox.TabIndex = 0;
            this.wielertruiPictureBox.TabStop = false;
            // 
            // wielertenuePictureBox
            // 
            this.wielertenuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertenuePictureBox.Image")));
            this.wielertenuePictureBox.Location = new System.Drawing.Point(32, 32);
            this.wielertenuePictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.wielertenuePictureBox.Name = "wielertenuePictureBox";
            this.wielertenuePictureBox.Size = new System.Drawing.Size(716, 663);
            this.wielertenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertenuePictureBox.TabIndex = 0;
            this.wielertenuePictureBox.TabStop = false;
            this.wielertenuePictureBox.Tag = "Broek+Trui";
            this.wielertenuePictureBox.Visible = false;
            this.wielertenuePictureBox.Click += new System.EventHandler(this.wielertenuePictureBox_Click);
            // 
            // aantalNumericUpDown
            // 
            this.aantalNumericUpDown.Location = new System.Drawing.Point(867, 82);
            this.aantalNumericUpDown.Name = "aantalNumericUpDown";
            this.aantalNumericUpDown.Size = new System.Drawing.Size(304, 31);
            this.aantalNumericUpDown.TabIndex = 1;
            this.aantalNumericUpDown.Tag = "";
            this.aantalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalNumericUpDown.ValueChanged += new System.EventHandler(this.aantalNumericUpDown_ValueChanged);
            // 
            // waterdichtZakjeCheckBox
            // 
            this.waterdichtZakjeCheckBox.AutoSize = true;
            this.waterdichtZakjeCheckBox.Location = new System.Drawing.Point(834, 201);
            this.waterdichtZakjeCheckBox.Name = "waterdichtZakjeCheckBox";
            this.waterdichtZakjeCheckBox.Size = new System.Drawing.Size(293, 29);
            this.waterdichtZakjeCheckBox.TabIndex = 2;
            this.waterdichtZakjeCheckBox.Text = "waterdichtZakjeCheckBox";
            this.waterdichtZakjeCheckBox.UseVisualStyleBackColor = true;
            this.waterdichtZakjeCheckBox.CheckedChanged += new System.EventHandler(this.waterdichtZakjeCheckBox_CheckedChanged);
            // 
            // broekCheckBox
            // 
            this.broekCheckBox.AutoSize = true;
            this.broekCheckBox.Location = new System.Drawing.Point(834, 261);
            this.broekCheckBox.Name = "broekCheckBox";
            this.broekCheckBox.Size = new System.Drawing.Size(196, 29);
            this.broekCheckBox.TabIndex = 3;
            this.broekCheckBox.Text = "broekCheckBox";
            this.broekCheckBox.UseVisualStyleBackColor = true;
            this.broekCheckBox.CheckedChanged += new System.EventHandler(this.broekCheckBox_CheckedChanged);
            // 
            // superzeemCheckBox
            // 
            this.superzeemCheckBox.AutoSize = true;
            this.superzeemCheckBox.Location = new System.Drawing.Point(834, 322);
            this.superzeemCheckBox.Name = "superzeemCheckBox";
            this.superzeemCheckBox.Size = new System.Drawing.Size(248, 54);
            this.superzeemCheckBox.TabIndex = 4;
            this.superzeemCheckBox.Text = "superzeemCheckBox\r\n\r\n";
            this.superzeemCheckBox.UseVisualStyleBackColor = true;
            this.superzeemCheckBox.Visible = false;
            this.superzeemCheckBox.CheckedChanged += new System.EventHandler(this.superzeemCheckBox_CheckedChanged);
            // 
            // prijsTextBox
            // 
            this.prijsTextBox.Location = new System.Drawing.Point(831, 466);
            this.prijsTextBox.Name = "prijsTextBox";
            this.prijsTextBox.ReadOnly = true;
            this.prijsTextBox.Size = new System.Drawing.Size(295, 31);
            this.prijsTextBox.TabIndex = 5;
            this.prijsTextBox.TextChanged += new System.EventHandler(this.prijsTextBox_TextChanged);
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 710);
            this.Controls.Add(this.prijsTextBox);
            this.Controls.Add(this.superzeemCheckBox);
            this.Controls.Add(this.broekCheckBox);
            this.Controls.Add(this.waterdichtZakjeCheckBox);
            this.Controls.Add(this.aantalNumericUpDown);
            this.Controls.Add(this.wielertenuePictureBox);
            this.Controls.Add(this.wielertruiPictureBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BestellingForm";
            this.Text = "BestellingWielertenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wielertruiPictureBox;
        private System.Windows.Forms.PictureBox wielertenuePictureBox;
        private System.Windows.Forms.NumericUpDown aantalNumericUpDown;
        private System.Windows.Forms.CheckBox waterdichtZakjeCheckBox;
        private System.Windows.Forms.CheckBox broekCheckBox;
        private System.Windows.Forms.CheckBox superzeemCheckBox;
        private System.Windows.Forms.TextBox prijsTextBox;
    }
}