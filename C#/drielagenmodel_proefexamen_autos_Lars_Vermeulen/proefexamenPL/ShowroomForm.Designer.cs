namespace proefexamenPL
{
    partial class ShowroomForm
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
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.btnToonDuitse = new System.Windows.Forms.Button();
            this.btnLaadAutos = new System.Windows.Forms.Button();
            this.btnOpenToevoegen = new System.Windows.Forms.Button();
            this.btnOpenWijzigen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(363, 21);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.RowHeadersWidth = 82;
            this.dgvAutos.RowTemplate.Height = 33;
            this.dgvAutos.Size = new System.Drawing.Size(618, 581);
            this.dgvAutos.TabIndex = 0;
            // 
            // btnToonDuitse
            // 
            this.btnToonDuitse.Location = new System.Drawing.Point(53, 149);
            this.btnToonDuitse.Name = "btnToonDuitse";
            this.btnToonDuitse.Size = new System.Drawing.Size(190, 69);
            this.btnToonDuitse.TabIndex = 1;
            this.btnToonDuitse.Text = "Toon Duitse Auto\'s";
            this.btnToonDuitse.UseVisualStyleBackColor = true;
            this.btnToonDuitse.Click += new System.EventHandler(this.btnToonDuitse_Click);
            // 
            // btnLaadAutos
            // 
            this.btnLaadAutos.Location = new System.Drawing.Point(53, 60);
            this.btnLaadAutos.Name = "btnLaadAutos";
            this.btnLaadAutos.Size = new System.Drawing.Size(190, 69);
            this.btnLaadAutos.TabIndex = 2;
            this.btnLaadAutos.Text = "Laad alle auto\'s";
            this.btnLaadAutos.UseVisualStyleBackColor = true;
            this.btnLaadAutos.Click += new System.EventHandler(this.btnLaadAutos_Click);
            // 
            // btnOpenToevoegen
            // 
            this.btnOpenToevoegen.Location = new System.Drawing.Point(53, 245);
            this.btnOpenToevoegen.Name = "btnOpenToevoegen";
            this.btnOpenToevoegen.Size = new System.Drawing.Size(190, 69);
            this.btnOpenToevoegen.TabIndex = 3;
            this.btnOpenToevoegen.Text = "Nieuwe Auto Toevoegen";
            this.btnOpenToevoegen.UseVisualStyleBackColor = true;
            this.btnOpenToevoegen.Click += new System.EventHandler(this.btnOpenToevoegen_Click);
            // 
            // btnOpenWijzigen
            // 
            this.btnOpenWijzigen.Location = new System.Drawing.Point(53, 344);
            this.btnOpenWijzigen.Name = "btnOpenWijzigen";
            this.btnOpenWijzigen.Size = new System.Drawing.Size(190, 69);
            this.btnOpenWijzigen.TabIndex = 4;
            this.btnOpenWijzigen.Text = "Geselecteerde Auto Wijzigen";
            this.btnOpenWijzigen.UseVisualStyleBackColor = true;
            this.btnOpenWijzigen.Click += new System.EventHandler(this.btnOpenWijzigen_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(53, 440);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(190, 69);
            this.btnVerwijder.TabIndex = 5;
            this.btnVerwijder.Text = "Geselecteerde Auto Wissen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // ShowroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 629);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnOpenWijzigen);
            this.Controls.Add(this.btnOpenToevoegen);
            this.Controls.Add(this.btnLaadAutos);
            this.Controls.Add(this.btnToonDuitse);
            this.Controls.Add(this.dgvAutos);
            this.Name = "ShowroomForm";
            this.Text = "ShowroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.Button btnToonDuitse;
        private System.Windows.Forms.Button btnLaadAutos;
        private System.Windows.Forms.Button btnOpenToevoegen;
        private System.Windows.Forms.Button btnOpenWijzigen;
        private System.Windows.Forms.Button btnVerwijder;
    }
}