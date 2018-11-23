namespace Molkky_t
{
    partial class ChoixMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixMode));
            this.btnModeSolo = new MetroFramework.Controls.MetroButton();
            this.btnModeEquipe = new MetroFramework.Controls.MetroButton();
            this.panelChoixMode = new MetroFramework.Controls.MetroPanel();
            this.panelChoixMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModeSolo
            // 
            this.btnModeSolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnModeSolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModeSolo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnModeSolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModeSolo.Location = new System.Drawing.Point(151, 131);
            this.btnModeSolo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeSolo.Name = "btnModeSolo";
            this.btnModeSolo.Size = new System.Drawing.Size(230, 142);
            this.btnModeSolo.TabIndex = 0;
            this.btnModeSolo.Text = "Solo";
            this.btnModeSolo.UseCustomBackColor = true;
            this.btnModeSolo.UseCustomForeColor = true;
            this.btnModeSolo.UseSelectable = true;
            this.btnModeSolo.UseStyleColors = true;
            this.btnModeSolo.Click += new System.EventHandler(this.btnModeSolo_Click);
            // 
            // btnModeEquipe
            // 
            this.btnModeEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnModeEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModeEquipe.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnModeEquipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModeEquipe.Location = new System.Drawing.Point(576, 131);
            this.btnModeEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeEquipe.Name = "btnModeEquipe";
            this.btnModeEquipe.Size = new System.Drawing.Size(230, 142);
            this.btnModeEquipe.TabIndex = 1;
            this.btnModeEquipe.Text = "Equipe";
            this.btnModeEquipe.UseCustomBackColor = true;
            this.btnModeEquipe.UseCustomForeColor = true;
            this.btnModeEquipe.UseSelectable = true;
            this.btnModeEquipe.UseStyleColors = true;
            // 
            // panelChoixMode
            // 
            this.panelChoixMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChoixMode.BackgroundImage")));
            this.panelChoixMode.Controls.Add(this.btnModeEquipe);
            this.panelChoixMode.Controls.Add(this.btnModeSolo);
            this.panelChoixMode.HorizontalScrollbarBarColor = true;
            this.panelChoixMode.HorizontalScrollbarHighlightOnWheel = false;
            this.panelChoixMode.HorizontalScrollbarSize = 10;
            this.panelChoixMode.Location = new System.Drawing.Point(30, 156);
            this.panelChoixMode.Name = "panelChoixMode";
            this.panelChoixMode.Size = new System.Drawing.Size(950, 400);
            this.panelChoixMode.TabIndex = 2;
            this.panelChoixMode.VerticalScrollbarBarColor = true;
            this.panelChoixMode.VerticalScrollbarHighlightOnWheel = false;
            this.panelChoixMode.VerticalScrollbarSize = 10;
            // 
            // ChoixMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.panelChoixMode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChoixMode";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.panelChoixMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnModeSolo;
        private MetroFramework.Controls.MetroButton btnModeEquipe;
        private MetroFramework.Controls.MetroPanel panelChoixMode;
    }
}