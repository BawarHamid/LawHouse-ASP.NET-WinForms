
namespace WinFormsAppLawHouse.GUI.Personale.Rapport
{
    partial class KlientRapportForms
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
            this.RapportRTB = new System.Windows.Forms.RichTextBox();
            this.FilNavnTxtB = new System.Windows.Forms.TextBox();
            this.FilNavnLbl = new System.Windows.Forms.Label();
            this.UdskrivBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RapportRTB
            // 
            this.RapportRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.RapportRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RapportRTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RapportRTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RapportRTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RapportRTB.Location = new System.Drawing.Point(75, 131);
            this.RapportRTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RapportRTB.Name = "RapportRTB";
            this.RapportRTB.Size = new System.Drawing.Size(797, 551);
            this.RapportRTB.TabIndex = 1;
            this.RapportRTB.Text = "";
            // 
            // FilNavnTxtB
            // 
            this.FilNavnTxtB.Location = new System.Drawing.Point(917, 314);
            this.FilNavnTxtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilNavnTxtB.Name = "FilNavnTxtB";
            this.FilNavnTxtB.Size = new System.Drawing.Size(224, 23);
            this.FilNavnTxtB.TabIndex = 5;
            // 
            // FilNavnLbl
            // 
            this.FilNavnLbl.AutoSize = true;
            this.FilNavnLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilNavnLbl.Location = new System.Drawing.Point(917, 279);
            this.FilNavnLbl.Name = "FilNavnLbl";
            this.FilNavnLbl.Size = new System.Drawing.Size(224, 21);
            this.FilNavnLbl.TabIndex = 4;
            this.FilNavnLbl.Text = "Angiv et filnavn til rapporten!";
            // 
            // UdskrivBtn
            // 
            this.UdskrivBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.UdskrivBtn.FlatAppearance.BorderSize = 0;
            this.UdskrivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UdskrivBtn.ForeColor = System.Drawing.Color.White;
            this.UdskrivBtn.Location = new System.Drawing.Point(917, 373);
            this.UdskrivBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UdskrivBtn.Name = "UdskrivBtn";
            this.UdskrivBtn.Size = new System.Drawing.Size(224, 33);
            this.UdskrivBtn.TabIndex = 6;
            this.UdskrivBtn.Text = "Udskriv Rapport";
            this.UdskrivBtn.UseVisualStyleBackColor = false;
            this.UdskrivBtn.Click += new System.EventHandler(this.UdskrivBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpMeToolStripMenuItem
            // 
            this.helpMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpFileToolStripMenuItem});
            this.helpMeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpMeToolStripMenuItem.Name = "helpMeToolStripMenuItem";
            this.helpMeToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.helpMeToolStripMenuItem.Text = "Hjælp";
            // 
            // openHelpFileToolStripMenuItem
            // 
            this.openHelpFileToolStripMenuItem.Name = "openHelpFileToolStripMenuItem";
            this.openHelpFileToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.openHelpFileToolStripMenuItem.Text = "Open HelpFile...";
            this.openHelpFileToolStripMenuItem.Click += new System.EventHandler(this.openHelpFileToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Skriv Klientrapporten i det nedenstående felt, tak!";
            // 
            // KlientRapportForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UdskrivBtn);
            this.Controls.Add(this.FilNavnTxtB);
            this.Controls.Add(this.FilNavnLbl);
            this.Controls.Add(this.RapportRTB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KlientRapportForms";
            this.Text = "Klient rapport";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RapportRTB;
        private System.Windows.Forms.TextBox FilNavnTxtB;
        private System.Windows.Forms.Label FilNavnLbl;
        private System.Windows.Forms.Button UdskrivBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpFileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}