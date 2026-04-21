namespace testDND_Vermeulen_Lars
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
            this.components = new System.ComponentModel.Container();
            this.CharacterTextBox = new System.Windows.Forms.TextBox();
            this.KrachtTextBox = new System.Windows.Forms.TextBox();
            this.ToonFormulierButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VoegToeButton = new System.Windows.Forms.Button();
            this.ToonHierButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToonHierTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CharacterTextBox
            // 
            this.CharacterTextBox.Location = new System.Drawing.Point(52, 60);
            this.CharacterTextBox.Name = "CharacterTextBox";
            this.CharacterTextBox.Size = new System.Drawing.Size(251, 31);
            this.CharacterTextBox.TabIndex = 0;
            // 
            // KrachtTextBox
            // 
            this.KrachtTextBox.Location = new System.Drawing.Point(52, 101);
            this.KrachtTextBox.Name = "KrachtTextBox";
            this.KrachtTextBox.Size = new System.Drawing.Size(274, 31);
            this.KrachtTextBox.TabIndex = 1;
            // 
            // ToonFormulierButton
            // 
            this.ToonFormulierButton.Location = new System.Drawing.Point(207, 237);
            this.ToonFormulierButton.Name = "ToonFormulierButton";
            this.ToonFormulierButton.Size = new System.Drawing.Size(150, 84);
            this.ToonFormulierButton.TabIndex = 3;
            this.ToonFormulierButton.Text = "toon formulier";
            this.ToonFormulierButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Tag = "CharacterMenu";
            // 
            // VoegToeButton
            // 
            this.VoegToeButton.Location = new System.Drawing.Point(400, 60);
            this.VoegToeButton.Name = "VoegToeButton";
            this.VoegToeButton.Size = new System.Drawing.Size(204, 70);
            this.VoegToeButton.TabIndex = 5;
            this.VoegToeButton.Text = "...voeg toe";
            this.VoegToeButton.UseVisualStyleBackColor = true;
            this.VoegToeButton.Click += new System.EventHandler(this.VoegToeButton_Click);
            // 
            // ToonHierButton
            // 
            this.ToonHierButton.Location = new System.Drawing.Point(146, 337);
            this.ToonHierButton.Name = "ToonHierButton";
            this.ToonHierButton.Size = new System.Drawing.Size(272, 49);
            this.ToonHierButton.TabIndex = 6;
            this.ToonHierButton.Text = "toon hier";
            this.ToonHierButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ToonHierTextBox
            // 
            this.ToonHierTextBox.Location = new System.Drawing.Point(440, 392);
            this.ToonHierTextBox.Name = "ToonHierTextBox";
            this.ToonHierTextBox.ReadOnly = true;
            this.ToonHierTextBox.Size = new System.Drawing.Size(194, 31);
            this.ToonHierTextBox.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 458);
            this.Controls.Add(this.ToonHierTextBox);
            this.Controls.Add(this.ToonHierButton);
            this.Controls.Add(this.VoegToeButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ToonFormulierButton);
            this.Controls.Add(this.KrachtTextBox);
            this.Controls.Add(this.CharacterTextBox);
            this.Name = "StartForm";
            this.Tag = "";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.TextBox KrachtTextBox;
        private System.Windows.Forms.Button ToonFormulierButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button VoegToeButton;
        private System.Windows.Forms.Button ToonHierButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ToonHierTextBox;
    }
}

