namespace appSkincare
{
    partial class FormDangKy
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
            pnlScreen = new Panel();
            pnlLine1 = new Panel();
            ckbHienMatKhau = new CheckBox();
            lnkDangNhap = new LinkLabel();
            panel1 = new Panel();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            btnThoat = new Button();
            btnDangKy = new Button();
            pnlLine2 = new Panel();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            lblTaiKhoan = new Label();
            lblTitle = new Label();
            pnlLeft = new Panel();
            lblWelcome = new Label();
            pnlScreen.SuspendLayout();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.White;
            pnlScreen.Controls.Add(pnlLine1);
            pnlScreen.Controls.Add(ckbHienMatKhau);
            pnlScreen.Controls.Add(lnkDangNhap);
            pnlScreen.Controls.Add(panel1);
            pnlScreen.Controls.Add(txtHoTen);
            pnlScreen.Controls.Add(lblHoTen);
            pnlScreen.Controls.Add(btnThoat);
            pnlScreen.Controls.Add(btnDangKy);
            pnlScreen.Controls.Add(pnlLine2);
            pnlScreen.Controls.Add(txtMatKhau);
            pnlScreen.Controls.Add(lblMatKhau);
            pnlScreen.Controls.Add(txtTaiKhoan);
            pnlScreen.Controls.Add(lblTaiKhoan);
            pnlScreen.Controls.Add(lblTitle);
            pnlScreen.Controls.Add(pnlLeft);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Margin = new Padding(6, 6, 6, 6);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(1492, 988);
            pnlScreen.TabIndex = 1;
            // 
            // pnlLine1
            // 
            pnlLine1.BackColor = Color.FromArgb(24, 119, 242);
            pnlLine1.Location = new Point(765, 275);
            pnlLine1.Margin = new Padding(6, 6, 6, 6);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(594, 4);
            pnlLine1.TabIndex = 4;
            // 
            // ckbHienMatKhau
            // 
            ckbHienMatKhau.AutoSize = true;
            ckbHienMatKhau.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbHienMatKhau.ForeColor = Color.Gray;
            ckbHienMatKhau.Location = new Point(765, 676);
            ckbHienMatKhau.Margin = new Padding(6, 6, 6, 6);
            ckbHienMatKhau.Name = "ckbHienMatKhau";
            ckbHienMatKhau.Padding = new Padding(0, 11, 0, 0);
            ckbHienMatKhau.Size = new Size(196, 45);
            ckbHienMatKhau.TabIndex = 15;
            ckbHienMatKhau.Text = "Hiện mật khẩu";
            ckbHienMatKhau.UseVisualStyleBackColor = true;
            ckbHienMatKhau.CheckedChanged += ckbHienMatKhau_CheckedChanged;
            // 
            // lnkDangNhap
            // 
            lnkDangNhap.AutoSize = true;
            lnkDangNhap.LinkColor = Color.FromArgb(24, 119, 242);
            lnkDangNhap.Location = new Point(765, 883);
            lnkDangNhap.Margin = new Padding(6, 0, 6, 0);
            lnkDangNhap.Name = "lnkDangNhap";
            lnkDangNhap.Size = new Size(317, 32);
            lnkDangNhap.TabIndex = 12;
            lnkDangNhap.TabStop = true;
            lnkDangNhap.Text = "Đã có tài khoản? Đăng nhập";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 119, 242);
            panel1.Location = new Point(765, 659);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 4);
            panel1.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.None;
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(761, 233);
            txtHoTen.Margin = new Padding(6, 6, 6, 6);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(594, 43);
            txtHoTen.TabIndex = 11;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.Gray;
            lblHoTen.Location = new Point(765, 191);
            lblHoTen.Margin = new Padding(6, 0, 6, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(196, 36);
            lblHoTen.TabIndex = 10;
            lblHoTen.Text = "Tên đăng nhập";
            // 
            // btnThoat
            // 
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.DarkGray;
            btnThoat.Location = new Point(1411, 11);
            btnThoat.Margin = new Padding(6, 6, 6, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(65, 75);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "X";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(24, 119, 242);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(761, 757);
            btnDangKy.Margin = new Padding(6, 6, 6, 6);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(594, 96);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Register";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.FromArgb(24, 119, 242);
            pnlLine2.Location = new Point(765, 480);
            pnlLine2.Margin = new Padding(6, 6, 6, 6);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(594, 4);
            pnlLine2.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(765, 617);
            txtMatKhau.Margin = new Padding(6, 6, 6, 6);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(594, 43);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.Gray;
            lblMatKhau.Location = new Point(766, 575);
            lblMatKhau.Margin = new Padding(6, 0, 6, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(132, 36);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.Location = new Point(765, 441);
            txtTaiKhoan.Margin = new Padding(6, 6, 6, 6);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(594, 43);
            txtTaiKhoan.TabIndex = 3;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = Color.Gray;
            lblTaiKhoan.Location = new Point(765, 399);
            lblTaiKhoan.Margin = new Padding(6, 0, 6, 0);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(133, 36);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(858, 0);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 118);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "\r\nĐĂNG KÝ TÀI KHOẢN";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(24, 119, 242);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(6, 6, 6, 6);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(650, 988);
            pnlLeft.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(0, 341);
            lblWelcome.Margin = new Padding(6, 0, 6, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(650, 213);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME TO\r\nSKINCARE APP";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 988);
            Controls.Add(pnlScreen);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            pnlScreen.ResumeLayout(false);
            pnlScreen.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlScreen;
        private Button btnThoat;
        private Button btnDangKy;
        private Panel pnlLine2;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Panel pnlLine1;
        private TextBox txtTaiKhoan;
        private Label lblTaiKhoan;
        private Label lblTitle;
        private Panel pnlLeft;
        private Label lblWelcome;
        private Panel panel1;
        private TextBox txtHoTen;
        private Label lblHoTen;
        private LinkLabel lnkDangNhap;
        private CheckBox ckbHienMatKhau;
    }
}