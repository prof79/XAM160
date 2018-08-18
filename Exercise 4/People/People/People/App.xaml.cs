// App.xaml.cs

using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace People
{
    using System;
    using People.Utility;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region Fields

        private static readonly IFileAccessHelper _fileAccessHelper;

        private static readonly string _dbName = "people.db";
        private static readonly string _fullDbPath;

        private static PersonRepository _personRepository;

        #endregion

        #region Constructors

        static App()
        {
            _fileAccessHelper =
                DependencyService.Get<IFileAccessHelper>();

            _fullDbPath =
                _fileAccessHelper.GetDatabaseFilePath(_dbName);
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        #endregion

        #region Properties

        public static PersonRepository PersonRepo
            => _personRepository
                ?? (_personRepository =
                        new PersonRepository(_fullDbPath));

        #endregion

        #region App Lifecycle

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion
    }
}
