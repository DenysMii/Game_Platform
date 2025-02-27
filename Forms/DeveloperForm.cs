using System.Data;
using System.Runtime.CompilerServices;

namespace Games_Platform
{
    public partial class DeveloperForm : Form
    {
        UserInfo developerInfo;
        Panel[] panels;
        public DeveloperForm(UserInfo userInfo)
        {
            developerInfo = userInfo;
            InitializeComponent();
            LoadBoxData();
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            panels = [getInfoPanel, addGamePanel, deleteGamePanel];

            greetingLabel.Text += developerInfo.Username;

            roleLabel.Text = "DEVELOPER";
            usernameLabel.Text += developerInfo.Username;
            emailLabel.Text += developerInfo.Email;
            registerDateLabel.Text += developerInfo.RegisterDate.ToString("dd.MM.yyyy");
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(0, panels);
        }
        private void addGameButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(1, panels);
        }
        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(2, panels);
        }
        private void agAddButton_Click(object sender, EventArgs e)
        {
            string queryPlatformID = $"SELECT PlatformID FROM Platforms WHERE PlatformName = '{agPlatformComboBox.Text}'";
            DataTable PlatforTable = DataBase.SQLDataSelect(queryPlatformID);

            string DevID = developerInfo.ID;
            string PlatformID = PlatforTable.Rows[0]["PlatformID"].ToString();
            string Title = agTitleTextBox.Text;
            string Description = agDescTextBox.Text;
            string Genre = agGenreTextBox.Text;

            string queryAddGame = "INSERT INTO Games (DeveloperID, PlatformID, Title, Description, Genre) " +
                $"VALUES ({DevID}, {PlatformID}, '{Title}', '{Description}', '{Genre}')";

            DataBase.SQLDataInsert(queryAddGame, "Game");
            LoadBoxData();

            agTitleTextBox.ResetText();
            agPlatformComboBox.ResetText();
            agDescTextBox.ResetText();
            agGenreTextBox.ResetText();
        }

        private void dgDeleteButton_Click(object sender, EventArgs e)
        {
            string DevID = developerInfo.ID;
            string Title = dgTitleComboBox.Text;
            string queryDeleteGame = $"DELETE FROM Games WHERE Title = '{Title}' AND DeveloperID = {DevID}";

            DataBase.SQLDataDelete(queryDeleteGame, Title);
            LoadBoxData();
            
            dgTitleComboBox.ResetText();
        }

        private void LoadBoxData()
        {
            string queryPlatforms = "SELECT PlatformName FROM Platforms";

            string queryCreatedGames = "SELECT GameID, Title FROM Games " +
                $"WHERE DeveloperID = {developerInfo.ID}";

            DataTable platforms = DataBase.SQLDataSelect(queryPlatforms);
            DataTable createdGames = DataBase.SQLDataSelect(queryCreatedGames);

            FormsManager.SetComboBoxValues(agPlatformComboBox, platforms, "PlatformName");
            FormsManager.SetComboBoxValues(dgTitleComboBox, createdGames, "Title");
        }
    }

}
