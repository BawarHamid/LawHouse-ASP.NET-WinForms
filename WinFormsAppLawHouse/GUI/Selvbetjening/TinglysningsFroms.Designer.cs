
namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    partial class TinglysningsFroms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prisTextBox = new System.Windows.Forms.TextBox();
            this.btnBeregn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(144, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tinglysningsafgift ved almindelig fri handel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Indtast prisen af din ejendom";
            // 
            // prisTextBox
            // 
            this.prisTextBox.BackColor = System.Drawing.Color.White;
            this.prisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prisTextBox.Location = new System.Drawing.Point(359, 262);
            this.prisTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prisTextBox.Name = "prisTextBox";
            this.prisTextBox.Size = new System.Drawing.Size(168, 23);
            this.prisTextBox.TabIndex = 4;
            // 
            // btnBeregn
            // 
            this.btnBeregn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.btnBeregn.FlatAppearance.BorderSize = 0;
            this.btnBeregn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeregn.ForeColor = System.Drawing.Color.White;
            this.btnBeregn.Location = new System.Drawing.Point(387, 337);
            this.btnBeregn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeregn.Name = "btnBeregn";
            this.btnBeregn.Size = new System.Drawing.Size(140, 37);
            this.btnBeregn.TabIndex = 6;
            this.btnBeregn.Text = "Beregn";
            this.btnBeregn.UseVisualStyleBackColor = false;
            this.btnBeregn.Click += new System.EventHandler(this.btnBeregn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tinglysningen koster";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(694, 351);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(168, 23);
            this.resultTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(867, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dkk";
            // 
            // TinglysningsFroms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBeregn);
            this.Controls.Add(this.prisTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TinglysningsFroms";
            this.Text = "TinglysningsFroms";
            this.Load += new System.EventHandler(this.TinglysningsFroms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prisTextBox;
        private System.Windows.Forms.Button btnBeregn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label4;
    }
}