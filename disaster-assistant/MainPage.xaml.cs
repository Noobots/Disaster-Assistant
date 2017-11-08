using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using login;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace disaster_assistant
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeIcon.IsSelected)
            {
                this.Frame.Navigate(typeof(MainPage), null);
            }
            else if (Disaster.IsSelected)
            {
                this.Frame.Navigate(typeof(DisMainPage), null);
            }
            else if (Login.IsSelected)
                this.Frame.Navigate(typeof(login.views.loginmain), null);
        }

      
    }
}
