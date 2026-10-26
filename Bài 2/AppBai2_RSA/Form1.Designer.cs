namespace AppBai2_RSA
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.txtPemView = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.btnExportKey = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.txtBenchLog = new System.Windows.Forms.TextBox();
            this.txtCipherBase64 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.lblAvalancheStatus = new System.Windows.Forms.Label();
            this.txtHashResult2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShaInput2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHashResult1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShaInput1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.lblSignNote = new System.Windows.Forms.Label();
            this.txtSignatureBase64 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtDataToSign = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tab4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Controls.Add(this.tab4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.txtPemView);
            this.tab1.Controls.Add(this.panel1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(826, 585);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "1. Quản lý Khóa RSA & Parse PEM";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // txtPemView
            // 
            this.txtPemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPemView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPemView.Location = new System.Drawing.Point(3, 53);
            this.txtPemView.Multiline = true;
            this.txtPemView.Name = "txtPemView";
            this.txtPemView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPemView.Size = new System.Drawing.Size(820, 529);
            this.txtPemView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportKey);
            this.panel1.Controls.Add(this.btnExportKey);
            this.panel1.Controls.Add(this.btnGenerateKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnImportKey
            // 
            this.btnImportKey.Location = new System.Drawing.Point(340, 10);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(180, 30);
            this.btnImportKey.TabIndex = 2;
            this.btnImportKey.Text = "3. Import & View Key XML/PEM";
            this.btnImportKey.UseVisualStyleBackColor = true;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            // 
            // btnExportKey
            // 
            this.btnExportKey.Location = new System.Drawing.Point(170, 10);
            this.btnExportKey.Name = "btnExportKey";
            this.btnExportKey.Size = new System.Drawing.Size(155, 30);
            this.btnExportKey.TabIndex = 1;
            this.btnExportKey.Text = "2. Xuất Khóa Ra File";
            this.btnExportKey.UseVisualStyleBackColor = true;
            this.btnExportKey.Click += new System.EventHandler(this.btnExportKey_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(10, 10);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(145, 30);
            this.btnGenerateKey.TabIndex = 0;
            this.btnGenerateKey.Text = "1. Sinh Cặp Khóa RSA";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.txtBenchLog);
            this.tab2.Controls.Add(this.txtCipherBase64);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.panel2);
            this.tab2.Controls.Add(this.txtInputData);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(826, 585);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "2. Mã hóa / Giải mã & Tốc độ";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // txtBenchLog
            // 
            this.txtBenchLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenchLog.Location = new System.Drawing.Point(16, 220);
            this.txtBenchLog.Multiline = true;
            this.txtBenchLog.Name = "txtBenchLog";
            this.txtBenchLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBenchLog.Size = new System.Drawing.Size(790, 345);
            this.txtBenchLog.TabIndex = 5;
            // 
            // txtCipherBase64
            // 
            this.txtCipherBase64.Location = new System.Drawing.Point(16, 115);
            this.txtCipherBase64.Multiline = true;
            this.txtCipherBase64.Name = "txtCipherBase64";
            this.txtCipherBase64.Size = new System.Drawing.Size(790, 45);
            this.txtCipherBase64.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả Mã hóa (Base64):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBenchmark);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Location = new System.Drawing.Point(16, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 40);
            this.panel2.TabIndex = 4;
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.Location = new System.Drawing.Point(360, 5);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(260, 30);
            this.btnBenchmark.TabIndex = 2;
            this.btnBenchmark.Text = "7. Đo & Đánh giá Tốc độ Mã hóa vs Giải mã";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(170, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(170, 30);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "6. Giải mã & So sánh nguồn";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(0, 5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(155, 30);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "5. Mã hóa Public Key";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(16, 35);
            this.txtInputData.Multiline = true;
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(790, 45);
            this.txtInputData.TabIndex = 1;
            this.txtInputData.Text = "uR8vK2mP9xZ4wQ7yT1vC3bN5mK8jL0pQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ liệu đầu vào (Byte Array <= 190 bytes, ví dụ AES Key 32 bytes):";
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.lblAvalancheStatus);
            this.tab3.Controls.Add(this.txtHashResult2);
            this.tab3.Controls.Add(this.label5);
            this.tab3.Controls.Add(this.txtShaInput2);
            this.tab3.Controls.Add(this.label6);
            this.tab3.Controls.Add(this.txtHashResult1);
            this.tab3.Controls.Add(this.label4);
            this.tab3.Controls.Add(this.txtShaInput1);
            this.tab3.Controls.Add(this.label3);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(826, 585);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "3. Băm SHA-256 & Đánh giá";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // lblAvalancheStatus
            // 
            this.lblAvalancheStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvalancheStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblAvalancheStatus.Location = new System.Drawing.Point(20, 310);
            this.lblAvalancheStatus.Name = "lblAvalancheStatus";
            this.lblAvalancheStatus.Size = new System.Drawing.Size(780, 80);
            this.lblAvalancheStatus.TabIndex = 8;
            this.lblAvalancheStatus.Text = "-> Đánh giá Hiệu ứng Thác Lũ (Avalanche Effect): Hãy thử đổi 1 ký tự ở Đầu vào 2" +
    " để xem sự thay đổi.";
            // 
            // txtHashResult2
            // 
            this.txtHashResult2.ReadOnly = true;
            this.txtHashResult2.Location = new System.Drawing.Point(20, 240);
            this.txtHashResult2.Name = "txtHashResult2";
            this.txtHashResult2.Size = new System.Drawing.Size(780, 20);
            this.txtHashResult2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kết quả băm SHA-256 2:";
            // 
            // txtShaInput2
            // 
            this.txtShaInput2.Location = new System.Drawing.Point(20, 180);
            this.txtShaInput2.Name = "txtShaInput2";
            this.txtShaInput2.Size = new System.Drawing.Size(780, 20);
            this.txtShaInput2.TabIndex = 5;
            this.txtShaInput2.Text = "Hello World RSA 2027";
            this.txtShaInput2.TextChanged += new System.EventHandler(this.txtShaInput2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhập văn bản đầu vào 2 (Thay đổi chỉ 1 ký tự so với Đầu vào 1):";
            // 
            // txtHashResult1
            // 
            this.txtHashResult1.ReadOnly = true;
            this.txtHashResult1.Location = new System.Drawing.Point(20, 95);
            this.txtHashResult1.Name = "txtHashResult1";
            this.txtHashResult1.Size = new System.Drawing.Size(780, 20);
            this.txtHashResult1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết quả băm SHA-256 1:";
            // 
            // txtShaInput1
            // 
            this.txtShaInput1.Location = new System.Drawing.Point(20, 35);
            this.txtShaInput1.Name = "txtShaInput1";
            this.txtShaInput1.Size = new System.Drawing.Size(780, 20);
            this.txtShaInput1.TabIndex = 1;
            this.txtShaInput1.Text = "Hello World RSA 2026";
            this.txtShaInput1.TextChanged += new System.EventHandler(this.txtShaInput1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập văn bản đầu vào 1:";
            // 
            // tab4
            // 
            this.tab4.Controls.Add(this.lblSignNote);
            this.tab4.Controls.Add(this.txtSignatureBase64);
            this.tab4.Controls.Add(this.label8);
            this.tab4.Controls.Add(this.btnSign);
            this.tab4.Controls.Add(this.txtDataToSign);
            this.tab4.Controls.Add(this.label7);
            this.tab4.Location = new System.Drawing.Point(4, 22);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(826, 585);
            this.tab4.TabIndex = 3;
            this.tab4.Text = "4. Chữ ký số (Salt/PSS)";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // lblSignNote
            // 
            this.lblSignNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignNote.ForeColor = System.Drawing.Color.Green;
            this.lblSignNote.Location = new System.Drawing.Point(20, 230);
            this.lblSignNote.Name = "lblSignNote";
            this.lblSignNote.Size = new System.Drawing.Size(780, 100);
            this.lblSignNote.TabIndex = 5;
            this.lblSignNote.Text = "-> Thử nghiệm: Nhấn nút Ký Số nhiều lần với cùng 1 dữ liệu đầu vào. Chữ ký số sẽ" +
    " đổi mới liên tục nhờ cơ chế Salt ngẫu nhiên.";
            // 
            // txtSignatureBase64
            // 
            this.txtSignatureBase64.Location = new System.Drawing.Point(20, 140);
            this.txtSignatureBase64.Multiline = true;
            this.txtSignatureBase64.Name = "txtSignatureBase64";
            this.txtSignatureBase64.Size = new System.Drawing.Size(780, 45);
            this.txtSignatureBase64.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chữ ký số tạo ra (Base64):";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(20, 70);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(220, 35);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Ký Số Dữ Liệu (Private Key + Salt)";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtDataToSign
            // 
            this.txtDataToSign.Location = new System.Drawing.Point(20, 35);
            this.txtDataToSign.Name = "txtDataToSign";
            this.txtDataToSign.Size = new System.Drawing.Size(780, 20);
            this.txtDataToSign.TabIndex = 1;
            this.txtDataToSign.Text = "Van ban hop dong can ky so - 2026";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dữ liệu văn bản cần ký:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2: Mã hóa RSA, SHA-256 & Chữ ký số (.NET)";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.tab4.ResumeLayout(false);
            this.tab4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.TabPage tab4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportKey;
        private System.Windows.Forms.Button btnExportKey;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox txtPemView;
        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCipherBase64;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtBenchLog;
        private System.Windows.Forms.TextBox txtShaInput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHashResult1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHashResult2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShaInput2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvalancheStatus;
        private System.Windows.Forms.TextBox txtDataToSign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox txtSignatureBase64;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSignNote;
    }
}