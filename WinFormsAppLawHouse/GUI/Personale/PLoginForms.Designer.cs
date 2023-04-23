
namespace WinFormsAppLawHouse.GUI.Personale
{
    partial class PLoginForms
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
            this.MedarbejderIDTxtB = new System.Windows.Forms.TextBox();
            this.NavnTxtB = new System.Windows.Forms.TextBox();
            this.NavnLbl = new System.Windows.Forms.Label();
            this.MedarbejderIDLbl = new System.Windows.Forms.Label();
            this.LogPaaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MedarbejderIDTxtB
            // 
            this.MedarbejderIDTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedarbejderIDTxtB.Location = new System.Drawing.Point(531, 239);
            this.MedarbejderIDTxtB.Name = "MedarbejderIDTxtB";
            this.MedarbejderIDTxtB.Size = new System.Drawing.Size(113, 25);
            this.MedarbejderIDTxtB.TabIndex = 26;
            // 
            // NavnTxtB
            // 
            this.NavnTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavnTxtB.Location = new System.Drawing.Point(531, 194);
            this.NavnTxtB.Name = "NavnTxtB";
            this.NavnTxtB.Size = new System.Drawing.Size(113, 25);
            this.NavnTxtB.TabIndex = 25;
            // 
            // NavnLbl
            // 
            this.NavnLbl.AutoSize = true;
            this.NavnLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavnLbl.Location = new System.Drawing.Point(448, 194);
            this.NavnLbl.Name = "NavnLbl";
            this.NavnLbl.Size = new System.Drawing.Size(48, 19);
            this.NavnLbl.TabIndex = 24;
            this.NavnLbl.Text = "Navn";
            // 
            // MedarbejderIDLbl
            // 
            this.MedarbejderIDLbl.AutoSize = true;
            this.MedarbejderIDLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedarbejderIDLbl.Location = new System.Drawing.Point(368, 241);
            this.MedarbejderIDLbl.Name = "MedarbejderIDLbl";
            this.MedarbejderIDLbl.Size = new System.Drawing.Size(128, 19);
            this.MedarbejderIDLbl.TabIndex = 23;
            this.MedarbejderIDLbl.Text = "Medarbejder ID";
            // 
            // LogPaaBtn
            // 
            this.LogPaaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.LogPaaBtn.FlatAppearance.BorderSize = 0;
            this.LogPaaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogPaaBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogPaaBtn.ForeColor = System.Drawing.Color.White;
            this.LogPaaBtn.Location = new System.Drawing.Point(531, 280);
            this.LogPaaBtn.Name = "LogPaaBtn";
            this.LogPaaBtn.Size = new System.Drawing.Size(113, 29);
            this.LogPaaBtn.TabIndex = 22;
            this.LogPaaBtn.Text = "Log på";
            this.LogPaaBtn.UseVisualStyleBackColor = false;
            this.LogPaaBtn.Click += new System.EventHandler(this.LogPaaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(432, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Medarbejder - Log ind";
            // 
            // PLoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 448);
            this.Controls.Add(this.MedarbejderIDTxtB);
            this.Controls.Add(this.NavnTxtB);
            this.Controls.Add(this.NavnLbl);
            this.Controls.Add(this.MedarbejderIDLbl);
            this.Controls.Add(this.LogPaaBtn);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PLoginForms";
            this.Text = "Personale login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MedarbejderIDTxtB;
        private System.Windows.Forms.TextBox NavnTxtB;
        private System.Windows.Forms.Label NavnLbl;
        private System.Windows.Forms.Label MedarbejderIDLbl;
        private System.Windows.Forms.Button LogPaaBtn;
        private System.Windows.Forms.Label label3;
    }
}