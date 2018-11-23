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
            this.listeJoueur2 = new MetroFramework.Controls.MetroListView();
            this.Creat_j = new MetroFramework.Controls.MetroButton();
            this.btnSupprimer = new MetroFramework.Controls.MetroButton();
            this.panelChoixMode = new MetroFramework.Controls.MetroPanel();
            this.panelChoixMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // listeJoueur
            // 
            this.listeJoueur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listeJoueur.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.listeJoueur.ForeColor = System.Drawing.Color.Gray;
            this.listeJoueur.FormattingEnabled = true;
            this.listeJoueur.ItemHeight = 29;
            this.listeJoueur.Location = new System.Drawing.Point(88, 55);
            this.listeJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.listeJoueur.Name = "listeJoueur";
            this.listeJoueur.Size = new System.Drawing.Size(160, 35);
            this.listeJoueur.TabIndex = 0;
            this.listeJoueur.UseCustomBackColor = true;
            this.listeJoueur.UseCustomForeColor = true;
            this.listeJoueur.UseSelectable = true;
            this.listeJoueur.UseStyleColors = true;
            this.listeJoueur.SelectedIndexChanged += new System.EventHandler(this.listeJoueur_SelectedIndexChanged);
            // 
            // listeJoueur2
            // 
            this.listeJoueur2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listeJoueur2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listeJoueur2.ForeColor = System.Drawing.Color.Gray;
            this.listeJoueur2.FullRowSelect = true;
            this.listeJoueur2.Location = new System.Drawing.Point(633, 22);
            this.listeJoueur2.Margin = new System.Windows.Forms.Padding(4);
            this.listeJoueur2.Name = "listeJoueur2";
            this.listeJoueur2.OwnerDraw = true;
            this.listeJoueur2.Size = new System.Drawing.Size(179, 150);
            this.listeJoueur2.TabIndex = 1;
            this.listeJoueur2.UseCompatibleStateImageBehavior = false;
            this.listeJoueur2.UseCustomBackColor = true;
            this.listeJoueur2.UseCustomForeColor = true;
            this.listeJoueur2.UseSelectable = true;
            this.listeJoueur2.UseStyleColors = true;
            // 
            // Creat_j
            // 
            this.Creat_j.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Creat_j.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Creat_j.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Creat_j.Location = new System.Drawing.Point(647, 319);
            this.Creat_j.Margin = new System.Windows.Forms.Padding(4);
            this.Creat_j.Name = "Creat_j";
            this.Creat_j.Size = new System.Drawing.Size(147, 28);
            this.Creat_j.TabIndex = 6;
            this.Creat_j.Text = "Creation joueur";
            this.Creat_j.UseCustomBackColor = true;
            this.Creat_j.UseCustomForeColor = true;
            this.Creat_j.UseSelectable = true;
            this.Creat_j.UseStyleColors = true;
            this.Creat_j.Click += new System.EventHandler(this.Creat_j_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSupprimer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSupprimer.Location = new System.Drawing.Point(88, 310);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(123, 37);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseCustomBackColor = true;
            this.btnSupprimer.UseCustomForeColor = true;
            this.btnSupprimer.UseSelectable = true;
            this.btnSupprimer.UseStyleColors = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // panelChoixMode
            // 
            this.panelChoixMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChoixMode.BackgroundImage")));
            this.panelChoixMode.Controls.Add(this.listeJoueur2);
            this.panelChoixMode.Controls.Add(this.listeJoueur);
            this.panelChoixMode.Controls.Add(this.btnSupprimer);
            this.panelChoixMode.Controls.Add(this.Creat_j);
            this.panelChoixMode.HorizontalScrollbarBarColor = true;
            this.panelChoixMode.HorizontalScrollbarHighlightOnWheel = false;
            this.panelChoixMode.HorizontalScrollbarSize = 10;
            this.panelChoixMode.Location = new System.Drawing.Point(30, 158);
            this.panelChoixMode.Name = "panelChoixMode";
            this.panelChoixMode.Size = new System.Drawing.Size(950, 400);
            this.panelChoixMode.TabIndex = 8;
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
            this.Name = "Joueurs";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.panelChoixMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox listeJoueur;
        private MetroFramework.Controls.MetroListView listeJoueur2;
        private MetroFramework.Controls.MetroButton Creat_j;
        private MetroFramework.Controls.MetroButton btnSupprimer;
        private MetroFramework.Controls.MetroPanel panelChoixMode;
    }
}