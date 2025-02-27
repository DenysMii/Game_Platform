using System.Data;
namespace Games_Platform
{
    public partial class AdminForm : Form
    {
        UserInfo adminInfo;
        Panel[] panels;

        public AdminForm(UserInfo userInfo)
        {
            adminInfo = userInfo;
            InitializeComponent();
            LoadBoxData();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            panels = [getInfoPanel, addAdminPanel, addPlatformPanel, deletePlatformPanel];
            greetingLabel.Text += adminInfo.Username;

            roleLabel.Text = "ADMIN";
            usernameLabel.Text += adminInfo.Username;
            emailLabel.Text += adminInfo.Email;
            registerDateLabel.Text += adminInfo.RegisterDate.ToString("dd.MM.yyyy");
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(0, panels);
        }
        private void addAdminButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(1, panels);
        }
        private void addPlatformButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(2, panels);
        }
        private void deletePlatformButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(3, panels);
        }
        private void aaAddButton_Click(object sender, EventArgs e)
        {
            string Username = aaUsernameTextBox.Text;
            string Email = aaEmailTextBox.Text;
            string Password = aaPasswordTextBox.Text;

            string queryAddAdmin = "INSERT INTO Admins (Username, Email, Password) " +
                $"VALUES ('{Username}', '{Email}', '{Password}')";

            DataBase.SQLDataInsert(queryAddAdmin, "Admin");

            aaUsernameTextBox.ResetText();
            aaEmailTextBox.ResetText();
            aaPasswordTextBox.ResetText();
        }

        private void apAddButton_Click(object sender, EventArgs e)
        {
            string Name = apNameTextBox.Text;
            string Manufacturer = apManufTextBox.Text;

            string queryAddAdmin = "INSERT INTO Platforms (PlatformName, Manufacturer) " +
                $"VALUES ('{Name}', '{Manufacturer}')";
            DataBase.SQLDataInsert(queryAddAdmin, "Platform");
            LoadBoxData();

            apNameTextBox.ResetText();
            apManufTextBox.ResetText();
        }

        private void dpDeleteButton_Click(object sender, EventArgs e)
        {
            string Name = dpNameComboBox.Text;
            string queryDeleteGame = $"DELETE FROM Platforms WHERE PlatformName = '{Name}'";
            DataBase.SQLDataDelete(queryDeleteGame, Name);
            LoadBoxData();

            dpNameComboBox.ResetText();
        }

        private void LoadBoxData()
        {
            string queryPlatforms = "SELECT PlatformName FROM Platforms";
            DataTable platforms = DataBase.SQLDataSelect(queryPlatforms);
            FormsManager.SetComboBoxValues(dpNameComboBox, platforms, "PlatformName");
        }
    }
}
