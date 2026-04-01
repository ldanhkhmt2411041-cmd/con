namespace appSkincare
{
    partial class FormMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            pnlMenu = new Panel();
            imageList1 = new ImageList(components);
            btnThoat = new Button();
            btnThongKe = new Button();
            btnSanPham = new Button();
            btnRoutine = new Button();
            btnMenu = new Button();
            pnlScreen = new Panel();
            pnlAccountMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblAccountName = new Label();
            btnDangXuat = new Button();
            imageList2 = new ImageList(components);
            panelMenu = new Panel();
            pbAccount = new PictureBox();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlScreen.SuspendLayout();
            pnlAccountMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccount).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Teal;
            pnlMenu.Controls.Add(btnThoat);
            pnlMenu.Controls.Add(btnThongKe);
            pnlMenu.Controls.Add(btnSanPham);
            pnlMenu.Controls.Add(btnRoutine);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(6, 6, 6, 6);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(371, 1536);
            pnlMenu.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "sp-removebg-preview.png");
            imageList1.Images.SetKeyName(1, "thống_kê-removebg-preview.png");
            imageList1.Images.SetKeyName(2, "lịch-removebg-preview.png");
            imageList1.Images.SetKeyName(3, "exit-icon-png-close-0-removebg-preview.png");
            imageList1.Images.SetKeyName(4, "824792-removebg-preview (1).png");
            imageList1.Images.SetKeyName(5, "Hamburger_icon.svg-removebg-preview (1).png");
            imageList1.Images.SetKeyName(6, "skincare-removebg-preview.png");
            imageList1.Images.SetKeyName(7, "Hamburger_icon.svg-removebg-preview (1).png");
            imageList1.Images.SetKeyName(8, "exit-icon-png-close-0-removebg-preview.png");
            imageList1.Images.SetKeyName(9, "thống_kê-removebg-preview.png");
            imageList1.Images.SetKeyName(10, "lịch-removebg-preview.png");
            imageList1.Images.SetKeyName(11, "707675-removebg-preview.png");
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.CadetBlue;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ButtonFace;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.ImageIndex = 8;
            btnThoat.ImageList = imageList1;
            btnThoat.Location = new Point(0, 1393);
            btnThoat.Margin = new Padding(6, 6, 6, 6);
            btnThoat.MinimumSize = new Size(0, 128);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(28, 0, 0, 0);
            btnThoat.Size = new Size(384, 143);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ButtonFace;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.ImageIndex = 9;
            btnThongKe.ImageList = imageList1;
            btnThongKe.Location = new Point(0, 1004);
            btnThongKe.Margin = new Padding(6, 6, 6, 6);
            btnThongKe.MinimumSize = new Size(0, 128);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(28, 0, 0, 0);
            btnThongKe.Size = new Size(384, 132);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "TRA CỨU";
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click_1;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSanPham.ForeColor = SystemColors.ButtonFace;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.ImageIndex = 6;
            btnSanPham.ImageList = imageList1;
            btnSanPham.Location = new Point(-19, 663);
            btnSanPham.Margin = new Padding(6, 6, 6, 6);
            btnSanPham.MinimumSize = new Size(0, 128);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(37, 0, 0, 0);
            btnSanPham.Size = new Size(403, 147);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "SẢN PHẨM";
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click_1;
            // 
            // btnRoutine
            // 
            btnRoutine.BackColor = Color.Teal;
            btnRoutine.FlatAppearance.BorderSize = 0;
            btnRoutine.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnRoutine.FlatStyle = FlatStyle.Flat;
            btnRoutine.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRoutine.ForeColor = SystemColors.ButtonFace;
            btnRoutine.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoutine.ImageIndex = 10;
            btnRoutine.ImageList = imageList1;
            btnRoutine.Location = new Point(0, 309);
            btnRoutine.Margin = new Padding(6, 6, 6, 6);
            btnRoutine.MinimumSize = new Size(0, 128);
            btnRoutine.Name = "btnRoutine";
            btnRoutine.Padding = new Padding(28, 0, 0, 0);
            btnRoutine.Size = new Size(377, 143);
            btnRoutine.TabIndex = 1;
            btnRoutine.Text = "ROUTINE";
            btnRoutine.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoutine.UseVisualStyleBackColor = false;
            btnRoutine.Click += btnRoutine_Click_1;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.CadetBlue;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMenu.ForeColor = SystemColors.ButtonFace;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.ImageIndex = 7;
            btnMenu.ImageList = imageList1;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(6, 6, 6, 6);
            btnMenu.MinimumSize = new Size(0, 128);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(46, 0, 0, 0);
            btnMenu.Size = new Size(371, 128);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "MENU";
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlScreen
            // 
            pnlScreen.BackColor = Color.WhiteSmoke;
            pnlScreen.Controls.Add(pnlAccountMenu);
            pnlScreen.Controls.Add(panelMenu);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(371, 0);
            pnlScreen.Margin = new Padding(6, 6, 6, 6);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(2006, 1536);
            pnlScreen.TabIndex = 3;
            // 
            // pnlAccountMenu
            // 
            pnlAccountMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAccountMenu.BackColor = Color.FloralWhite;
            pnlAccountMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlAccountMenu.Controls.Add(pictureBox1);
            pnlAccountMenu.Controls.Add(lblAccountName);
            pnlAccountMenu.Controls.Add(btnDangXuat);
            pnlAccountMenu.Location = new Point(1705, 134);
            pnlAccountMenu.Margin = new Padding(6, 6, 6, 6);
            pnlAccountMenu.Name = "pnlAccountMenu";
            pnlAccountMenu.Size = new Size(294, 484);
            pnlAccountMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.OnePiece_Monkey_D_Luffy_1024x819_removebg_preview;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-82, -2);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblAccountName
            // 
            lblAccountName.AutoEllipsis = true;
            lblAccountName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(-2, 201);
            lblAccountName.Margin = new Padding(6, 0, 6, 0);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(295, 45);
            lblAccountName.TabIndex = 3;
            lblAccountName.Text = "TEXT";
            lblAccountName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Gainsboro;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.Black;
            btnDangXuat.ImageIndex = 0;
            btnDangXuat.ImageList = imageList2;
            btnDangXuat.Location = new Point(41, 399);
            btnDangXuat.Margin = new Padding(6, 6, 6, 6);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(217, 77);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "exit-icon-png-close-0-removebg-preview.png");
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CadetBlue;
            panelMenu.Controls.Add(pbAccount);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(6, 6, 6, 6);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(2006, 128);
            panelMenu.TabIndex = 0;
            // 
            // pbAccount
            // 
            pbAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAccount.Cursor = Cursors.Hand;
            pbAccount.ErrorImage = null;
            pbAccount.Image = Properties.Resources.OnePiece_Monkey_D_Luffy_1024x819_removebg_preview;
            pbAccount.InitialImage = null;
            pbAccount.Location = new Point(1788, 0);
            pbAccount.Margin = new Padding(6, 6, 6, 6);
            pbAccount.Name = "pbAccount";
            pbAccount.Size = new Size(195, 128);
            pbAccount.SizeMode = PictureBoxSizeMode.Zoom;
            pbAccount.TabIndex = 1;
            pbAccount.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.CadetBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(2006, 128);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÝ LỊCH TRÌNH SKINCARE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2377, 1536);
            Controls.Add(pnlScreen);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lịch trình Skincare";
            Load += FormMenu_Load;
            pnlMenu.ResumeLayout(false);
            pnlScreen.ResumeLayout(false);
            pnlAccountMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnThoat;
        private Button btnThongKe;
        private Button btnSanPham;
        private Button btnRoutine;
        private Panel pnlScreen;
        private ImageList imageList1;
        private Button btnMenu;
        private Panel panelMenu;
        private Label label1;
        private PictureBox pbAccount;
        private Panel pnlAccountMenu;
        private Button btnDangXuat;
        private Label lblAccountName;
        private PictureBox pictureBox1;
        private ImageList imageList2;
    }
}