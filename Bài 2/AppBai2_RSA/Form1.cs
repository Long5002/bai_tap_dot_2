using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AppBai2_RSA
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
            rsa = new RSACryptoServiceProvider(2048);
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider(2048);
            MessageBox.Show("Đã sinh cặp khóa RSA 2048-bit thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportKey_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string pubKeyXml = rsa.ToXmlString(false);
                string privKeyXml = rsa.ToXmlString(true);

                File.WriteAllText(Path.Combine(fbd.SelectedPath, "public_key.xml"), pubKeyXml);
                File.WriteAllText(Path.Combine(fbd.SelectedPath, "private_key.xml"), privKeyXml);

                MessageBox.Show($"Đã xuất bộ khóa ra thư mục:\n{fbd.SelectedPath}", "Thành công");
            }
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Key Files (*.xml;*.pem)|*.xml;*.pem|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string keyContent = File.ReadAllText(ofd.FileName);
                txtPemView.Clear();
                txtPemView.AppendText($"=== ĐỌC CẤU TRÚC FILE KHÓA: {ofd.FileName} ===\r\n\r\n");

                try
                {
                    rsa.FromXmlString(keyContent);
                    RSAParameters p = rsa.ExportParameters(!rsa.PublicOnly);

                    txtPemView.AppendText($"[LOẠI KHÓA]: {(rsa.PublicOnly ? "PUBLIC KEY" : "PRIVATE KEY")}\r\n\r\n");
                    txtPemView.AppendText($"1. Modulus (n) [{p.Modulus.Length * 8} bits]:\r\n{Convert.ToBase64String(p.Modulus)}\r\n\r\n");
                    txtPemView.AppendText($"2. Public Exponent (e) [Thường là 65537 - Public key e nhỏ để mã hóa nhanh]:\r\n{Convert.ToBase64String(p.Exponent)}\r\n\r\n");

                    if (!rsa.PublicOnly)
                    {
                        txtPemView.AppendText($"3. Private Exponent (d) [Số bí mật to đùng để giải mã/ký số]:\r\n{Convert.ToBase64String(p.D)}\r\n\r\n");
                        txtPemView.AppendText($"4. Prime 1 (p):\r\n{Convert.ToBase64String(p.P)}\r\n\r\n");
                        txtPemView.AppendText($"5. Prime 2 (q):\r\n{Convert.ToBase64String(p.Q)}\r\n\r\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file khóa: " + ex.Message);
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(txtInputData.Text);
            if (inputBytes.Length > 190)
            {
                MessageBox.Show("Dữ liệu quá lớn! RSA 2048-bit chỉ mã hóa tối đa 190 bytes.");
                return;
            }

            byte[] cipherBytes = rsa.Encrypt(inputBytes, true);
            txtCipherBase64.Text = Convert.ToBase64String(cipherBytes);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(txtCipherBase64.Text);
                byte[] decryptedBytes = rsa.Decrypt(cipherBytes, true);
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                bool isMatch = (decryptedText == txtInputData.Text);
                MessageBox.Show($"Nội dung giải mã: {decryptedText}\n\nSo sánh với nguồn gốc: {(isMatch ? "KHỚP 100%" : "KHÔNG KHỚP")}", "Kết quả giải mã");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giải mã thất bại: " + ex.Message);
            }
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu RSA chưa khởi tạo thì khởi tạo mới
                if (rsa == null)
                {
                    rsa = new RSACryptoServiceProvider(2048);
                }

                byte[] dummyData = Encoding.UTF8.GetBytes("KeyAES_256bit_Sample_Data_32bytes");
                int iterations = 100;

                // 1. Đo tốc độ Mã hóa (Public Key)
                Stopwatch swEnc = Stopwatch.StartNew();
                byte[] cipher = null;
                for (int i = 0; i < iterations; i++)
                {
                    cipher = rsa.Encrypt(dummyData, true);
                }
                swEnc.Stop();
                double avgEncMs = swEnc.Elapsed.TotalMilliseconds / iterations;

                // 2. Đo tốc độ Giải mã (Private Key)
                Stopwatch swDec = Stopwatch.StartNew();
                for (int i = 0; i < iterations; i++)
                {
                    rsa.Decrypt(cipher, true);
                }
                swDec.Stop();
                double avgDecMs = swDec.Elapsed.TotalMilliseconds / iterations;

                // 3. Hiển thị kết quả ra màn hình
                txtBenchLog.Clear();
                txtBenchLog.AppendText("=== ĐÁNH GIÁ TỐC ĐỘ RSA (THỰC THI 100 LẦN) ===\r\n\r\n");
                txtBenchLog.AppendText($"- Thời gian Mã hóa trung bình (Public Key - e nhỏ): {avgEncMs:F4} ms\r\n");
                txtBenchLog.AppendText($"- Thời gian Giải mã trung bình (Private Key - d lớn): {avgDecMs:F4} ms\r\n\r\n");
                txtBenchLog.AppendText("=> KẾT LUẬN TOÁN HỌC:\r\n");
                txtBenchLog.AppendText($"Mã hóa bằng Public Key NHANH HƠN Giải mã bằng Private Key khoảng {(avgDecMs / avgEncMs):F1} lần!\r\n\r\n");
                txtBenchLog.AppendText("Nguyên nhân: Public Exponent (e = 65537) rất nhỏ nên số phép nhân tính lũy thừa c = m^e mod n tốn rất ít thời gian CPU. Trong khi Private Exponent (d) là số cực kỳ lớn nên phép m = c^d mod n tốn nhiều tài nguyên hơn rất nhiều.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đo tốc độ: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtShaInput1_TextChanged(object sender, EventArgs e)
        {
            txtHashResult1.Text = ComputeSHA256(txtShaInput1.Text);
            CompareHashes();
        }

        private void txtShaInput2_TextChanged(object sender, EventArgs e)
        {
            txtHashResult2.Text = ComputeSHA256(txtShaInput2.Text);
            CompareHashes();
        }

        private string ComputeSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void CompareHashes()
        {
            if (string.IsNullOrEmpty(txtHashResult1.Text) || string.IsNullOrEmpty(txtHashResult2.Text)) return;

            int diffBits = 0;
            byte[] h1 = Encoding.UTF8.GetBytes(txtHashResult1.Text);
            byte[] h2 = Encoding.UTF8.GetBytes(txtHashResult2.Text);

            for (int i = 0; i < Math.Min(h1.Length, h2.Length); i++)
            {
                if (h1[i] != h2[i]) diffBits++;
            }

            lblAvalancheStatus.Text = $"-> Đánh giá Hiệu ứng Thác Lũ (Avalanche Effect): Dù chỉ thay đổi 1 ký tự, kết quả băm thay đổi {diffBits}/{h1.Length} vị trí mã Hex (hoàn toàn khác biệt).";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(txtDataToSign.Text);

            byte[] salt = new byte[8];
            RandomNumberGenerator.Create().GetBytes(salt);

            byte[] dataWithSalt = new byte[data.Length + salt.Length];
            Buffer.BlockCopy(data, 0, dataWithSalt, 0, data.Length);
            Buffer.BlockCopy(salt, 0, dataWithSalt, data.Length, salt.Length);

            byte[] signature = rsa.SignData(dataWithSalt, CryptoConfig.MapNameToOID("SHA256"));

            byte[] finalSignaturePackage = new byte[salt.Length + signature.Length];
            Buffer.BlockCopy(salt, 0, finalSignaturePackage, 0, salt.Length);
            Buffer.BlockCopy(signature, 0, finalSignaturePackage, salt.Length, signature.Length);

            txtSignatureBase64.Text = Convert.ToBase64String(finalSignaturePackage);
            lblSignNote.Text = "-> Đã tạo chữ ký số mới thành công! (Thử bấm nút Ký lần nữa, chữ ký Base64 sẽ đổi mới hoàn toàn nhờ cơ chế Salt).";
        }
    }
}