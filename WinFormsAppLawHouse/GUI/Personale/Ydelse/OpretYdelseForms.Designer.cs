
namespace WinFormsAppLawHouse.GUI.Personale.Ydelse
{
    partial class OpretYdelseForms
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
            this.label2 = new System.Windows.Forms.Label();
            this.YdelserView = new System.Windows.Forms.DataGridView();
            this.OpdatereBtn = new System.Windows.Forms.Button();
            this.SeltBtn = new System.Windows.Forms.Button();
            this.OpretBtn = new System.Windows.Forms.Button();
            this.YdelseIDTxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypePrisLbl = new System.Windows.Forms.Label();
            this.TypePrisTxtB = new System.Windows.Forms.TextBox();
            this.YdelseNavnLbl = new System.Windows.Forms.Label();
            this.YdelseNavnTxtB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.YdelserView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(397, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Alle ydelser";
            // 
            // YdelserView
            // 
            this.YdelserView.AllowUserToAddRows = false;
            this.YdelserView.AllowUserToDeleteRows = false;
            this.YdelserView.AllowUserToOrderColumns = true;
            this.YdelserView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YdelserView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.YdelserView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YdelserView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.YdelserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YdelserView.EnableHeadersVisualStyles = false;
            this.YdelserView.Location = new System.Drawing.Point(69, 161);
            this.YdelserView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YdelserView.Name = "YdelserView";
            this.YdelserView.ReadOnly = true;
            this.YdelserView.RowHeadersWidth = 51;
            this.YdelserView.RowTemplate.Height = 29;
            this.YdelserView.Size = new System.Drawing.Size(777, 494);
            this.YdelserView.TabIndex = 37;
            this.YdelserView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YdelserView_CellClick);
            // 
            // OpdatereBtn
            // 
            this.OpdatereBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.OpdatereBtn.FlatAppearance.BorderSize = 0;
            this.OpdatereBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpdatereBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpdatereBtn.ForeColor = System.Drawing.Color.White;
            this.OpdatereBtn.Location = new System.Drawing.Point(901, 561);
            this.OpdatereBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpdatereBtn.Name = "OpdatereBtn";
            this.OpdatereBtn.Size = new System.Drawing.Size(199, 33);
            this.OpdatereBtn.TabIndex = 36;
            this.OpdatereBtn.Text = "Opdatere";
            this.OpdatereBtn.UseVisualStyleBackColor = false;
            this.OpdatereBtn.Click += new System.EventHandler(this.OpdatereBtn_Click);
            // 
            // SeltBtn
            // 
            this.SeltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.SeltBtn.FlatAppearance.BorderSize = 0;
            this.SeltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeltBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeltBtn.ForeColor = System.Drawing.Color.White;
            this.SeltBtn.Location = new System.Drawing.Point(901, 496);
            this.SeltBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeltBtn.Name = "SeltBtn";
            this.SeltBtn.Size = new System.Drawing.Size(199, 33);
            this.SeltBtn.TabIndex = 35;
            this.SeltBtn.Text = "Slet";
            this.SeltBtn.UseVisualStyleBackColor = false;
            this.SeltBtn.Click += new System.EventHandler(this.SeltBtn_Click);
            // 
            // OpretBtn
            // 
            this.OpretBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.OpretBtn.FlatAppearance.BorderSize = 0;
            this.OpretBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpretBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpretBtn.ForeColor = System.Drawing.Color.White;
            this.OpretBtn.Location = new System.Drawing.Point(901, 435);
            this.OpretBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpretBtn.Name = "OpretBtn";
            this.OpretBtn.Size = new System.Drawing.Size(199, 33);
            this.OpretBtn.TabIndex = 34;
            this.OpretBtn.Text = "Opret";
            this.OpretBtn.UseVisualStyleBackColor = false;
            this.OpretBtn.Click += new System.EventHandler(this.OpretBtn_Click);
            // 
            // YdelseIDTxtB
            // 
            this.YdelseIDTxtB.ForeColor = System.Drawing.Color.White;
            this.YdelseIDTxtB.Location = new System.Drawing.Point(12, 336);
            this.YdelseIDTxtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YdelseIDTxtB.Name = "YdelseIDTxtB";
            this.YdelseIDTxtB.Size = new System.Drawing.Size(10, 23);
            this.YdelseIDTxtB.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 31;
            // 
            // TypePrisLbl
            // 
            this.TypePrisLbl.AutoSize = true;
            this.TypePrisLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypePrisLbl.Location = new System.Drawing.Point(901, 348);
            this.TypePrisLbl.Name = "TypePrisLbl";
            this.TypePrisLbl.Size = new System.Drawing.Size(72, 21);
            this.TypePrisLbl.TabIndex = 30;
            this.TypePrisLbl.Text = "Type pris";
            // 
            // TypePrisTxtB
            // 
            this.TypePrisTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypePrisTxtB.Location = new System.Drawing.Point(901, 374);
            this.TypePrisTxtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypePrisTxtB.Name = "TypePrisTxtB";
            this.TypePrisTxtB.Size = new System.Drawing.Size(199, 25);
            this.TypePrisTxtB.TabIndex = 29;
            // 
            // YdelseNavnLbl
            // 
            this.YdelseNavnLbl.AutoSize = true;
            this.YdelseNavnLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YdelseNavnLbl.Location = new System.Drawing.Point(901, 264);
            this.YdelseNavnLbl.Name = "YdelseNavnLbl";
            this.YdelseNavnLbl.Size = new System.Drawing.Size(115, 21);
            this.YdelseNavnLbl.TabIndex = 28;
            this.YdelseNavnLbl.Text = "Ydelse forNavn";
            // 
            // YdelseNavnTxtB
            // 
            this.YdelseNavnTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YdelseNavnTxtB.Location = new System.Drawing.Point(901, 292);
            this.YdelseNavnTxtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YdelseNavnTxtB.Name = "YdelseNavnTxtB";
            this.YdelseNavnTxtB.Size = new System.Drawing.Size(199, 25);
            this.YdelseNavnTxtB.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 27);
            this.menuStrip1.TabIndex = 39;
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
            // OpretYdelseForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YdelserView);
            this.Controls.Add(this.OpdatereBtn);
            this.Controls.Add(this.SeltBtn);
            this.Controls.Add(this.OpretBtn);
            this.Controls.Add(this.YdelseIDTxtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypePrisLbl);
            this.Controls.Add(this.TypePrisTxtB);
            this.Controls.Add(this.YdelseNavnLbl);
            this.Controls.Add(this.YdelseNavnTxtB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OpretYdelseForms";
            this.Text = "OpretYdelseForms";
            ((System.ComponentModel.ISupportInitialize)(this.YdelserView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView YdelserView;
        private System.Windows.Forms.Button OpdatereBtn;
        private System.Windows.Forms.Button SeltBtn;
        private System.Windows.Forms.Button OpretBtn;
        private System.Windows.Forms.TextBox YdelseIDTxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TypePrisLbl;
        private System.Windows.Forms.TextBox TypePrisTxtB;
        private System.Windows.Forms.Label YdelseNavnLbl;
        private System.Windows.Forms.TextBox YdelseNavnTxtB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpFileToolStripMenuItem;
    }
}