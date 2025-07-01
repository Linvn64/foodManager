namespace foodPetManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtTendn = new MaskedTextBox();
            txtMatkhau = new MaskedTextBox();
            label3 = new Label();
            btnDangnhap = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // txtTendn
            // 
            txtTendn.Location = new Point(101, 190);
            txtTendn.Name = "txtTendn";
            txtTendn.Size = new Size(164, 27);
            txtTendn.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(101, 236);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(164, 27);
            txtMatkhau.TabIndex = 3;
            txtMatkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 123);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 6;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.PaleTurquoise;
            btnDangnhap.ForeColor = SystemColors.ControlText;
            btnDangnhap.Location = new Point(121, 296);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(114, 29);
            btnDangnhap.TabIndex = 4;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(121, 331);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.petshop_logo_template_vector;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(350, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 521);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.user;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(60, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(31, 26);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.locked_computer;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(60, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(31, 26);
            panel3.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(783, 565);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnDangnhap);
            Controls.Add(btnThoat);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox txtTendn;
        private MaskedTextBox txtMatkhau;
        private Button btnThoat;
        private Button btnDangnhap;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}