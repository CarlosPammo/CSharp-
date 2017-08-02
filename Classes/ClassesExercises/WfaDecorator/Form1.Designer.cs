namespace WfaDecorator
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
            this.cbOpenWindow = new System.Windows.Forms.CheckBox();
            this.cbMessage = new System.Windows.Forms.CheckBox();
            this.cbCount = new System.Windows.Forms.CheckBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOpenWindow
            // 
            this.cbOpenWindow.AutoSize = true;
            this.cbOpenWindow.Location = new System.Drawing.Point(69, 40);
            this.cbOpenWindow.Name = "cbOpenWindow";
            this.cbOpenWindow.Size = new System.Drawing.Size(91, 17);
            this.cbOpenWindow.TabIndex = 0;
            this.cbOpenWindow.Text = "Open window";
            this.cbOpenWindow.UseVisualStyleBackColor = true;
            this.cbOpenWindow.CheckedChanged += new System.EventHandler(this.cbOpenWindow_CheckedChanged);
            // 
            // cbMessage
            // 
            this.cbMessage.AutoSize = true;
            this.cbMessage.Location = new System.Drawing.Point(69, 84);
            this.cbMessage.Name = "cbMessage";
            this.cbMessage.Size = new System.Drawing.Size(98, 17);
            this.cbMessage.TabIndex = 1;
            this.cbMessage.Text = "Show message";
            this.cbMessage.UseVisualStyleBackColor = true;
            // 
            // cbCount
            // 
            this.cbCount.AutoSize = true;
            this.cbCount.Location = new System.Drawing.Point(69, 128);
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(78, 17);
            this.cbCount.TabIndex = 2;
            this.cbCount.Text = "Start count";
            this.cbCount.UseVisualStyleBackColor = true;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(233, 84);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 23);
            this.btnReady.TabIndex = 3;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 316);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.cbCount);
            this.Controls.Add(this.cbMessage);
            this.Controls.Add(this.cbOpenWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOpenWindow;
        private System.Windows.Forms.CheckBox cbMessage;
        private System.Windows.Forms.CheckBox cbCount;
        private System.Windows.Forms.Button btnReady;
    }
}

