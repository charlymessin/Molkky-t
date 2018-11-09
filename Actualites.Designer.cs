namespace Molkky_t
{
    partial class Actualites
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
            this.panelActus = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Synchro = new MetroFramework.Controls.MetroButton();
            this.panelActus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActus
            // 
            this.panelActus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActus.Controls.Add(this.label1);
            this.panelActus.Controls.Add(this.btn_Synchro);
            this.panelActus.HorizontalScrollbarBarColor = true;
            this.panelActus.HorizontalScrollbarHighlightOnWheel = false;
            this.panelActus.HorizontalScrollbarSize = 10;
            this.panelActus.Location = new System.Drawing.Point(23, 122);
            this.panelActus.Name = "panelActus";
            this.panelActus.Size = new System.Drawing.Size(754, 336);
            this.panelActus.TabIndex = 0;
            this.panelActus.VerticalScrollbarBarColor = true;
            this.panelActus.VerticalScrollbarHighlightOnWheel = false;
            this.panelActus.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btn_Synchro
            // 
            this.btn_Synchro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Synchro.Location = new System.Drawing.Point(306, 280);
            this.btn_Synchro.Name = "btn_Synchro";
            this.btn_Synchro.Size = new System.Drawing.Size(134, 40);
            this.btn_Synchro.TabIndex = 2;
            this.btn_Synchro.Text = "metroButton1";
            this.btn_Synchro.UseSelectable = true;
            // 
            // Actualites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panelActus);
            this.Name = "Actualites";
            this.Text = "Actualites";
            this.panelActus.ResumeLayout(false);
            this.panelActus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelActus;
        private MetroFramework.Controls.MetroButton btn_Synchro;
        private System.Windows.Forms.Label label1;
    }
}