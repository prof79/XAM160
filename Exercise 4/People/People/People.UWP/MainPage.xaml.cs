// MainPage.xaml.cs

namespace People.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new People.App());
        }
    }
}
