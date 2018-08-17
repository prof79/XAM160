// MainPage.xaml.cs

namespace People
{
    using System;
    using Xamarin.Forms;
    using Utility;

    public partial class MainPage : ContentPage
    {
        #region Fields

        private readonly IFileAccessHelper _fileAccessHelper;
        private readonly string _dbFileName = "people.db";

        #endregion

        public MainPage()
        {
            _fileAccessHelper =
                DependencyService.Get<IFileAccessHelper>();

            InitializeComponent();

            Text = _fileAccessHelper.GetLocalFilePath(_dbFileName);
        }

        #region Properties

        public string Text
        {
            get => textLabel.Text;

            set => textLabel.Text = value;
        }

        #endregion
    }
}
