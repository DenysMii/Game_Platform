using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Games_Platform
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormsManager.OpenNewForm(this, new Login());
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string role = rolesComboBox.Text;
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                string queryCheckUser = $"SELECT COUNT(*) FROM {role}s WHERE Username = '{username}' OR Email = '{email}'";
                DataTable result = DataBase.SQLDataSelect(queryCheckUser);

                if (Convert.ToInt32(result.Rows[0][0]) > 0)
                {
                    MessageBox.Show("A user with this name or email already exists.", "Registration error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string queryRegister = $"INSERT INTO {role}s (Username, Email, Password) " +
                $"VALUES ('{username}', '{email}', '{password}')";

                    DataBase.SQLDataInsert(queryRegister, role);
                    FormsManager.OpenNewForm(this, new Login());
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error accessing the database. Please try again later.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
