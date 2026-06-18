namespace Presentation
{
    partial class Form1
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
            this.lblDetectorTest = new System.Windows.Forms.Label();
            this.btnDetectCyclon = new System.Windows.Forms.Button();
            this.btnLaatVloot = new System.Windows.Forms.Button();
            this.btnLaatPersonages = new System.Windows.Forms.Button();
            this.btnHerlaadData = new System.Windows.Forms.Button();
            this.btnLaadPlaneten = new System.Windows.Forms.Button();
            this.dgvVloot = new System.Windows.Forms.DataGridView();
            this.dgvPersonages = new System.Windows.Forms.DataGridView();
            this.dgvPlaneten = new System.Windows.Forms.DataGridView();
            this.btnDeleteCyclon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVloot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaneten)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetectorTest
            // 
            this.lblDetectorTest.BackColor = System.Drawing.Color.Transparent;
            this.lblDetectorTest.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetectorTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDetectorTest.Location = new System.Drawing.Point(303, 22);
            this.lblDetectorTest.Name = "lblDetectorTest";
            this.lblDetectorTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDetectorTest.Size = new System.Drawing.Size(1362, 157);
            this.lblDetectorTest.TabIndex = 0;
            this.lblDetectorTest.Text = "Cyclon Detecter Test";
            this.lblDetectorTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetectCyclon
            // 
            this.btnDetectCyclon.Location = new System.Drawing.Point(33, 136);
            this.btnDetectCyclon.Name = "btnDetectCyclon";
            this.btnDetectCyclon.Size = new System.Drawing.Size(239, 93);
            this.btnDetectCyclon.TabIndex = 1;
            this.btnDetectCyclon.Text = "Detect Cyclon";
            this.btnDetectCyclon.UseVisualStyleBackColor = true;
            this.btnDetectCyclon.Click += new System.EventHandler(this.btnDetectCyclon_Click);
            // 
            // btnLaatVloot
            // 
            this.btnLaatVloot.Location = new System.Drawing.Point(33, 235);
            this.btnLaatVloot.Name = "btnLaatVloot";
            this.btnLaatVloot.Size = new System.Drawing.Size(239, 93);
            this.btnLaatVloot.TabIndex = 2;
            this.btnLaatVloot.Text = "Laad Vloot";
            this.btnLaatVloot.UseVisualStyleBackColor = true;
            this.btnLaatVloot.Click += new System.EventHandler(this.btnLaatVloot_Click);
            // 
            // btnLaatPersonages
            // 
            this.btnLaatPersonages.Location = new System.Drawing.Point(33, 334);
            this.btnLaatPersonages.Name = "btnLaatPersonages";
            this.btnLaatPersonages.Size = new System.Drawing.Size(239, 93);
            this.btnLaatPersonages.TabIndex = 3;
            this.btnLaatPersonages.Text = "Laad Personages";
            this.btnLaatPersonages.UseVisualStyleBackColor = true;
            this.btnLaatPersonages.Click += new System.EventHandler(this.btnLaatPersonages_Click);
            // 
            // btnHerlaadData
            // 
            this.btnHerlaadData.Location = new System.Drawing.Point(33, 433);
            this.btnHerlaadData.Name = "btnHerlaadData";
            this.btnHerlaadData.Size = new System.Drawing.Size(239, 93);
            this.btnHerlaadData.TabIndex = 4;
            this.btnHerlaadData.Text = "Herlaad Data";
            this.btnHerlaadData.UseVisualStyleBackColor = true;
            this.btnHerlaadData.Click += new System.EventHandler(this.btnHerlaadData_Click);
            // 
            // btnLaadPlaneten
            // 
            this.btnLaadPlaneten.Location = new System.Drawing.Point(33, 532);
            this.btnLaadPlaneten.Name = "btnLaadPlaneten";
            this.btnLaadPlaneten.Size = new System.Drawing.Size(239, 93);
            this.btnLaadPlaneten.TabIndex = 5;
            this.btnLaadPlaneten.Text = "Laad Planeten";
            this.btnLaadPlaneten.UseVisualStyleBackColor = true;
            this.btnLaadPlaneten.Click += new System.EventHandler(this.btnLaadPlaneten_Click);
            // 
            // dgvVloot
            // 
            this.dgvVloot.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvVloot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVloot.Location = new System.Drawing.Point(78, 707);
            this.dgvVloot.Name = "dgvVloot";
            this.dgvVloot.RowHeadersWidth = 82;
            this.dgvVloot.RowTemplate.Height = 33;
            this.dgvVloot.Size = new System.Drawing.Size(1340, 284);
            this.dgvVloot.TabIndex = 6;
            // 
            // dgvPersonages
            // 
            this.dgvPersonages.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPersonages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonages.Location = new System.Drawing.Point(1450, 216);
            this.dgvPersonages.Name = "dgvPersonages";
            this.dgvPersonages.RowHeadersWidth = 82;
            this.dgvPersonages.RowTemplate.Height = 33;
            this.dgvPersonages.Size = new System.Drawing.Size(566, 775);
            this.dgvPersonages.TabIndex = 7;
            // 
            // dgvPlaneten
            // 
            this.dgvPlaneten.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPlaneten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaneten.Location = new System.Drawing.Point(303, 391);
            this.dgvPlaneten.Name = "dgvPlaneten";
            this.dgvPlaneten.RowHeadersWidth = 82;
            this.dgvPlaneten.RowTemplate.Height = 33;
            this.dgvPlaneten.Size = new System.Drawing.Size(1115, 284);
            this.dgvPlaneten.TabIndex = 8;
            // 
            // btnDeleteCyclon
            // 
            this.btnDeleteCyclon.Location = new System.Drawing.Point(1713, 49);
            this.btnDeleteCyclon.Name = "btnDeleteCyclon";
            this.btnDeleteCyclon.Size = new System.Drawing.Size(239, 93);
            this.btnDeleteCyclon.TabIndex = 9;
            this.btnDeleteCyclon.Text = "Verwijder \r\nDe Cyclon";
            this.btnDeleteCyclon.UseVisualStyleBackColor = true;
            this.btnDeleteCyclon.Visible = false;
            this.btnDeleteCyclon.Click += new System.EventHandler(this.btnDeleteCyclon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Presentation.Properties.Resources.Achtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2028, 1003);
            this.Controls.Add(this.btnDeleteCyclon);
            this.Controls.Add(this.dgvPlaneten);
            this.Controls.Add(this.dgvPersonages);
            this.Controls.Add(this.dgvVloot);
            this.Controls.Add(this.btnLaadPlaneten);
            this.Controls.Add(this.btnHerlaadData);
            this.Controls.Add(this.btnLaatPersonages);
            this.Controls.Add(this.btnLaatVloot);
            this.Controls.Add(this.btnDetectCyclon);
            this.Controls.Add(this.lblDetectorTest);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVloot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaneten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDetectorTest;
        private System.Windows.Forms.Button btnDetectCyclon;
        private System.Windows.Forms.Button btnLaatVloot;
        private System.Windows.Forms.Button btnLaatPersonages;
        private System.Windows.Forms.Button btnHerlaadData;
        private System.Windows.Forms.Button btnLaadPlaneten;
        private System.Windows.Forms.DataGridView dgvVloot;
        private System.Windows.Forms.DataGridView dgvPersonages;
        private System.Windows.Forms.DataGridView dgvPlaneten;
        private System.Windows.Forms.Button btnDeleteCyclon;
    }
}

