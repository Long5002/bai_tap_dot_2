import os
import time
import tkinter as tk
from tkinter import filedialog, messagebox, ttk
from cryptography.hazmat.primitives.ciphers.aead import AESGCM

class AESApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Ứng dụng Mã hóa / Giải mã AES-256")
        self.root.geometry("650x600")
        self.key = None

        # Giao diện chính
        title_label = tk.Label(root, text="BÀI TẬP MÃ HÓA AES", font=("Arial", 16, "bold"), fg="blue")
        title_label.pack(pady=10)

        # 1. Khung quản lý Khóa AES
        frame_key = tk.LabelFrame(root, text=" 1. Quản lý Khóa AES ", font=("Arial", 11, "bold"), padx=10, pady=10)
        frame_key.pack(fill="x", padx=15, pady=5)

        btn_gen_key = tk.Button(frame_key, text="Sinh Khóa Mới", command=self.generate_key, bg="#4CAF50", fg="white", font=("Arial", 9, "bold"))
        btn_gen_key.pack(side="left", padx=5)

        btn_save_key = tk.Button(frame_key, text="Lưu Khóa Ra File", command=self.save_key, bg="#2196F3", fg="white")
        btn_save_key.pack(side="left", padx=5)

        btn_load_key = tk.Button(frame_key, text="Import Khóa Từ File", command=self.load_key, bg="#FF9800", fg="white")
        btn_load_key.pack(side="left", padx=5)

        self.lbl_key_status = tk.Label(frame_key, text="Trạng thái: Chưa có khóa", fg="red")
        self.lbl_key_status.pack(side="left", padx=10)

        # 2. Khung mã hóa Văn bản
        frame_text = tk.LabelFrame(root, text=" 2. Mã hóa / Giải mã Văn bản ", font=("Arial", 11, "bold"), padx=10, pady=10)
        frame_text.pack(fill="x", padx=15, pady=5)

        tk.Label(frame_text, text="Văn bản gốc:").grid(row=0, column=0, sticky="w")
        self.txt_input = tk.Entry(frame_text, width=50)
        self.txt_input.grid(row=0, column=1, padx=5, pady=5)

        btn_encrypt_text = tk.Button(frame_text, text="Mã hóa", command=self.encrypt_text)
        btn_encrypt_text.grid(row=0, column=2, padx=5)

        tk.Label(frame_text, text="Kết quả (Hex):").grid(row=1, column=0, sticky="w")
        self.txt_output = tk.Entry(frame_text, width=50)
        self.txt_output.grid(row=1, column=1, padx=5, pady=5)

        btn_decrypt_text = tk.Button(frame_text, text="Giải mã", command=self.decrypt_text)
        btn_decrypt_text.grid(row=1, column=2, padx=5)

        # 3. Khung thử nghiệm File dung lượng lớn
        frame_file = tk.LabelFrame(root, text=" 3. Thử nghiệm File Dung lượng lớn (GB) ", font=("Arial", 11, "bold"), padx=10, pady=10)
        frame_file.pack(fill="both", expand=True, padx=15, pady=5)

        btn_select_file = tk.Button(frame_file, text="Chọn File Nguồn...", command=self.select_file, bg="#673AB7", fg="white")
        btn_select_file.pack(anchor="w", pady=5)

        self.lbl_file_path = tk.Label(frame_file, text="File đã chọn: Chưa chọn file", fg="gray")
        self.lbl_file_path.pack(anchor="w")

        btn_run_test = tk.Button(frame_file, text="BẮT ĐẦU CHẠY MÃ HÓA & GIẢI MÃ FILE", command=self.run_file_test, bg="#E91E63", fg="white", font=("Arial", 10, "bold"))
        btn_run_test.pack(fill="x", pady=10)

        # Khu vực hiển thị kết quả đo đạc & so sánh bytes
        self.txt_log = tk.Text(frame_file, height=8, width=70)
        self.txt_log.pack(fill="both", expand=True)

    def log(self, message):
        self.txt_log.insert(tk.END, message + "\n")
        self.txt_log.see(tk.END)

    def generate_key(self):
        self.key = AESGCM.generate_key(bit_length=256)
        self.lbl_key_status.config(text="Trạng thái: Đã có khóa AES-256", fg="green")
        messagebox.showinfo("Thành công", "Đã sinh khóa AES 256-bit mới!")

    def save_key(self):
        if not self.key:
            messagebox.showwarning("Cảnh báo", "Vui lòng sinh khóa trước!")
            return
        filepath = filedialog.asksaveasfilename(defaultextension=".key", filetypes=[("Key Files", "*.key")])
        if filepath:
            with open(filepath, "wb") as f:
                f.write(self.key)
            messagebox.showinfo("Thành công", f"Đã lưu khóa tại: {filepath}")

    def load_key(self):
        filepath = filedialog.askopenfilename(filetypes=[("Key Files", "*.key"), ("All Files", "*.*")])
        if filepath:
            with open(filepath, "rb") as f:
                self.key = f.read()
            self.lbl_key_status.config(text="Trạng thái: Đã Nạp Khóa", fg="green")
            messagebox.showinfo("Thành công", "Đã import khóa từ file thành công!")

    def encrypt_text(self):
        if not self.key:
            messagebox.showwarning("Cảnh báo", "Chưa có khóa AES!")
            return
        text = self.txt_input.get()
        if not text:
            return
        aesgcm = AESGCM(self.key)
        nonce = os.urandom(12)
        ciphertext = nonce + aesgcm.encrypt(nonce, text.encode('utf-8'), None)
        self.txt_output.delete(0, tk.END)
        self.txt_output.insert(0, ciphertext.hex())

    def decrypt_text(self):
        if not self.key:
            messagebox.showwarning("Cảnh báo", "Chưa có khóa AES!")
            return
        try:
            ciphertext = bytes.fromhex(self.txt_output.get())
            nonce = ciphertext[:12]
            data = ciphertext[12:]
            aesgcm = AESGCM(self.key)
            decrypted = aesgcm.decrypt(nonce, data, None).decode('utf-8')
            messagebox.showinfo("Kết quả giải mã", f"Nội dung: {decrypted}")
        except Exception as e:
            messagebox.showerror("Lỗi", "Giải mã thất bại! Kiểm tra lại khóa hoặc chuỗi hex.")

    def select_file(self):
        filename = filedialog.askopenfilename()
        if filename:
            self.selected_file = filename
            self.lbl_file_path.config(text=f"File đã chọn: {filename}", fg="black")

    def run_file_test(self):
        if not self.key:
            messagebox.showwarning("Cảnh báo", "Vui lòng sinh/nạp khóa trước!")
            return
        if not hasattr(self, 'selected_file') or not self.selected_file:
            messagebox.showwarning("Cảnh báo", "Vui lòng chọn file!")
            return

        inp_file = self.selected_file
        enc_file = inp_file + ".enc"
        dec_file = inp_file + ".dec"
        aesgcm = AESGCM(self.key)

        self.txt_log.delete('1.0', tk.END)
        self.log("=== BẮT ĐẦU THỬ NGHIỆM ===")
        size_mb = os.path.getsize(inp_file) / (1024 * 1024)
        self.log(f"-> Dung lượng file: {size_mb:.2f} MB")

        # 1. Mã hóa File
        self.log("-> Đang mã hóa...")
        t0 = time.time()
        nonce = os.urandom(12)
        with open(inp_file, "rb") as f_in:
            data = f_in.read()
        ciphertext = nonce + aesgcm.encrypt(nonce, data, None)
        with open(enc_file, "wb") as f_out:
            f_out.write(ciphertext)
        t_enc = time.time() - t0
        self.log(f"   [OK] Mã hóa hoàn tất trong: {t_enc:.4f} giây ({size_mb/t_enc:.2f} MB/s)")

        # 2. Giải mã File
        self.log("-> Đang giải mã...")
        t0 = time.time()
        with open(enc_file, "rb") as f_in:
            c_data = f_in.read()
        n = c_data[:12]
        c = c_data[12:]
        decrypted_data = aesgcm.decrypt(n, c, None)
        with open(dec_file, "wb") as f_out:
            f_out.write(decrypted_data)
        t_dec = time.time() - t0
        self.log(f"   [OK] Giải mã hoàn tất trong: {t_dec:.4f} giây ({size_mb/t_dec:.2f} MB/s)")

        # 3. Compare theo Bytes
        self.log("-> So sánh File nguồn và File giải mã theo Byte...")
        with open(inp_file, "rb") as f1, open(dec_file, "rb") as f2:
            if f1.read() == f2.read():
                self.log("=> KHỚP 100%: Hai file hoàn toàn trùng khớp từng byte!")
            else:
                self.log("=> LỖI: Hai file không giống nhau!")

        self.log("\n=== KẾT LUẬN ===")
        self.log(f"Thuật toán AES-256 (GCM mode) cho tốc độ xử lý nhanh, đảm bảo toàn vẹn dữ liệu gốc sau khi giải mã.")

if __name__ == "__main__":
    root = tk.Tk()
    app = AESApp(root)
    root.mainloop()