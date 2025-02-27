using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Games_Platform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormsManager.OpenNewForm(this, new Register());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string roleInput = rolesComboBox.Text;
                string username_emailInput = usernameTextBox.Text;
                string passwordInput = passwordTextBox.Text;

                string queryLogin = $"SELECT {roleInput}ID, Username, Email, Password, RegisterDate FROM {roleInput}s " +
                    $"WHERE (Username = '{username_emailInput}' OR Email = '{username_emailInput}') AND Password = '{passwordInput}'";

                DataTable usersTable = DataBase.SQLDataSelect(queryLogin);

                if (usersTable.Rows.Count == 1)
                {
                    string userID = usersTable.Rows[0][$"{roleInput}ID"].ToString();
                    string userName = usersTable.Rows[0]["Username"].ToString();
                    string userEmail = usersTable.Rows[0]["Email"].ToString();
                    string userPassword = usersTable.Rows[0]["Password"].ToString();
                    DateTime userRegisterDate = DateTime.Parse(usersTable.Rows[0]["RegisterDate"].ToString());

                    UserInfo userInfo = new UserInfo(roleInput, userID, userName, userEmail, userPassword, userRegisterDate);
                    Form userForm = FormsManager.GetUserForm(userInfo);
                    FormsManager.OpenNewForm(this, userForm);
                }
                else
                {
                    MessageBox.Show("Incorrect login or password.", "Authorization error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
