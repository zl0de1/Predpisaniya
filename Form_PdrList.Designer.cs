
namespace WindowsFormsApp1
{
    partial class Form_PdrList
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
            this.listBoxPdr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxPdr
            // 
            this.listBoxPdr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxPdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPdr.FormattingEnabled = true;
            this.listBoxPdr.ItemHeight = 15;
            this.listBoxPdr.Location = new System.Drawing.Point(12, 12);
            this.listBoxPdr.Name = "listBoxPdr";
            this.listBoxPdr.Size = new System.Drawing.Size(180, 454);
            this.listBoxPdr.TabIndex = 0;
            // 
            // Form_PdrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 484);
            this.Controls.Add(this.listBoxPdr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PdrList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_PdrList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_PdrList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPdr;
    }
}