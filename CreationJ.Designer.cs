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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationJ));
            this.lblPseudo = new MetroFramework.Controls.MetroLabel();
            this.txtPseudo = new MetroFramework.Controls.MetroTextBox();
            this.btnCreateJ = new MetroFramework.Controls.MetroButton();
            this.panelRegles = new MetroFramework.Controls.MetroPanel();
            this.panelRegles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPseudo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPseudo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPseudo.Location = new System.Drawing.Point(288, 107);
            this.lblPseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(88, 25);
            this.lblPseudo.TabIndex = 0;
            this.lblPseudo.Text = "Pseudo :";
            this.lblPseudo.UseCustomBackColor = true;
            this.lblPseudo.UseCustomForeColor = true;
            this.lblPseudo.UseStyleColors = true;
            // 
            // txtPseudo
            // 
            // 
            // 
            // 
            this.txtPseudo.CustomButton.Image = null;
            this.txtPseudo.CustomButton.Location = new System.Drawing.Point(133, 2);
            this.txtPseudo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPseudo.CustomButton.Name = "";
            this.txtPseudo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPseudo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPseudo.CustomButton.TabIndex = 1;
            this.txtPseudo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPseudo.CustomButton.UseSelectable = true;
            this.txtPseudo.CustomButton.Visible = false;
            this.txtPseudo.Lines = new string[0];
            this.txtPseudo.Location = new System.Drawing.Point(447, 107);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnCreateJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateJ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCreateJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateJ.Location = new System.Drawing.Point(344, 241);
            this.btnCreateJ.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateJ.Name = "btnCreateJ";
            this.btnCreateJ.Size = new System.Drawing.Size(193, 60);
            this.btnCreateJ.TabIndex = 2;
            this.btnCreateJ.Text = "Créer joueur";
            this.btnCreateJ.UseCustomBackColor = true;
            this.btnCreateJ.UseCustomForeColor = true;
            this.btnCreateJ.UseSelectable = true;
            this.btnCreateJ.UseStyleColors = true;
            this.btnCreateJ.Click += new System.EventHandler(this.btnCreateJ_Click);
            // 
            // panelRegles
            // 
            this.panelRegles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelRegles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRegles.BackgroundImage")));
            this.panelRegles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegles.Controls.Add(this.lblPseudo);
            this.panelRegles.Controls.Add(this.txtPseudo);
            this.panelRegles.Controls.Add(this.btnCreateJ);
            this.panelRegles.HorizontalScrollbarBarColor = true;
            this.panelRegles.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRegles.HorizontalScrollbarSize = 12;
            this.panelRegles.Location = new System.Drawing.Point(31, 156);
            this.panelRegles.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegles.Name = "panelRegles";
            this.panelRegles.Size = new System.Drawing.Size(950, 400);
            this.panelRegles.TabIndex = 3;
            this.panelRegles.VerticalScrollbarBarColor = true;
            this.panelRegles.VerticalScrollbarHighlightOnWheel = false;
            this.panelRegles.VerticalScrollbarSize = 12;
            // 
            // CreationJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.panelRegles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreationJ";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.panelRegles.ResumeLayout(false);
            this.panelRegles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPseudo;
        private MetroFramework.Controls.MetroTextBox txtPseudo;
        private MetroFramework.Controls.MetroButton btnCreateJ;
        private MetroFramework.Controls.MetroPanel panelRegles;
    }
}