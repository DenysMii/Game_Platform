using System.Data;
using System.Windows.Forms;

namespace Games_Platform
{
    static class FormsManager
    {

        public static void OpenNewForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.Closed += (s, args) => currentForm.Close();
            newForm.Show();
        }

        public static Form GetUserForm(UserInfo userInfo)
        {
            switch (userInfo.Role)
            {
                case "Gamer":
                    return new GamerForm(userInfo);
                case "Developer":
                    return new DeveloperForm(userInfo);
                case "Admin":
                    return new AdminForm(userInfo);
            }
            return null;
        }

        public static void EnablePanel(int index, Panel[] panels)
        {
            for(int i = 0; i < panels.Length; i++)
            {
                if(i != index)
                {
                    panels[i].Visible = false;
                    panels[i].Enabled = false;
                }
            }
            panels[index].Visible = true;
            panels[index].Enabled = true;
        }

        public static void SetComboBoxValues(ComboBox comboBox, DataTable table, string display)
        {
            comboBox.DisplayMember = display;
            comboBox.DataSource = table;
        }
    }
}
