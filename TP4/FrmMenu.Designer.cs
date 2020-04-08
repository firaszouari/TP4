namespace TP4
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.TS_Menu = new System.Windows.Forms.ToolStrip();
            this.TS_Btn_Cl = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Pr = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Cd = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Q = new System.Windows.Forms.ToolStripButton();
            this.TS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS_Menu
            // 
            this.TS_Menu.AutoSize = false;
            this.TS_Menu.BackColor = System.Drawing.Color.White;
            this.TS_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Btn_Cl,
            this.TS_Btn_Pr,
            this.TS_Btn_Cd,
            this.TS_Btn_Q});
            this.TS_Menu.Location = new System.Drawing.Point(20, 60);
            this.TS_Menu.Name = "TS_Menu";
            this.TS_Menu.Size = new System.Drawing.Size(830, 89);
            this.TS_Menu.TabIndex = 0;
            this.TS_Menu.Text = "toolStrip1";
            // 
            // TS_Btn_Cl
            // 
            this.TS_Btn_Cl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TS_Btn_Cl.ForeColor = System.Drawing.Color.ForestGreen;
            this.TS_Btn_Cl.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Cl.Image")));
            this.TS_Btn_Cl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TS_Btn_Cl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Cl.Name = "TS_Btn_Cl";
            this.TS_Btn_Cl.Size = new System.Drawing.Size(80, 86);
            this.TS_Btn_Cl.Text = "Clients";
            this.TS_Btn_Cl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TS_Btn_Pr
            // 
            this.TS_Btn_Pr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TS_Btn_Pr.ForeColor = System.Drawing.Color.Red;
            this.TS_Btn_Pr.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Pr.Image")));
            this.TS_Btn_Pr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TS_Btn_Pr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Pr.Name = "TS_Btn_Pr";
            this.TS_Btn_Pr.Size = new System.Drawing.Size(95, 86);
            this.TS_Btn_Pr.Text = "Produits";
            this.TS_Btn_Pr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TS_Btn_Cd
            // 
            this.TS_Btn_Cd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TS_Btn_Cd.ForeColor = System.Drawing.Color.SteelBlue;
            this.TS_Btn_Cd.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Cd.Image")));
            this.TS_Btn_Cd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TS_Btn_Cd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Cd.Name = "TS_Btn_Cd";
            this.TS_Btn_Cd.Size = new System.Drawing.Size(131, 86);
            this.TS_Btn_Cd.Text = "Commandes";
            this.TS_Btn_Cd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TS_Btn_Q
            // 
            this.TS_Btn_Q.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TS_Btn_Q.ForeColor = System.Drawing.Color.Orange;
            this.TS_Btn_Q.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Q.Image")));
            this.TS_Btn_Q.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TS_Btn_Q.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Q.Name = "TS_Btn_Q";
            this.TS_Btn_Q.Size = new System.Drawing.Size(84, 86);
            this.TS_Btn_Q.Text = "Quitter";
            this.TS_Btn_Q.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 572);
            this.Controls.Add(this.TS_Menu);
            this.IsMdiContainer = true;
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.TS_Menu.ResumeLayout(false);
            this.TS_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Menu;
        private System.Windows.Forms.ToolStripButton TS_Btn_Cl;
        private System.Windows.Forms.ToolStripButton TS_Btn_Pr;
        private System.Windows.Forms.ToolStripButton TS_Btn_Cd;
        private System.Windows.Forms.ToolStripButton TS_Btn_Q;
    }
}