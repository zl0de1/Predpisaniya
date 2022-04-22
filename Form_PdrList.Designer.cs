
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.textBox_gpdNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_inn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.listViewStreets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxStreetAdd = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAddStreet = new System.Windows.Forms.Button();
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
            this.listBoxPdr.Size = new System.Drawing.Size(180, 439);
            this.listBoxPdr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Полное наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Договор №";
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fullName.Location = new System.Drawing.Point(346, 15);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(443, 20);
            this.textBox_fullName.TabIndex = 3;
            // 
            // textBox_gpdNumber
            // 
            this.textBox_gpdNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_gpdNumber.Location = new System.Drawing.Point(346, 41);
            this.textBox_gpdNumber.Name = "textBox_gpdNumber";
            this.textBox_gpdNumber.Size = new System.Drawing.Size(443, 20);
            this.textBox_gpdNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(200, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ИНН";
            // 
            // textBox_inn
            // 
            this.textBox_inn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_inn.Location = new System.Drawing.Point(346, 67);
            this.textBox_inn.Name = "textBox_inn";
            this.textBox_inn.Size = new System.Drawing.Size(443, 20);
            this.textBox_inn.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(200, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail";
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Location = new System.Drawing.Point(346, 93);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(443, 20);
            this.textBox_email.TabIndex = 8;
            // 
            // listViewStreets
            // 
            this.listViewStreets.BackColor = System.Drawing.SystemColors.Window;
            this.listViewStreets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStreets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewStreets.HideSelection = false;
            this.listViewStreets.Location = new System.Drawing.Point(203, 145);
            this.listViewStreets.Name = "listViewStreets";
            this.listViewStreets.Size = new System.Drawing.Size(586, 280);
            this.listViewStreets.TabIndex = 9;
            this.listViewStreets.UseCompatibleStateImageBehavior = false;
            this.listViewStreets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Улица";
            this.columnHeader1.Width = 470;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Протяженность";
            this.columnHeader2.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(200, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "?";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(346, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBoxStreetAdd
            // 
            this.textBoxStreetAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStreetAdd.Location = new System.Drawing.Point(203, 431);
            this.textBoxStreetAdd.Name = "textBoxStreetAdd";
            this.textBoxStreetAdd.Size = new System.Drawing.Size(400, 20);
            this.textBoxStreetAdd.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(609, 431);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 13;
            // 
            // buttonAddStreet
            // 
            this.buttonAddStreet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddStreet.Location = new System.Drawing.Point(718, 431);
            this.buttonAddStreet.Name = "buttonAddStreet";
            this.buttonAddStreet.Size = new System.Drawing.Size(71, 20);
            this.buttonAddStreet.TabIndex = 14;
            this.buttonAddStreet.Text = "Добавить";
            this.buttonAddStreet.UseVisualStyleBackColor = true;
            // 
            // Form_PdrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 463);
            this.Controls.Add(this.buttonAddStreet);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxStreetAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewStreets);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_inn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_gpdNumber);
            this.Controls.Add(this.textBox_fullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPdr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PdrList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр подрядчиков";
            this.Load += new System.EventHandler(this.Form_PdrList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPdr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.TextBox textBox_gpdNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_inn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.ListView listViewStreets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxStreetAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAddStreet;
    }
}