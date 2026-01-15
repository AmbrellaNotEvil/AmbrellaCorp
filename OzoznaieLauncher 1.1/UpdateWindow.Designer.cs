namespace OzoznaieLauncher_1._1
{
    partial class UpdateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWindow));
            this.ExitButton = new System.Windows.Forms.Button();
            this.TrayButton = new System.Windows.Forms.Button();
            this.WinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(906, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(46, 35);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // TrayButton
            // 
            this.TrayButton.BackColor = System.Drawing.Color.Transparent;
            this.TrayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrayButton.FlatAppearance.BorderSize = 0;
            this.TrayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrayButton.Image = ((System.Drawing.Image)(resources.GetObject("TrayButton.Image")));
            this.TrayButton.Location = new System.Drawing.Point(818, 14);
            this.TrayButton.Name = "TrayButton";
            this.TrayButton.Size = new System.Drawing.Size(30, 30);
            this.TrayButton.TabIndex = 9;
            this.TrayButton.UseVisualStyleBackColor = false;
            // 
            // WinButton
            // 
            this.WinButton.BackColor = System.Drawing.Color.Transparent;
            this.WinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WinButton.FlatAppearance.BorderSize = 0;
            this.WinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.WinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WinButton.Image = ((System.Drawing.Image)(resources.GetObject("WinButton.Image")));
            this.WinButton.Location = new System.Drawing.Point(854, 12);
            this.WinButton.Name = "WinButton";
            this.WinButton.Size = new System.Drawing.Size(46, 35);
            this.WinButton.TabIndex = 8;
            this.WinButton.UseVisualStyleBackColor = false;
            // 
            // UpdateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TrayButton);
            this.Controls.Add(this.WinButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateWindow";
            this.Text = "UpdateWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TrayButton;
        private System.Windows.Forms.Button WinButton;
    }
}