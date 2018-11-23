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
            this.panelRegles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelRegles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRegles.BackgroundImage")));
            this.panelRegles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegles.Controls.Add(this.labelRegles);
            this.panelRegles.HorizontalScrollbarBarColor = true;
            this.panelRegles.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRegles.HorizontalScrollbarSize = 12;
            this.panelRegles.Location = new System.Drawing.Point(26, 155);
            this.panelRegles.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegles.Name = "panelRegles";
            this.panelRegles.Size = new System.Drawing.Size(950, 400);
            this.panelRegles.TabIndex = 2;
            this.panelRegles.VerticalScrollbarBarColor = true;
            this.panelRegles.VerticalScrollbarHighlightOnWheel = false;
            this.panelRegles.VerticalScrollbarSize = 12;
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
            this.labelRegles.Location = new System.Drawing.Point(44, 44);
            this.labelRegles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelRegles.Name = "labelRegles";
            this.labelRegles.Size = new System.Drawing.Size(856, 317);
            this.labelRegles.TabIndex = 2;
            // 
            // Regle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 615);
            this.Controls.Add(this.panelRegles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 615);
            this.Name = "Regle";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.panelRegles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelRegles;
        private MetroFramework.Drawing.Html.HtmlLabel labelRegles;
    }
}