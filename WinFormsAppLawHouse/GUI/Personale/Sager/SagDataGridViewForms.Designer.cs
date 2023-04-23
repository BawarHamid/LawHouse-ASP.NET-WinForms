
namespace WinFormsAppLawHouse.GUI.Personale.Sager
{
    partial class SagDataGridViewForms
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
            this.SagView = new System.Windows.Forms.DataGridView();
            this.KlientIDBtn = new System.Windows.Forms.Button();
            this.KlientIDTxtB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SagView)).BeginInit();
            this.SuspendLayout();
            // 
            // SagView
            // 
            this.SagView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.SagView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SagView.Location = new System.Drawing.Point(3, 37);
            this.SagView.Name = "SagView";
            this.SagView.RowHeadersWidth = 51;
            this.SagView.RowTemplate.Height = 25;
            this.SagView.Size = new System.Drawing.Size(1202, 263);
            this.SagView.TabIndex = 0;
            // 
            // KlientIDBtn
            // 
            this.KlientIDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.KlientIDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KlientIDBtn.FlatAppearance.BorderSize = 0;
            this.KlientIDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KlientIDBtn.ForeColor = System.Drawing.Color.White;
            this.KlientIDBtn.Location = new System.Drawing.Point(119, 8);
            this.KlientIDBtn.Name = "KlientIDBtn";
            this.KlientIDBtn.Size = new System.Drawing.Size(118, 23);
            this.KlientIDBtn.TabIndex = 1;
            this.KlientIDBtn.Text = "Søg efter klient ID";
            this.KlientIDBtn.UseVisualStyleBackColor = false;
            this.KlientIDBtn.Click += new System.EventHandler(this.KlientIDBtn_Click);
            // 
            // KlientIDTxtB
            // 
            this.KlientIDTxtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KlientIDTxtB.Location = new System.Drawing.Point(3, 8);
            this.KlientIDTxtB.Name = "KlientIDTxtB";
            this.KlientIDTxtB.Size = new System.Drawing.Size(100, 23);
            this.KlientIDTxtB.TabIndex = 2;
            // 
            // SagDataGridViewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.KlientIDTxtB);
            this.Controls.Add(this.KlientIDBtn);
            this.Controls.Add(this.SagView);
            this.Name = "SagDataGridViewForms";
            this.Size = new System.Drawing.Size(1210, 306);
            ((System.ComponentModel.ISupportInitialize)(this.SagView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SagView;
        private System.Windows.Forms.Button KlientIDBtn;
        private System.Windows.Forms.TextBox KlientIDTxtB;
    }
}
