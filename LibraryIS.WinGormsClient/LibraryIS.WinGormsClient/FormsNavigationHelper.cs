using System.Windows.Forms;
using MainMenu = LibraryIS.WinFormsClient.Forms.MainMenu;

namespace LibraryIS.WinFormsClient
{
    public class FormsNavigationHelper
    {
        public static void GoToMainMenu(Form currentForm)
        {
            var mainMenuForm = (MainMenu)currentForm.Tag;
            mainMenuForm.Show();
           currentForm.Hide();
        }
    }
}
