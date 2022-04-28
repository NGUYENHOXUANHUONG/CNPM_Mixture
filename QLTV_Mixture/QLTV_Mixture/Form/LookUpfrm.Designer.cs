namespace QLTV_Mixture
{
    partial class LookUpfrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpfrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTuchoi = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ccbCate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ccbAuth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lvLookUp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QLTV_Mixture.Properties.Resources.umhum;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnTuchoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.ccbCate);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.ccbAuth);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.lvLookUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 490);
            this.panel1.TabIndex = 0;
            // 
            // btnTuchoi
            // 
            this.btnTuchoi.BackColor = System.Drawing.Color.Transparent;
            this.btnTuchoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.btnTuchoi.BorderRadius = 10;
            this.btnTuchoi.BorderThickness = 2;
            this.btnTuchoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuchoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuchoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuchoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuchoi.FillColor = System.Drawing.Color.White;
            this.btnTuchoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnTuchoi.ForeColor = System.Drawing.Color.Black;
            this.btnTuchoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTuchoi.Image")));
            this.btnTuchoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTuchoi.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTuchoi.Location = new System.Drawing.Point(638, 44);
            this.btnTuchoi.Name = "btnTuchoi";
            this.btnTuchoi.Size = new System.Drawing.Size(100, 36);
            this.btnTuchoi.TabIndex = 60;
            this.btnTuchoi.Text = "Tất cả";
            this.btnTuchoi.TextOffset = new System.Drawing.Point(8, 0);
            this.toolTip1.SetToolTip(this.btnTuchoi, "Hiện tất cả danh sách");
            this.btnTuchoi.Click += new System.EventHandler(this.btnTuchoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 59;
            this.label1.Text = "TRA CỨU SÁCH";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 54);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(59, 18);
            this.guna2HtmlLabel3.TabIndex = 58;
            this.guna2HtmlLabel3.Text = "Tên sách";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(207, 54);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(52, 18);
            this.guna2HtmlLabel2.TabIndex = 57;
            this.guna2HtmlLabel2.Text = "Thể loại";
            // 
            // ccbCate
            // 
            this.ccbCate.AutoRoundedCorners = true;
            this.ccbCate.BackColor = System.Drawing.Color.Transparent;
            this.ccbCate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.ccbCate.BorderRadius = 17;
            this.ccbCate.BorderThickness = 2;
            this.ccbCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccbCate.DropDownHeight = 150;
            this.ccbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCate.DropDownWidth = 150;
            this.ccbCate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ccbCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ccbCate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ccbCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ccbCate.IntegralHeight = false;
            this.ccbCate.ItemHeight = 30;
            this.ccbCate.Location = new System.Drawing.Point(271, 44);
            this.ccbCate.Name = "ccbCate";
            this.ccbCate.Size = new System.Drawing.Size(127, 36);
            this.ccbCate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ccbCate.TabIndex = 56;
            this.toolTip1.SetToolTip(this.ccbCate, "Chọn thể loại");
            this.ccbCate.SelectedIndexChanged += new System.EventHandler(this.ccbCate_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(403, 54);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(49, 18);
            this.guna2HtmlLabel1.TabIndex = 55;
            this.guna2HtmlLabel1.Text = "Tác giả";
            // 
            // ccbAuth
            // 
            this.ccbAuth.AutoRoundedCorners = true;
            this.ccbAuth.BackColor = System.Drawing.Color.Transparent;
            this.ccbAuth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.ccbAuth.BorderRadius = 17;
            this.ccbAuth.BorderThickness = 2;
            this.ccbAuth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccbAuth.DropDownHeight = 150;
            this.ccbAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbAuth.DropDownWidth = 250;
            this.ccbAuth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ccbAuth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ccbAuth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ccbAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ccbAuth.IntegralHeight = false;
            this.ccbAuth.ItemHeight = 30;
            this.ccbAuth.Location = new System.Drawing.Point(467, 44);
            this.ccbAuth.Name = "ccbAuth";
            this.ccbAuth.Size = new System.Drawing.Size(165, 36);
            this.ccbAuth.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ccbAuth.TabIndex = 54;
            this.toolTip1.SetToolTip(this.ccbAuth, "Chọn tác giả");
            this.ccbAuth.SelectedIndexChanged += new System.EventHandler(this.ccbAuth_SelectedIndexChanged);
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.Transparent;
            this.txbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(21)))), ((int)(((byte)(255)))));
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.DefaultText = "";
            this.txbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbName.IconRight = ((System.Drawing.Image)(resources.GetObject("txbName.IconRight")));
            this.txbName.Location = new System.Drawing.Point(78, 44);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.PasswordChar = '\0';
            this.txbName.PlaceholderText = "Tên sách";
            this.txbName.SelectedText = "";
            this.txbName.Size = new System.Drawing.Size(127, 36);
            this.txbName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbName.TabIndex = 53;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // lvLookUp
            // 
            this.lvLookUp.BackColor = System.Drawing.Color.White;
            this.lvLookUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLookUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLookUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLookUp.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lvLookUp.ForeColor = System.Drawing.Color.Indigo;
            this.lvLookUp.FullRowSelect = true;
            this.lvLookUp.HideSelection = false;
            this.lvLookUp.Location = new System.Drawing.Point(0, 101);
            this.lvLookUp.Name = "lvLookUp";
            this.lvLookUp.Size = new System.Drawing.Size(750, 389);
            this.lvLookUp.TabIndex = 49;
            this.lvLookUp.UseCompatibleStateImageBehavior = false;
            this.lvLookUp.View = System.Windows.Forms.View.Details;
            this.lvLookUp.DoubleClick += new System.EventHandler(this.lvLookUp_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thể loại";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác giả";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng thái";
            this.columnHeader6.Width = 80;
            // 
            // LookUpfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LookUpfrm";
            this.Text = "LookUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvLookUp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox ccbAuth;
        private Guna.UI2.WinForms.Guna2TextBox txbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox ccbCate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTuchoi;
    }
}