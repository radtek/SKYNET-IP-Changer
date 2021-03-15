namespace SKYNET.Dota2GCLauncher.Controls
{
    partial class DotaButton
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
            this.txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(25, 6);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(73, 20);
            this.txt.TabIndex = 0;
            this.txt.Text = "► JUGAR";
            this.txt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.txt.Click += new System.EventHandler(this.DotaButton_Click);
            this.txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DotaButton_MouseClick);
            this.txt.MouseLeave += new System.EventHandler(this.DotaButton_MouseLeave);
            this.txt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DotaButton_MouseMove);
            // 
            // DotaButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.txt);
            this.Name = "DotaButton";
            this.Size = new System.Drawing.Size(127, 34);
            this.Load += new System.EventHandler(this.DotaButton_Load);
            this.Click += new System.EventHandler(this.DotaButton_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DotaButton_MouseClick);
            this.MouseLeave += new System.EventHandler(this.DotaButton_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DotaButton_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt;
    }
}
