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
            this.listeJoueur = new MetroFramework.Controls.MetroComboBox();
            this.listeJoueur2 = new MetroFramework.Controls.MetroListView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Creat_j = new MetroFramework.Controls.MetroButton();
            this.btnCreerPartie = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listeJoueur
            // 
            this.listeJoueur.FormattingEnabled = true;
            this.listeJoueur.ItemHeight = 23;
            this.listeJoueur.Location = new System.Drawing.Point(99, 119);
            this.listeJoueur.Name = "listeJoueur";
            this.listeJoueur.Size = new System.Drawing.Size(121, 29);
            this.listeJoueur.TabIndex = 0;
            this.listeJoueur.UseSelectable = true;
            this.listeJoueur.SelectedIndexChanged += new System.EventHandler(this.listeJoueur_SelectedIndexChanged);
            // 
            // listeJoueur2
            // 
            this.listeJoueur2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listeJoueur2.FullRowSelect = true;
            this.listeJoueur2.Location = new System.Drawing.Point(497, 119);
            this.listeJoueur2.Name = "listeJoueur2";
            this.listeJoueur2.OwnerDraw = true;
            this.listeJoueur2.Size = new System.Drawing.Size(135, 123);
            this.listeJoueur2.TabIndex = 1;
            this.listeJoueur2.UseCompatibleStateImageBehavior = false;
            this.listeJoueur2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.UseSelectable = true;
            // 
            // Creat_j
            // 
            this.Creat_j.Location = new System.Drawing.Point(522, 287);
            this.Creat_j.Name = "Creat_j";
            this.Creat_j.Size = new System.Drawing.Size(110, 23);
            this.Creat_j.TabIndex = 6;
            this.Creat_j.Text = "Creation joueur";
            this.Creat_j.UseSelectable = true;
            this.Creat_j.Click += new System.EventHandler(this.Creat_j_Click);
            // 
            // btnCreerPartie
            // 
            this.btnCreerPartie.Location = new System.Drawing.Point(307, 374);
            this.btnCreerPartie.Name = "btnCreerPartie";
            this.btnCreerPartie.Size = new System.Drawing.Size(125, 41);
            this.btnCreerPartie.TabIndex = 8;
            this.btnCreerPartie.Text = "Créer une partie";
            this.btnCreerPartie.UseSelectable = true;
            this.btnCreerPartie.Click += new System.EventHandler(this.btnCreerPartie_Click);
            // 
            // Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnCreerPartie);
            this.Controls.Add(this.Creat_j);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listeJoueur2);
            this.Controls.Add(this.listeJoueur);
            this.Name = "Joueurs";
            this.Text = "Joueurs";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox listeJoueur;
        private MetroFramework.Controls.MetroListView listeJoueur2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton Creat_j;
        private MetroFramework.Controls.MetroButton btnCreerPartie;
    }
}