using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginnowButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Dispose();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ageTextBox.Text.Trim(), out int ageValue))
            {
                MessageBox.Show("Lütfen yaş alanına geçerli bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ageTextBox.Focus();
                return;
            }
            SqlConnection con = null;
            try
            {
                string query = "INSERT INTO tbl_Register (Username, Password, Name, Age) VALUES (@Username, @Password, @Name, @Age)";
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Logs;Integrated Security=True;Trust Server Certificate=True");
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                // TextBox verilerini parametrelere ekleyelim
                cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", passwordTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", ageValue); // int olarak dönüştürülmüş değer

                // Sorguyu çalıştır
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Form alanlarını temizle
                    usernameTextBox.Clear();
                    passwordTextbox.Clear();
                    nameTextBox.Clear();
                    ageTextBox.Clear();
                    usernameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Kayıt eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı güvenli şekilde kapat
                if (con != null && con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}
