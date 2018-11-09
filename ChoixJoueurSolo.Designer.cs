namespace Molkky_t
{
    partial class ChoixJoueurSolo
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
            this.listJoueurSolo = new MetroFramework.Controls.MetroComboBox();
            this.btnAjouterJSolo = new MetroFramework.Controls.MetroButton();
            this.listAjoutJoueur = new System.Windows.Forms.ListBox();
            this.btnRetirJsolo = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listJoueurSolo
            // 
            this.listJoueurSolo.FormattingEnabled = true;
            this.listJoueurSolo.ItemHeight = 23;
            this.listJoueurSolo.Location = new System.Drawing.Point(83, 99);
            this.listJoueurSolo.Name = "listJoueurSolo";
            this.listJoueurSolo.Size = new System.Drawing.Size(164, 29);
            this.listJoueurSolo.TabIndex = 0;
            this.listJoueurSolo.UseSelectable = true;
            // 
            // btnAjouterJSolo
            // 
            this.btnAjouterJSolo.Location = new System.Drawing.Point(288, 160);
            this.btnAjouterJSolo.Name = "btnAjouterJSolo";
            this.btnAjouterJSolo.Size = new System.Drawing.Size(101, 36);
            this.btnAjouterJSolo.TabIndex = 1;
            this.btnAjouterJSolo.Text = "Ajouter";
            this.btnAjouterJSolo.UseSelectable = true;
            this.btnAjouterJSolo.Click += new System.EventHandler(this.btnAjouterJSolo_Click);
            // 
            // listAjoutJoueur
            // 
            this.listAjoutJoueur.FormattingEnabled = true;
            this.listAjoutJoueur.Location = new System.Drawing.Point(434, 99);
            this.listAjoutJoueur.Name = "listAjoutJoueur";
            this.listAjoutJoueur.Size = new System.Drawing.Size(175, 173);
            this.listAjoutJoueur.TabIndex = 2;
            // 
            // btnRetirJsolo
            // 
            this.btnRetirJsolo.Location = new System.Drawing.Point(463, 278);
            this.btnRetirJsolo.Name = "btnRetirJsolo";
            this.btnRetirJsolo.Size = new System.Drawing.Size(115, 44);
            this.btnRetirJsolo.TabIndex = 3;
            this.btnRetirJsolo.Text = "Retirer joueur";
            this.btnRetirJsolo.UseSelectable = true;
            this.btnRetirJsolo.Click += new System.EventHandler(this.btnRetirJsolo_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(288, 371);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 39);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Commencer";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ChoixJoueurSolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRetirJsolo);
            this.Controls.Add(this.listAjoutJoueur);
            this.Controls.Add(this.btnAjouterJSolo);
            this.Controls.Add(this.listJoueurSolo);
            this.Name = "ChoixJoueurSolo";
            this.Text = "ChoixJoueur";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox listJoueurSolo;
        private MetroFramework.Controls.MetroButton btnAjouterJSolo;
        private System.Windows.Forms.ListBox listAjoutJoueur;
        private MetroFramework.Controls.MetroButton btnRetirJsolo;
        private MetroFramework.Controls.MetroButton btnStart;
    }
}