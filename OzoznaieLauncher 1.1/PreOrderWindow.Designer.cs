namespace OzoznaieLauncher_1._1
{
    partial class PreOrderWindow66
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreOrderWindow66));
            this.PayButton = new System.Windows.Forms.Button();
            this.CancelPayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PayButton.BackgroundImage")));
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Location = new System.Drawing.Point(23, 332);
            this.PayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(63, 27);
            this.PayButton.TabIndex = 0;
            this.PayButton.UseVisualStyleBackColor = true;
            // 
            // CancelPayButton
            // 
            this.CancelPayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelPayButton.BackgroundImage")));
            this.CancelPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelPayButton.Location = new System.Drawing.Point(111, 332);
            this.CancelPayButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelPayButton.Name = "CancelPayButton";
            this.CancelPayButton.Size = new System.Drawing.Size(67, 27);
            this.CancelPayButton.TabIndex = 1;
            this.CancelPayButton.UseVisualStyleBackColor = true;
            // 
            // PreOrderWindow66
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 393);
            this.Controls.Add(this.CancelPayButton);
            this.Controls.Add(this.PayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PreOrderWindow66";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button CancelPayButton;
    }
}