namespace Molkky_t
{
    partial class Joueurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joueurs));
            this.listeJoueur = new MetroFramework.Controls.MetroComboBox();
            this.Creat_j = new MetroFramework.Controls.MetroButton();
            this.btnCreerPartie = new MetroFramework.Controls.MetroButton();
            this.panelChoixMode = new MetroFramework.Controls.MetroPanel();
            this.panelChoixMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // listeJoueur
            // 
            this.listeJoueur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listeJoueur.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.listeJoueur.ForeColor = System.Drawing.Color.Gray;
            this.listeJoueur.FormattingEnabled = true;
            this.listeJoueur.ItemHeight = 29;
            this.listeJoueur.Location = new System.Drawing.Point(29, 26);
            this.listeJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.listeJoueur.Name = "listeJoueur";
            this.listeJoueur.Size = new System.Drawing.Size(184, 35);
            this.listeJoueur.TabIndex = 0;
            this.listeJoueur.UseCustomBackColor = true;
            this.listeJoueur.UseCustomForeColor = true;
            this.listeJoueur.UseSelectable = true;
            this.listeJoueur.UseStyleColors = true;
            this.listeJoueur.SelectedIndexChanged += new System.EventHandler(this.listeJoueur_SelectedIndexChanged);
            // 
            // Creat_j
            // 
            this.Creat_j.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Creat_j.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Creat_j.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Creat_j.Location = new System.Drawing.Point(304, 168);
            this.Creat_j.Margin = new System.Windows.Forms.Padding(4);
            this.Creat_j.Name = "Creat_j";
            this.Creat_j.Size = new System.Drawing.Size(235, 70);
            this.Creat_j.TabIndex = 6;
            this.Creat_j.Text = "Creation joueur";
            this.Creat_j.UseCustomBackColor = true;
            this.Creat_j.UseCustomForeColor = true;
            this.Creat_j.UseSelectable = true;
            this.Creat_j.UseStyleColors = true;
            this.Creat_j.Click += new System.EventHandler(this.Creat_j_Click);
            // 
            // btnCreerPartie
            // 
            this.btnCreerPartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreerPartie.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCreerPartie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreerPartie.Location = new System.Drawing.Point(636, 168);
            this.btnCreerPartie.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreerPartie.Name = "btnCreerPartie";
            this.btnCreerPartie.Size = new System.Drawing.Size(235, 70);
            this.btnCreerPartie.TabIndex = 8;
            this.btnCreerPartie.Text = "Créer une partie";
            this.btnCreerPartie.UseCustomBackColor = true;
            this.btnCreerPartie.UseCustomForeColor = true;
            this.btnCreerPartie.UseSelectable = true;
            this.btnCreerPartie.UseStyleColors = true;
            this.btnCreerPartie.Click += new System.EventHandler(this.btnCreerPartie_Click);
            // 
            // panelChoixMode
            // 
            this.panelChoixMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChoixMode.BackgroundImage")));
            this.panelChoixMode.Controls.Add(this.Creat_j);
            this.panelChoixMode.Controls.Add(this.listeJoueur);
            this.panelChoixMode.Controls.Add(this.btnCreerPartie);
            this.panelChoixMode.HorizontalScrollbarBarColor = true;
            this.panelChoixMode.HorizontalScrollbarHighlightOnWheel = false;
            this.panelChoixMode.HorizontalScrollbarSize = 10;
            this.panelChoixMode.Location = new System.Drawing.Point(30, 156);
            this.panelChoixMode.Name = "panelChoixMode";
            this.panelChoixMode.Size = new System.Drawing.Size(950, 400);
            this.panelChoixMode.TabIndex = 9;
            this.panelChoixMode.VerticalScrollbarBarColor = true;
            this.panelChoixMode.VerticalScrollbarHighlightOnWheel = false;
            this.panelChoixMode.VerticalScrollbarSize = 10;
            // 
            // Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.panelChoixMode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 615);
            this.Name = "Joueurs";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.panelChoixMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox listeJoueur;
        private MetroFramework.Controls.MetroButton Creat_j;
        private MetroFramework.Controls.MetroButton btnCreerPartie;
        private MetroFramework.Controls.MetroPanel panelChoixMode;
    }
}
