
namespace WinFormsAppLawHouse.GUI.Personale.Sager
{
    partial class YdelseDataGridViewForms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KlientIDTxtB = new System.Windows.Forms.TextBox();
            this.KlientIDBtn = new System.Windows.Forms.Button();
            this.YdelseView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YdelseView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 286);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KlientIDTxtB);
            this.panel2.Controls.Add(this.KlientIDBtn);
            this.panel2.Controls.Add(this.YdelseView);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 286);
            this.panel2.TabIndex = 0;
            // 
            // KlientIDTxtB
            // 
            this.KlientIDTxtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KlientIDTxtB.Location = new System.Drawing.Point(4, 6);
            this.KlientIDTxtB.Name = "KlientIDTxtB";
            this.KlientIDTxtB.Size = new System.Drawing.Size(100, 23);
            this.KlientIDTxtB.TabIndex = 10;
            // 
            // KlientIDBtn
            // 
            this.KlientIDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.KlientIDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KlientIDBtn.FlatAppearance.BorderSize = 0;
            this.KlientIDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KlientIDBtn.ForeColor = System.Drawing.Color.White;
            this.KlientIDBtn.Location = new System.Drawing.Point(120, 6);
            this.KlientIDBtn.Name = "KlientIDBtn";
            this.KlientIDBtn.Size = new System.Drawing.Size(118, 23);
            this.KlientIDBtn.TabIndex = 9;
            this.KlientIDBtn.Text = "Søg efter klient ID";
            this.KlientIDBtn.UseVisualStyleBackColor = false;
            this.KlientIDBtn.Click += new System.EventHandler(this.KlientIDBtn_Click);
            // 
            // YdelseView
            // 
            this.YdelseView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.YdelseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YdelseView.Location = new System.Drawing.Point(3, 35);
            this.YdelseView.Name = "YdelseView";
            this.YdelseView.RowHeadersWidth = 51;
            this.YdelseView.RowTemplate.Height = 25;
            this.YdelseView.Size = new System.Drawing.Size(1202, 263);
            this.YdelseView.TabIndex = 8;
            // 
            // YdelseDataGridViewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "YdelseDataGridViewForms";
            this.Size = new System.Drawing.Size(1168, 289);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YdelseView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox KlientIDTxtB;
        private System.Windows.Forms.Button KlientIDBtn;
        private System.Windows.Forms.DataGridView YdelseView;
    }
}
