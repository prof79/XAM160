﻿// MainPage.xaml.cs

namespace People
{
    using System;
    using SQLite;
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

            using (var conn = new SQLiteConnection(_fileAccessHelper.GetLocalFilePath(_dbFileName)))
            {
                // If we didn't throw up to this point, project configuration seems to be ok.
            }
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