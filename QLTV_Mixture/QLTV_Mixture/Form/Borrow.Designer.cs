namespace QLTV_Mixture
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.label1 = new System.Windows.Forms.Label();
            this.lvDSmuon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbMSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 26);
            this.label1.TabIndex = 46;
            this.label1.Text = "DANH SÁCH SINH VIÊN MƯỢN SÁCH";
            // 
            // lvDSmuon
            // 
            this.lvDSmuon.BackColor = System.Drawing.Color.White;
            this.lvDSmuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDSmuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDSmuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvDSmuon.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lvDSmuon.ForeColor = System.Drawing.Color.Indigo;
            this.lvDSmuon.FullRowSelect = true;
            this.lvDSmuon.HideSelection = false;
            this.lvDSmuon.Location = new System.Drawing.Point(0, 90);
            this.lvDSmuon.Name = "lvDSmuon";
            this.lvDSmuon.Size = new System.Drawing.Size(750, 391);
            this.lvDSmuon.TabIndex = 49;
            this.lvDSmuon.UseCompatibleStateImageBehavior = false;
            this.lvDSmuon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mail";
            this.columnHeader3.Width = 163;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(43, 58);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(41, 18);
            this.guna2HtmlLabel3.TabIndex = 60;
            this.guna2HtmlLabel3.Text = "MSSV";
            // 
            // txbMSSV
            // 
            this.txbMSSV.BackColor = System.Drawing.Color.Transparent;
            this.txbMSSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.txbMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMSSV.DefaultText = "";
            this.txbMSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbMSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbMSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMSSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMSSV.IconRight = ((System.Drawing.Image)(resources.GetObject("txbMSSV.IconRight")));
            this.txbMSSV.Location = new System.Drawing.Point(100, 47);
            this.txbMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.PasswordChar = '\0';
            this.txbMSSV.PlaceholderText = "MSSV";
            this.txbMSSV.SelectedText = "";
            this.txbMSSV.Size = new System.Drawing.Size(127, 36);
            this.txbMSSV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbMSSV.TabIndex = 59;
            this.txbMSSV.TextChanged += new System.EventHandler(this.txbMSSV_TextChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SĐT";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sách";
            this.columnHeader5.Width = 335;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 481);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txbMSSV);
            this.Controls.Add(this.lvDSmuon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDSmuon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txbMSSV;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}