using Microsoft.Data.SqlClient;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registernowButton_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Logs;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Register",con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == usernameTextbox.Text && dr[1].ToString() == passwordTextbox.Text)
                    {
                        MessageBox.Show("Login is succesful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usernameTextbox.ResetText();
                        passwordTextbox.ResetText();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Login is unsucessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTextbox.ResetText();
                        passwordTextbox.ResetText();
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
    }
}
