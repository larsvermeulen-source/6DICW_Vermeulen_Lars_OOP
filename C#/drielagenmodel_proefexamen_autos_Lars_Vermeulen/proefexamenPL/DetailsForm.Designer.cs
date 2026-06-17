namespace proefexamenPL
{
    partial class DetailsForm
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
            this.lblMerk = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblLand = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Location = new System.Drawing.Point(278, 84);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(66, 25);
            this.lblMerk.TabIndex = 0;
            this.lblMerk.Text = "Merk:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(267, 126);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 25);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(284, 175);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(60, 25);
            this.lblPrijs.TabIndex = 2;
            this.lblPrijs.Text = "Prijs:";
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Location = new System.Drawing.Point(32, 223);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(312, 25);
            this.lblLand.TabIndex = 3;
            this.lblLand.Text = "Land van herkomst (Bijv. DEU):";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(114, 297);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(230, 80);
            this.btnOpslaan.TabIndex = 4;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(378, 297);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(230, 80);
            this.btnAnnuleren.TabIndex = 5;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(378, 78);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(153, 31);
            this.txtMerk.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(378, 120);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(153, 31);
            this.txtModel.TabIndex = 7;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(378, 169);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(153, 31);
            this.txtPrijs.TabIndex = 8;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(378, 220);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(153, 31);
            this.txtLand.TabIndex = 9;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lblLand);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMerk);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtLand;
    }
}