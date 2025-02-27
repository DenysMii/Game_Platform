using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Platform
{
    public partial class GamerForm : Form
    {
        UserInfo gamerInfo;
        Panel[] panels;

        public GamerForm(UserInfo userInfo)
        {
            gamerInfo = userInfo;
            InitializeComponent();
            LoadBoxData();
        }

        private void GamerForm_Load(object sender, EventArgs e)
        {
            panels = [getInfoPanel, addGamePanel, deleteGamePanel,
                addReviewPanel];

            greetingLabel.Text += gamerInfo.Username;

            roleLabel.Text = "GAMER";
            usernameLabel.Text += gamerInfo.Username;
            emailLabel.Text += gamerInfo.Email;
            registerDateLabel.Text += gamerInfo.RegisterDate.ToString("dd.MM.yyyy");
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
        private void addReviewButton_Click(object sender, EventArgs e)
        {
            FormsManager.EnablePanel(3, panels);
        }
        private void agAddButton_Click(object sender, EventArgs e)
        {
            string Title = agTitleComboBox.Text;
            string queryGameID = $"SELECT GameID FROM Games WHERE Title = '{Title}'";
            DataTable gameTable = DataBase.SQLDataSelect(queryGameID);

            string GamerID = gamerInfo.ID;
            string GameID = gameTable.Rows[0]["GameID"].ToString();

            string queryAddGame = "INSERT INTO Gamers_Games (GamerID, GameID) " +
                $"VALUES ({GamerID}, {GameID})";

            DataBase.SQLDataInsert(queryAddGame, "Game");
            LoadBoxData();

            agTitleComboBox.ResetText();
        }
        private void dgDeleteButton_Click(object sender, EventArgs e)
        {
            string Title = dgTitleComboBox.Text;
            string queryGameID = $"SELECT GameID FROM Games WHERE Title = '{Title}'";
            DataTable gameTable = DataBase.SQLDataSelect(queryGameID);

            string GamerID = gamerInfo.ID;
            string GameID = gameTable.Rows[0]["GameID"].ToString();
            string queryDeleteGame = $"DELETE FROM Gamers_Games WHERE GamerID = {GamerID} AND GameID = {GameID}";

            DataBase.SQLDataDelete(queryDeleteGame, Title);
            LoadBoxData();

            dgTitleComboBox.ResetText();
        }
        private void arAddButton_Click(object sender, EventArgs e)
        {
            string Title = arTitleComboBox.Text;
            string queryGameID = $"SELECT GameID FROM Games WHERE Title = '{Title}'";
            DataTable gameTable = DataBase.SQLDataSelect(queryGameID);

            string GameID = gameTable.Rows[0]["GameID"].ToString();
            string GamerID = gamerInfo.ID;
            byte Rating = (byte)arRatingNum.Value;
            string Review = arReviewTextBox.Text;

            string queryAddReview = "INSERT INTO Reviews (GameID, GamerID, Rating, ReviewText) " +
                $"VALUES ({GameID}, {GamerID}, {Rating}, '{Review}')";

            DataBase.SQLDataInsert(queryAddReview, "Review");
            LoadBoxData();

            arTitleComboBox.ResetText();
            arRatingNum.ResetText();
            arReviewTextBox.ResetText();
        }
        private void LoadBoxData()
        {
            string queryNewGames = "SELECT G.Title FROM Games G WHERE G.GameID NOT IN " +
                $"(SELECT GG.GameID FROM Gamers_Games GG WHERE GG.GamerID = {gamerInfo.ID})";

            string queryOwnedGames = "SELECT G.Title FROM Games G WHERE G.GameID IN " +
                $"(SELECT GG.GameID FROM Gamers_Games GG WHERE GG.GamerID = {gamerInfo.ID})";

            string queryNotRatedGames = "SELECT G.Title FROM Games G WHERE G.GameID NOT IN " +
                $"(SELECT R.GameID FROM Reviews R WHERE R.GamerID = {gamerInfo.ID})";

            DataTable newGames = DataBase.SQLDataSelect(queryNewGames);
            DataTable ownedGames = DataBase.SQLDataSelect(queryOwnedGames);
            DataTable notRatedGames = DataBase.SQLDataSelect(queryNotRatedGames);

            FormsManager.SetComboBoxValues(agTitleComboBox, newGames, "Title");
            FormsManager.SetComboBoxValues(dgTitleComboBox, ownedGames, "Title");
            FormsManager.SetComboBoxValues(arTitleComboBox, notRatedGames, "Title");
        }
    }
}
