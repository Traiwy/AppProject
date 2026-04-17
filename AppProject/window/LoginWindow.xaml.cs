using Microsoft.UI.Xaml;

namespace AppProject
{
    public sealed partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }


        public void Login_Click(object sender, RoutedEventArgs e)
        {
            string login = UsernameBox.Text;
            string password = PasswordBox.Password;

            // 2. Проверяем данные
            if (login == "123" && password == "123")
            {
                HomeWindow hw = new HomeWindow();
                hw.Activate();
                
                this.Close();
            }
            else
            {
            }
        }
    }
}