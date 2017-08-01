namespace DynamicLinqWFA
{
    partial class Form1
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
            this.TbCriteria = new System.Windows.Forms.TextBox();
            this.CbOperation = new System.Windows.Forms.ComboBox();
            this.CbField = new System.Windows.Forms.ComboBox();
            this.DgShampoos = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgShampoos)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCriteria
            // 
            this.TbCriteria.Location = new System.Drawing.Point(13, 37);
            this.TbCriteria.Name = "TbCriteria";
            this.TbCriteria.Size = new System.Drawing.Size(172, 20);
            this.TbCriteria.TabIndex = 0;
            // 
            // CbOperation
            // 
            this.CbOperation.FormattingEnabled = true;
            this.CbOperation.Location = new System.Drawing.Point(241, 36);
            this.CbOperation.Name = "CbOperation";
            this.CbOperation.Size = new System.Drawing.Size(152, 21);
            this.CbOperation.TabIndex = 1;
            // 
            // CbField
            // 
            this.CbField.FormattingEnabled = true;
            this.CbField.Location = new System.Drawing.Point(448, 36);
            this.CbField.Name = "CbField";
            this.CbField.Size = new System.Drawing.Size(143, 21);
            this.CbField.TabIndex = 2;
            // 
            // DgShampoos
            // 
            this.DgShampoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgShampoos.Location = new System.Drawing.Point(13, 96);
            this.DgShampoos.Name = "DgShampoos";
            this.DgShampoos.Size = new System.Drawing.Size(578, 150);
            this.DgShampoos.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(516, 297);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 332);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgShampoos);
            this.Controls.Add(this.CbField);
            this.Controls.Add(this.CbOperation);
            this.Controls.Add(this.TbCriteria);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgShampoos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbCriteria;
        private System.Windows.Forms.ComboBox CbOperation;
        private System.Windows.Forms.ComboBox CbField;
        private System.Windows.Forms.DataGridView DgShampoos;
        private System.Windows.Forms.Button BtnSearch;
    }
}

