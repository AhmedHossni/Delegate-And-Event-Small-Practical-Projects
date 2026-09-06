namespace TestSendDataBackToFormUsingDelegate
{
    partial class frmDataReciver
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
            this.tboxFormTwoReturnValue = new System.Windows.Forms.TextBox();
            this.btnOpenFormTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxFormTwoReturnValue
            // 
            this.tboxFormTwoReturnValue.Location = new System.Drawing.Point(292, 67);
            this.tboxFormTwoReturnValue.Name = "tboxFormTwoReturnValue";
            this.tboxFormTwoReturnValue.Size = new System.Drawing.Size(241, 24);
            this.tboxFormTwoReturnValue.TabIndex = 0;
            // 
            // btnOpenFormTwo
            // 
            this.btnOpenFormTwo.Location = new System.Drawing.Point(89, 68);
            this.btnOpenFormTwo.Name = "btnOpenFormTwo";
            this.btnOpenFormTwo.Size = new System.Drawing.Size(149, 23);
            this.btnOpenFormTwo.TabIndex = 1;
            this.btnOpenFormTwo.Text = "Open Form Two";
            this.btnOpenFormTwo.UseVisualStyleBackColor = true;
            this.btnOpenFormTwo.Click += new System.EventHandler(this.btnOpenFormTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 138);
            this.Controls.Add(this.btnOpenFormTwo);
            this.Controls.Add(this.tboxFormTwoReturnValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxFormTwoReturnValue;
        private System.Windows.Forms.Button btnOpenFormTwo;
    }
}

