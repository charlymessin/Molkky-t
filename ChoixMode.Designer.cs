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
            this.btnModeSolo = new MetroFramework.Controls.MetroButton();
            this.btnModeEquipe = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnModeSolo
            // 
            this.btnModeSolo.Location = new System.Drawing.Point(138, 185);
            this.btnModeSolo.Name = "btnModeSolo";
            this.btnModeSolo.Size = new System.Drawing.Size(94, 34);
            this.btnModeSolo.TabIndex = 0;
            this.btnModeSolo.Text = "Solo";
            this.btnModeSolo.UseSelectable = true;
            this.btnModeSolo.Click += new System.EventHandler(this.btnModeSolo_Click);
            // 
            // btnModeEquipe
            // 
            this.btnModeEquipe.Location = new System.Drawing.Point(483, 185);
            this.btnModeEquipe.Name = "btnModeEquipe";
            this.btnModeEquipe.Size = new System.Drawing.Size(93, 34);
            this.btnModeEquipe.TabIndex = 1;
            this.btnModeEquipe.Text = "Equipe";
            this.btnModeEquipe.UseSelectable = true;
            // 
            // ChoixMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModeEquipe);
            this.Controls.Add(this.btnModeSolo);
            this.Name = "ChoixMode";
            this.Text = "ChoixMode";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnModeSolo;
        private MetroFramework.Controls.MetroButton btnModeEquipe;
    }
}