using EngineeringCoperation.Models; // Mengimpor namespace yang berisi model seperti Member, AuthService, dll.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms
{
    public partial class LoginForm : Form // Membuat class LoginForm yang merupakan turunan dari Form
    {
        public Member? LoggedInUser { get; set; } // Menyimpan data user yang sudah login (bisa null)

        public LoginForm()
        {
            InitializeComponent(); // Menginisialisasi komponen form (auto-generated)
        }

        public void setSuccessAlert(String message) // Method untuk menampilkan pesan sukses
        {
            LblSign.Text = message; // Mengatur teks label LblSign sesuai parameter message
            LblSign.Visible = true; // Menampilkan label agar terlihat di form
        }

        private async void BtnSubmit_Click(object sender, EventArgs e) // Event ketika tombol Submit diklik
        {
            LblSign.Visible = false; // Menyembunyikan label pesan (jika sebelumnya ada pesan)

            using var db = new AppDbContext(); // Membuat objek database context, otomatis dibersihkan setelah selesai
            var auth = new AuthService(db); // Membuat instance dari AuthService untuk proses login

            // Melakukan proses login secara asynchronous dengan username dan password
            // (Catatan: di sini masih ada typo penggunaan TxtBUsername, Text)
            var user = await auth.LoginAsync(TxtBUsername, Text, TxtBPassword.Text);

            if (user != null) // Jika user ditemukan (login berhasil)
            {
                LoggedInUser = user; // Menyimpan data user ke properti LoggedInUser

                if (LoggedInUser.level = "admin") // Mengecek apakah level user adalah admin (Catatan: ini assignment, bukan perbandingan)
                {
                    this.Hide(); // Menyembunyikan form login
                    AdminForm form = new AdminForm(LoggedInUser); // Membuat form Admin baru dan kirim data user yang login
                    form.showDialog(); // Menampilkan form Admin secara modal (menghentikan form lain sementara)
                }
                else // Jika bukan admin
                {
                    AccessService accessService = new AccessService(db); // Membuat service baru untuk mengelola akses user
                    Accessibility access = await accessService.GetAccess(user.id); // Mengecek apakah user memiliki akses (di database)

                    if (access == null) // Jika user tidak memiliki akses
                    {
                        LblSign.Text = "Access Is Not Granted By Admin !"; // Menampilkan pesan error
                        LblSign.ForeColor = Color.Red; // Mengubah warna teks label menjadi merah
                        LblSign.Visible = true; // Menampilkan label pesan
                    }
                    else // Jika user memiliki akses
                    {
                        this.Hide(); // Menyembunyikan form login
                        HomeForm form = new HomeForm(LoggedInUser); // Membuat form Home (beranda) untuk user biasa
                        form.showDialog(); // Menampilkan form Home
                    }
                }
            }
            else // Jika user tidak ditemukan (login gagal)
            {
                LblSign.Text = "Invalid Credentials"; // Menampilkan pesan bahwa login gagal
                LblSign.ForeColor = Color.Red; // Mengatur warna teks pesan menjadi merah
                LblSign.Visible = true; // Menampilkan label pesan error
            }
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Event ketika link “Forgot Password” diklik
        {
            this.Hide(); // Menyembunyikan form login
            ForgotPasswordForm form = new ForgotPasswordForm(); // Membuat form lupa password
            form.ShowDialog(); // Menampilkan form lupa password
        }

        private void BtnReg_Click(object sender, EventArgs e) // Event ketika tombol “Register” diklik
        {
            this.Hide(); // Menyembunyikan form login
            RegistrationForm form = new ForgotPasswordForm(); // Membuat form registrasi (Catatan: masih salah panggil ForgotPasswordForm)
            form.ShowDialog(); // Menampilkan form registrasi
        }

        private void label2_Click(object sender, EventArgs e) // Event ketika label2 diklik (belum diisi fungsinya)
        {

        }
    }
}
