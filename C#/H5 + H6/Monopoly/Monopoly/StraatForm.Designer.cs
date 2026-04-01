namespace Monopoly
{
    partial class StraatForm
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
            this.panelVak = new System.Windows.Forms.Panel();
            this.stadTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aantalHuizenTextBox = new System.Windows.Forms.TextBox();
            this.aantalHotelsTextBox = new System.Windows.Forms.TextBox();
            this.huurTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.koopHuisButton = new System.Windows.Forms.Button();
            this.koopHotelButton = new System.Windows.Forms.Button();
            this.panelVak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVak
            // 
            this.panelVak.BackColor = System.Drawing.Color.Yellow;
            this.panelVak.Controls.Add(this.stadTextBox);
            this.panelVak.Controls.Add(this.straatTextBox);
            this.panelVak.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVak.Location = new System.Drawing.Point(0, 0);
            this.panelVak.Name = "panelVak";
            this.panelVak.Size = new System.Drawing.Size(309, 89);
            this.panelVak.TabIndex = 0;
            // 
            // stadTextBox
            // 
            this.stadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stadTextBox.Location = new System.Drawing.Point(90, 50);
            this.stadTextBox.Name = "stadTextBox";
            this.stadTextBox.ReadOnly = true;
            this.stadTextBox.Size = new System.Drawing.Size(128, 22);
            this.stadTextBox.TabIndex = 1;
            this.stadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // straatTextBox
            // 
            this.straatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.straatTextBox.Location = new System.Drawing.Point(12, 13);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.ReadOnly = true;
            this.straatTextBox.Size = new System.Drawing.Size(285, 31);
            this.straatTextBox.TabIndex = 0;
            this.straatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "aantal huizen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "aantal hotels:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "huur:";
            // 
            // aantalHuizenTextBox
            // 
            this.aantalHuizenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantalHuizenTextBox.Location = new System.Drawing.Point(195, 123);
            this.aantalHuizenTextBox.Name = "aantalHuizenTextBox";
            this.aantalHuizenTextBox.ReadOnly = true;
            this.aantalHuizenTextBox.Size = new System.Drawing.Size(23, 22);
            this.aantalHuizenTextBox.TabIndex = 4;
            this.aantalHuizenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aantalHotelsTextBox
            // 
            this.aantalHotelsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantalHotelsTextBox.Location = new System.Drawing.Point(195, 157);
            this.aantalHotelsTextBox.Name = "aantalHotelsTextBox";
            this.aantalHotelsTextBox.ReadOnly = true;
            this.aantalHotelsTextBox.Size = new System.Drawing.Size(23, 22);
            this.aantalHotelsTextBox.TabIndex = 5;
            this.aantalHotelsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // huurTextBox
            // 
            this.huurTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huurTextBox.Location = new System.Drawing.Point(145, 191);
            this.huurTextBox.Name = "huurTextBox";
            this.huurTextBox.ReadOnly = true;
            this.huurTextBox.Size = new System.Drawing.Size(73, 22);
            this.huurTextBox.TabIndex = 6;
            this.huurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::Monopoly.Properties.Resources.monopoly;
            this.pictureBox1.Location = new System.Drawing.Point(0, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 147);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // koopHuisButton
            // 
            this.koopHuisButton.Location = new System.Drawing.Point(12, 254);
            this.koopHuisButton.Name = "koopHuisButton";
            this.koopHuisButton.Size = new System.Drawing.Size(75, 23);
            this.koopHuisButton.TabIndex = 8;
            this.koopHuisButton.Text = "koop huis";
            this.koopHuisButton.UseVisualStyleBackColor = true;
            this.koopHuisButton.Click += new System.EventHandler(this.koopHuisButton_Click);
            // 
            // koopHotelButton
            // 
            this.koopHotelButton.Location = new System.Drawing.Point(222, 254);
            this.koopHotelButton.Name = "koopHotelButton";
            this.koopHotelButton.Size = new System.Drawing.Size(75, 23);
            this.koopHotelButton.TabIndex = 9;
            this.koopHotelButton.Text = "koop hotel";
            this.koopHotelButton.UseVisualStyleBackColor = true;
            this.koopHotelButton.Click += new System.EventHandler(this.koopHotelButton_Click);
            // 
            // StraatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 433);
            this.Controls.Add(this.koopHotelButton);
            this.Controls.Add(this.koopHuisButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.huurTextBox);
            this.Controls.Add(this.aantalHotelsTextBox);
            this.Controls.Add(this.aantalHuizenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelVak);
            this.Name = "StraatForm";
            this.Text = "StraatForm";
            this.panelVak.ResumeLayout(false);
            this.panelVak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVak;
        private System.Windows.Forms.TextBox stadTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aantalHuizenTextBox;
        private System.Windows.Forms.TextBox aantalHotelsTextBox;
        private System.Windows.Forms.TextBox huurTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button koopHuisButton;
        private System.Windows.Forms.Button koopHotelButton;
    }
}

