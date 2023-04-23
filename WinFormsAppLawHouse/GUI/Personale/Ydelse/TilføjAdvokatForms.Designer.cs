
namespace WinFormsAppLawHouse.GUI.Personale.Ydelse
{
    partial class TilføjAdvokatForms
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
            this.YdelsesIDLbl = new System.Windows.Forms.Label();
            this.YdelseIDTxtB = new System.Windows.Forms.TextBox();
            this.AdvokatIDLbl = new System.Windows.Forms.Label();
            this.AdvokatIDTxtB = new System.Windows.Forms.TextBox();
            this.AdvokatView = new System.Windows.Forms.DataGridView();
            this.TilføjBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ydelerBtn = new System.Windows.Forms.Button();
            this.AdvoBtn = new System.Windows.Forms.Button();
            this.AdvYdBtn = new System.Windows.Forms.Button();
            this.SletBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdvokatView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YdelsesIDLbl
            // 
            this.YdelsesIDLbl.AutoSize = true;
            this.YdelsesIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YdelsesIDLbl.Location = new System.Drawing.Point(970, 384);
            this.YdelsesIDLbl.Name = "YdelsesIDLbl";
            this.YdelsesIDLbl.Size = new System.Drawing.Size(73, 21);
            this.YdelsesIDLbl.TabIndex = 19;
            this.YdelsesIDLbl.Text = "Ydelse ID";
            // 
            // YdelseIDTxtB
            // 
            this.YdelseIDTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YdelseIDTxtB.Location = new System.Drawing.Point(970, 414);
            this.YdelseIDTxtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YdelseIDTxtB.Name = "YdelseIDTxtB";
            this.YdelseIDTxtB.Size = new System.Drawing.Size(123, 25);
            this.YdelseIDTxtB.TabIndex = 18;
            // 
            // AdvokatIDLbl
            // 
            this.AdvokatIDLbl.AutoSize = true;
            this.AdvokatIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvokatIDLbl.Location = new System.Drawing.Point(970, 300);
            this.AdvokatIDLbl.Name = "AdvokatIDLbl";
            this.AdvokatIDLbl.Size = new System.Drawing.Size(84, 21);
            this.AdvokatIDLbl.TabIndex = 17;
            this.AdvokatIDLbl.Text = "Advokat Id";
            // 
            // AdvokatIDTxtB
            // 
            this.AdvokatIDTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvokatIDTxtB.Location = new System.Drawing.Point(970, 327);
            this.AdvokatIDTxtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdvokatIDTxtB.Name = "AdvokatIDTxtB";
            this.AdvokatIDTxtB.Size = new System.Drawing.Size(123, 25);
            this.AdvokatIDTxtB.TabIndex = 16;
            // 
            // AdvokatView
            // 
            this.AdvokatView.AllowUserToAddRows = false;
            this.AdvokatView.AllowUserToDeleteRows = false;
            this.AdvokatView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdvokatView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.AdvokatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvokatView.Location = new System.Drawing.Point(63, 187);
            this.AdvokatView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdvokatView.Name = "AdvokatView";
            this.AdvokatView.ReadOnly = true;
            this.AdvokatView.RowHeadersWidth = 51;
            this.AdvokatView.RowTemplate.Height = 29;
            this.AdvokatView.Size = new System.Drawing.Size(828, 477);
            this.AdvokatView.TabIndex = 15;
            this.AdvokatView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdvokatView_CellClick);
            // 
            // TilføjBtn
            // 
            this.TilføjBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.TilføjBtn.FlatAppearance.BorderSize = 0;
            this.TilføjBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TilføjBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TilføjBtn.ForeColor = System.Drawing.Color.White;
            this.TilføjBtn.Location = new System.Drawing.Point(970, 472);
            this.TilføjBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TilføjBtn.Name = "TilføjBtn";
            this.TilføjBtn.Size = new System.Drawing.Size(123, 31);
            this.TilføjBtn.TabIndex = 14;
            this.TilføjBtn.Text = "Tilføj ";
            this.TilføjBtn.UseVisualStyleBackColor = false;
            this.TilføjBtn.Click += new System.EventHandler(this.TilføjBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 27);
            this.menuStrip1.TabIndex = 20;
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
            // ydelerBtn
            // 
            this.ydelerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.ydelerBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ydelerBtn.ForeColor = System.Drawing.Color.White;
            this.ydelerBtn.Location = new System.Drawing.Point(63, 150);
            this.ydelerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ydelerBtn.Name = "ydelerBtn";
            this.ydelerBtn.Size = new System.Drawing.Size(116, 33);
            this.ydelerBtn.TabIndex = 21;
            this.ydelerBtn.Text = "Ydelser";
            this.ydelerBtn.UseVisualStyleBackColor = false;
            this.ydelerBtn.Click += new System.EventHandler(this.ydelerBtn_Click);
            // 
            // AdvoBtn
            // 
            this.AdvoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.AdvoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvoBtn.ForeColor = System.Drawing.Color.White;
            this.AdvoBtn.Location = new System.Drawing.Point(185, 150);
            this.AdvoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdvoBtn.Name = "AdvoBtn";
            this.AdvoBtn.Size = new System.Drawing.Size(116, 33);
            this.AdvoBtn.TabIndex = 22;
            this.AdvoBtn.Text = "Advokater";
            this.AdvoBtn.UseVisualStyleBackColor = false;
            this.AdvoBtn.Click += new System.EventHandler(this.AdvoBtn_Click);
            // 
            // AdvYdBtn
            // 
            this.AdvYdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.AdvYdBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvYdBtn.ForeColor = System.Drawing.Color.White;
            this.AdvYdBtn.Location = new System.Drawing.Point(769, 150);
            this.AdvYdBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdvYdBtn.Name = "AdvYdBtn";
            this.AdvYdBtn.Size = new System.Drawing.Size(122, 33);
            this.AdvYdBtn.TabIndex = 23;
            this.AdvYdBtn.Text = "AdvokatYdelse";
            this.AdvYdBtn.UseVisualStyleBackColor = false;
            this.AdvYdBtn.Click += new System.EventHandler(this.AdvYdBtn_Click);
            // 
            // SletBtn
            // 
            this.SletBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.SletBtn.FlatAppearance.BorderSize = 0;
            this.SletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SletBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SletBtn.ForeColor = System.Drawing.Color.White;
            this.SletBtn.Location = new System.Drawing.Point(970, 541);
            this.SletBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SletBtn.Name = "SletBtn";
            this.SletBtn.Size = new System.Drawing.Size(123, 31);
            this.SletBtn.TabIndex = 24;
            this.SletBtn.Text = "Slet";
            this.SletBtn.UseVisualStyleBackColor = false;
            this.SletBtn.Click += new System.EventHandler(this.SletBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(376, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tilføj advokat til ydelser";
            // 
            // TilføjAdvokatForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SletBtn);
            this.Controls.Add(this.AdvYdBtn);
            this.Controls.Add(this.AdvoBtn);
            this.Controls.Add(this.ydelerBtn);
            this.Controls.Add(this.YdelsesIDLbl);
            this.Controls.Add(this.YdelseIDTxtB);
            this.Controls.Add(this.AdvokatIDLbl);
            this.Controls.Add(this.AdvokatIDTxtB);
            this.Controls.Add(this.AdvokatView);
            this.Controls.Add(this.TilføjBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TilføjAdvokatForms";
            this.Text = "TilføjAdvokatForms";
            ((System.ComponentModel.ISupportInitialize)(this.AdvokatView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label YdelsesIDLbl;
        private System.Windows.Forms.TextBox YdelseIDTxtB;
        private System.Windows.Forms.Label AdvokatIDLbl;
        private System.Windows.Forms.TextBox AdvokatIDTxtB;
        private System.Windows.Forms.DataGridView AdvokatView;
        private System.Windows.Forms.Button TilføjBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHelpFileToolStripMenuItem;
        private System.Windows.Forms.Button ydelerBtn;
        private System.Windows.Forms.Button AdvoBtn;
        private System.Windows.Forms.Button AdvYdBtn;
        private System.Windows.Forms.Button SletBtn;
        private System.Windows.Forms.Label label1;
    }
}