
namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    partial class YdelsePåLånForms
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
            this.label3 = new System.Windows.Forms.Label();
            this.ResultTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AntalårTextBox = new System.Windows.Forms.TextBox();
            this.RentePAarTextBox = new System.Windows.Forms.TextBox();
            this.LånStørrelseTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBeregn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Din ydelse på lån er ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ResultTxtBox
            // 
            this.ResultTxtBox.BackColor = System.Drawing.Color.White;
            this.ResultTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTxtBox.Location = new System.Drawing.Point(671, 351);
            this.ResultTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultTxtBox.Name = "ResultTxtBox";
            this.ResultTxtBox.ReadOnly = true;
            this.ResultTxtBox.Size = new System.Drawing.Size(167, 23);
            this.ResultTxtBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Antal år ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rentefod p.a.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lånets størrelse";
            // 
            // AntalårTextBox
            // 
            this.AntalårTextBox.BackColor = System.Drawing.Color.White;
            this.AntalårTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AntalårTextBox.Location = new System.Drawing.Point(359, 287);
            this.AntalårTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AntalårTextBox.Name = "AntalårTextBox";
            this.AntalårTextBox.Size = new System.Drawing.Size(162, 23);
            this.AntalårTextBox.TabIndex = 13;
            // 
            // RentePAarTextBox
            // 
            this.RentePAarTextBox.BackColor = System.Drawing.Color.White;
            this.RentePAarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RentePAarTextBox.Location = new System.Drawing.Point(359, 225);
            this.RentePAarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentePAarTextBox.Name = "RentePAarTextBox";
            this.RentePAarTextBox.Size = new System.Drawing.Size(162, 23);
            this.RentePAarTextBox.TabIndex = 12;
            // 
            // LånStørrelseTextBox
            // 
            this.LånStørrelseTextBox.BackColor = System.Drawing.Color.White;
            this.LånStørrelseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LånStørrelseTextBox.Location = new System.Drawing.Point(359, 168);
            this.LånStørrelseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LånStørrelseTextBox.Name = "LånStørrelseTextBox";
            this.LånStørrelseTextBox.Size = new System.Drawing.Size(162, 23);
            this.LånStørrelseTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(359, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ydelse på Lån";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "DKK";
            // 
            // btnBeregn
            // 
            this.btnBeregn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.btnBeregn.FlatAppearance.BorderSize = 0;
            this.btnBeregn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeregn.ForeColor = System.Drawing.Color.White;
            this.btnBeregn.Location = new System.Drawing.Point(396, 340);
            this.btnBeregn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeregn.Name = "btnBeregn";
            this.btnBeregn.Size = new System.Drawing.Size(125, 40);
            this.btnBeregn.TabIndex = 23;
            this.btnBeregn.Text = "Beregn";
            this.btnBeregn.UseVisualStyleBackColor = false;
            this.btnBeregn.Click += new System.EventHandler(this.btnBeregn_Click);
            // 
            // YdelsePåLånForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 567);
            this.Controls.Add(this.btnBeregn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AntalårTextBox);
            this.Controls.Add(this.RentePAarTextBox);
            this.Controls.Add(this.LånStørrelseTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YdelsePåLånForms";
            this.Text = "YdelsePåLånForms";
            this.Load += new System.EventHandler(this.YdelsePåLånForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AntalårTextBox;
        private System.Windows.Forms.TextBox RentePAarTextBox;
        private System.Windows.Forms.TextBox LånStørrelseTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBeregn;
    }
}