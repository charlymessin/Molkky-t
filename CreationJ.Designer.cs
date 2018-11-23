namespace Molkky_t
{
    partial class CreationJ
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
            this.lblPseudo = new MetroFramework.Controls.MetroLabel();
            this.txtPseudo = new MetroFramework.Controls.MetroTextBox();
            this.btnCreateJ = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(381, 133);
            this.lblPseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(62, 20);
            this.lblPseudo.TabIndex = 0;
            this.lblPseudo.Text = "Pseudo :";
            // 
            // txtPseudo
            // 
            // 
            // 
            // 
            this.txtPseudo.CustomButton.Image = null;
            this.txtPseudo.CustomButton.Location = new System.Drawing.Point(177, 2);
            this.txtPseudo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPseudo.CustomButton.Name = "";
            this.txtPseudo.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPseudo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPseudo.CustomButton.TabIndex = 1;
            this.txtPseudo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPseudo.CustomButton.UseSelectable = true;
            this.txtPseudo.CustomButton.Visible = false;
            this.txtPseudo.Lines = new string[0];
            this.txtPseudo.Location = new System.Drawing.Point(381, 214);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPseudo.MaxLength = 32767;
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.PasswordChar = '\0';
            this.txtPseudo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPseudo.SelectedText = "";
            this.txtPseudo.SelectionLength = 0;
            this.txtPseudo.SelectionStart = 0;
            this.txtPseudo.ShortcutsEnabled = true;
            this.txtPseudo.Size = new System.Drawing.Size(159, 28);
            this.txtPseudo.TabIndex = 1;
            this.txtPseudo.UseSelectable = true;
            this.txtPseudo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPseudo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCreateJ
            // 
            this.btnCreateJ.Location = new System.Drawing.Point(381, 327);
            this.btnCreateJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateJ.Name = "btnCreateJ";
            this.btnCreateJ.Size = new System.Drawing.Size(100, 28);
            this.btnCreateJ.TabIndex = 2;
            this.btnCreateJ.Text = "Creer joueur";
            this.btnCreateJ.UseSelectable = true;
            this.btnCreateJ.Click += new System.EventHandler(this.btnCreateJ_Click);
            // 
            // CreationJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.btnCreateJ);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.lblPseudo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreationJ";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPseudo;
        private MetroFramework.Controls.MetroTextBox txtPseudo;
        private MetroFramework.Controls.MetroButton btnCreateJ;
    }
}