namespace testDND_Vermeulen_Lars
{
    partial class Karakter
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NaamTextBox = new System.Windows.Forms.TextBox();
            this.CharacterTextBox = new System.Windows.Forms.TextBox();
            this.KrachtTextBox = new System.Windows.Forms.TextBox();
            this.SterkteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NaamTextBox
            // 
            this.NaamTextBox.Location = new System.Drawing.Point(56, 132);
            this.NaamTextBox.Name = "NaamTextBox";
            this.NaamTextBox.Size = new System.Drawing.Size(232, 31);
            this.NaamTextBox.TabIndex = 1;
            this.NaamTextBox.Text = "Naam";
            // 
            // CharacterTextBox
            // 
            this.CharacterTextBox.Location = new System.Drawing.Point(403, 120);
            this.CharacterTextBox.Name = "CharacterTextBox";
            this.CharacterTextBox.Size = new System.Drawing.Size(232, 31);
            this.CharacterTextBox.TabIndex = 2;
            // 
            // KrachtTextBox
            // 
            this.KrachtTextBox.Location = new System.Drawing.Point(403, 210);
            this.KrachtTextBox.Name = "KrachtTextBox";
            this.KrachtTextBox.Size = new System.Drawing.Size(232, 31);
            this.KrachtTextBox.TabIndex = 3;
            // 
            // SterkteTextBox
            // 
            this.SterkteTextBox.Location = new System.Drawing.Point(56, 210);
            this.SterkteTextBox.Name = "SterkteTextBox";
            this.SterkteTextBox.Size = new System.Drawing.Size(232, 31);
            this.SterkteTextBox.TabIndex = 4;
            this.SterkteTextBox.Text = "Sterkte";
            // 
            // Karakter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SterkteTextBox);
            this.Controls.Add(this.KrachtTextBox);
            this.Controls.Add(this.CharacterTextBox);
            this.Controls.Add(this.NaamTextBox);
            this.Name = "Karakter";
            this.Text = "Karakter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NaamTextBox;
        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.TextBox KrachtTextBox;
        private System.Windows.Forms.TextBox SterkteTextBox;
    }
}