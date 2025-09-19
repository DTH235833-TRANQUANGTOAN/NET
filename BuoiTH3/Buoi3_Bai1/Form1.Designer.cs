namespace Buoi3_Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new Label();
            txtPass = new Label();
            chkNho = new CheckBox();
            btnDangnhap = new Button();
            btnXoa = new Button();
            btnDung = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.Location = new Point(139, 132);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(129, 25);
            txtUser.TabIndex = 0;
            txtUser.Text = "Tên đăng nhập";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Location = new Point(139, 181);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(86, 25);
            txtPass.TabIndex = 1;
            txtPass.Text = "Mật khẩu";
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(139, 224);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(100, 29);
            chkNho.TabIndex = 2;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(139, 279);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(112, 34);
            btnDangnhap.TabIndex = 3;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 279);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(289, 279);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(112, 34);
            btnDung.TabIndex = 5;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnDangnhap);
            Controls.Add(chkNho);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUser;
        private Label txtPass;
        private CheckBox chkNho;
        private Button btnDangnhap;
        private Button btnXoa;
        private Button btnDung;
    }
}
