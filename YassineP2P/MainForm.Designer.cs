namespace YassineP2P
{
    partial class MainForm
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
            this.openBtn = new System.Windows.Forms.Button();
            this.ShareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Location = new System.Drawing.Point(35, 19);
            this.openBtn.Name = "openBtn";
            this.openBtn.Padding = new System.Windows.Forms.Padding(32, 8, 32, 8);
            this.openBtn.Size = new System.Drawing.Size(192, 48);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open File";
            this.openBtn.UseVisualStyleBackColor = true;
            // 
            // ShareBtn
            // 
            this.ShareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShareBtn.Location = new System.Drawing.Point(35, 73);
            this.ShareBtn.Name = "ShareBtn";
            this.ShareBtn.Padding = new System.Windows.Forms.Padding(32, 8, 32, 8);
            this.ShareBtn.Size = new System.Drawing.Size(192, 48);
            this.ShareBtn.TabIndex = 1;
            this.ShareBtn.Text = "Share";
            this.ShareBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 221);
            this.Controls.Add(this.ShareBtn);
            this.Controls.Add(this.openBtn);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.Text = "CFS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button ShareBtn;
    }
}

