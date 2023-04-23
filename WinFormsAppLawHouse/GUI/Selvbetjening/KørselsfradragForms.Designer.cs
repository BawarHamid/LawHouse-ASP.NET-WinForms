
namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    partial class KørselsfradragForms
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
            this.KørselLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fradragTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBeregn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KørselLb
            // 
            this.KørselLb.AutoSize = true;
            this.KørselLb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.KørselLb.Location = new System.Drawing.Point(136, 142);
            this.KørselLb.Name = "KørselLb";
            this.KørselLb.Size = new System.Drawing.Size(136, 25);
            this.KørselLb.TabIndex = 3;
            this.KørselLb.Text = "Kørselsfradrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indtast antal kilometer til arbejdspladsen (frem og tilbage)";
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(148, 223);
            this.kmTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(110, 23);
            this.kmTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indast antal dage om året som du tager på arbejdpladsen";
            // 
            // dageTextBox
            // 
            this.dageTextBox.Location = new System.Drawing.Point(148, 304);
            this.dageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dageTextBox.Name = "dageTextBox";
            this.dageTextBox.Size = new System.Drawing.Size(110, 23);
            this.dageTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Din samlede kørselfradrag er ";
            // 
            // fradragTextBox
            // 
            this.fradragTextBox.Location = new System.Drawing.Point(686, 361);
            this.fradragTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fradragTextBox.Name = "fradragTextBox";
            this.fradragTextBox.ReadOnly = true;
            this.fradragTextBox.Size = new System.Drawing.Size(193, 23);
            this.fradragTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "dkk.";
            // 
            // btnBeregn
            // 
            this.btnBeregn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.btnBeregn.FlatAppearance.BorderSize = 0;
            this.btnBeregn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeregn.ForeColor = System.Drawing.Color.White;
            this.btnBeregn.Location = new System.Drawing.Point(327, 352);
            this.btnBeregn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeregn.Name = "btnBeregn";
            this.btnBeregn.Size = new System.Drawing.Size(133, 39);
            this.btnBeregn.TabIndex = 11;
            this.btnBeregn.Text = "Beregn";
            this.btnBeregn.UseVisualStyleBackColor = false;
            this.btnBeregn.Click += new System.EventHandler(this.btnBeregn_Click);
            // 
            // KørselsfradragForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 567);
            this.Controls.Add(this.btnBeregn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fradragTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KørselLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KørselsfradragForms";
            this.Text = "KørselsfradragForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KørselLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fradragTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBeregn;
    }
}