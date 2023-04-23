
namespace WinFormsAppLawHouse.GUI.Selvbetjening
{
    partial class GaveafgiftForms
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
            this.GaveLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.relationComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pengTextBox = new System.Windows.Forms.TextBox();
            this.btnBeregn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GaveLB
            // 
            this.GaveLB.AutoSize = true;
            this.GaveLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.GaveLB.Location = new System.Drawing.Point(86, 123);
            this.GaveLB.Name = "GaveLB";
            this.GaveLB.Size = new System.Drawing.Size(102, 25);
            this.GaveLB.TabIndex = 3;
            this.GaveLB.Text = "Gaveafgift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vælge din relation til modtageren";
            // 
            // relationComboBox
            // 
            this.relationComboBox.BackColor = System.Drawing.Color.White;
            this.relationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationComboBox.FormattingEnabled = true;
            this.relationComboBox.Items.AddRange(new object[] {
            "Ægtefælle",
            "Børn",
            "Stedbørn",
            "Børnebørn",
            "Stedbørnebørn",
            "Oldebørn",
            "Stedbarns-ægtefælle",
            "Stedforældre ",
            "Bedsteforældre",
            "Svigerbørn",
            "Plejebørn",
            "Samlevende"});
            this.relationComboBox.Location = new System.Drawing.Point(87, 212);
            this.relationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relationComboBox.Name = "relationComboBox";
            this.relationComboBox.Size = new System.Drawing.Size(182, 23);
            this.relationComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Indtast gavens beløb plus antallet  af beløber som du har send til modtageren sam" +
    "let i året";
            // 
            // pengTextBox
            // 
            this.pengTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pengTextBox.Location = new System.Drawing.Point(86, 295);
            this.pengTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pengTextBox.Name = "pengTextBox";
            this.pengTextBox.Size = new System.Drawing.Size(161, 23);
            this.pengTextBox.TabIndex = 7;
            // 
            // btnBeregn
            // 
            this.btnBeregn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.btnBeregn.FlatAppearance.BorderSize = 0;
            this.btnBeregn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeregn.ForeColor = System.Drawing.Color.White;
            this.btnBeregn.Location = new System.Drawing.Point(422, 371);
            this.btnBeregn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeregn.Name = "btnBeregn";
            this.btnBeregn.Size = new System.Drawing.Size(145, 34);
            this.btnBeregn.TabIndex = 8;
            this.btnBeregn.Text = "Beregn";
            this.btnBeregn.UseVisualStyleBackColor = false;
            this.btnBeregn.Click += new System.EventHandler(this.btnBeregn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Afgiften på gaven bliver";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(746, 382);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(162, 23);
            this.resultTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "DKK";
            // 
            // GaveafgiftForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 567);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBeregn);
            this.Controls.Add(this.pengTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.relationComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GaveLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GaveafgiftForms";
            this.Text = "GaveafgiftForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GaveLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox relationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pengTextBox;
        private System.Windows.Forms.Button btnBeregn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label5;
    }
}