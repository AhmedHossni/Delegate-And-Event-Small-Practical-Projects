namespace TestSendDataBackToFormUsingDelegate
{
    partial class frmDataSender
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
            this.tboxValue = new System.Windows.Forms.TextBox();
            this.btnReturnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxValue
            // 
            this.tboxValue.Location = new System.Drawing.Point(342, 60);
            this.tboxValue.Name = "tboxValue";
            this.tboxValue.Size = new System.Drawing.Size(256, 24);
            this.tboxValue.TabIndex = 0;
            // 
            // btnReturnValue
            // 
            this.btnReturnValue.Location = new System.Drawing.Point(68, 60);
            this.btnReturnValue.Name = "btnReturnValue";
            this.btnReturnValue.Size = new System.Drawing.Size(238, 23);
            this.btnReturnValue.TabIndex = 1;
            this.btnReturnValue.Text = "Return Value To Form One";
            this.btnReturnValue.UseVisualStyleBackColor = true;
            this.btnReturnValue.Click += new System.EventHandler(this.btnReturnValue_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 146);
            this.Controls.Add(this.btnReturnValue);
            this.Controls.Add(this.tboxValue);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxValue;
        private System.Windows.Forms.Button btnReturnValue;
    }
}