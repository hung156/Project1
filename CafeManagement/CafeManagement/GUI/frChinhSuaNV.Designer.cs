﻿namespace CafeManagement.GUI
{
    partial class frChinhSuaNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frChinhSuaNV));
            this.bttThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtChucVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bttCapNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttThoat
            // 
            this.bttThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttThoat.ImageOptions.Image")));
            this.bttThoat.Location = new System.Drawing.Point(209, 264);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(94, 36);
            this.bttThoat.TabIndex = 65;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Quê quán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Họ tên:";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(116, 218);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(187, 22);
            this.dtpNgayVaoLam.TabIndex = 56;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 189);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(186, 22);
            this.dtpNgaySinh.TabIndex = 55;
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Location = new System.Drawing.Point(14, 218);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(98, 17);
            this.lbNgayVaoLam.TabIndex = 54;
            this.lbNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(38, 189);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(75, 17);
            this.lbNgaySinh.TabIndex = 53;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(116, 161);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(187, 22);
            this.txtCMND.TabIndex = 52;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(116, 133);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(125, 22);
            this.txtSDT.TabIndex = 51;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(116, 77);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(125, 22);
            this.txtQueQuan.TabIndex = 50;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(116, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(125, 22);
            this.txtHoTen.TabIndex = 48;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(116, 105);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChucVu.Properties.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.txtChucVu.Size = new System.Drawing.Size(125, 22);
            this.txtChucVu.TabIndex = 49;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 13);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(230, 23);
            this.labelControl6.TabIndex = 47;
            this.labelControl6.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttCapNhat.ImageOptions.Image")));
            this.bttCapNhat.Location = new System.Drawing.Point(12, 264);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(186, 36);
            this.bttCapNhat.TabIndex = 64;
            this.bttCapNhat.Text = "Cập Nhật Thông Tin";
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // frChinhSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 316);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttCapNhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lbNgayVaoLam);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.labelControl6);
            this.Name = "frChinhSuaNV";
            this.Text = "Cập nhật thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bttThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.Label lbNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtQueQuan;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.ComboBoxEdit txtChucVu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton bttCapNhat;
    }
}