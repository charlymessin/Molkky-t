namespace Molkky_t
{
    partial class Regle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regle));
            this.panelRegles = new MetroFramework.Controls.MetroPanel();
            this.labelRegles = new MetroFramework.Drawing.Html.HtmlLabel();
            this.panelRegles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegles
            // 
            this.panelRegles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelRegles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRegles.BackgroundImage")));
            this.panelRegles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegles.Controls.Add(this.labelRegles);
            this.panelRegles.HorizontalScrollbarBarColor = true;
            this.panelRegles.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRegles.HorizontalScrollbarSize = 10;
            this.panelRegles.Location = new System.Drawing.Point(16, 85);
            this.panelRegles.Name = "panelRegles";
            this.panelRegles.Size = new System.Drawing.Size(766, 365);
            this.panelRegles.TabIndex = 2;
            this.panelRegles.VerticalScrollbarBarColor = true;
            this.panelRegles.VerticalScrollbarHighlightOnWheel = false;
            this.panelRegles.VerticalScrollbarSize = 9;
            // 
            // labelRegles
            // 
            this.labelRegles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegles.AutoScroll = true;
            this.labelRegles.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.labelRegles.AutoSize = false;
            this.labelRegles.BackColor = System.Drawing.SystemColors.Window;
            this.labelRegles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelRegles.BackgroundImage")));
            this.labelRegles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.labelRegles.Location = new System.Drawing.Point(33, 36);
            this.labelRegles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelRegles.Name = "labelRegles";
            this.labelRegles.Size = new System.Drawing.Size(695, 297);
            this.labelRegles.TabIndex = 2;
            // 
            // Regle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panelRegles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 492);
            this.Name = "Regle";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.panelRegles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelRegles;
        private MetroFramework.Drawing.Html.HtmlLabel labelRegles;
    }
}