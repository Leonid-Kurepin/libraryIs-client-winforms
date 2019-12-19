using System.Windows.Forms;

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
