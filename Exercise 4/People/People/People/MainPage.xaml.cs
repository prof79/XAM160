// MainPage.xaml.cs

namespace People
{
    using System;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        #region Constructor

        public MainPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        public async void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            await App.PersonRepo.AddNewPersonAsync(newPerson.Text);

            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            peopleList.ItemsSource =
                await App.PersonRepo.GetAllPeopleAsync();
        }

        #endregion
    }
}
