// MainPage.xaml.cs

namespace People
{
    using People.Models;
    using System;
    using Xamarin.Forms;
    using System.Collections.Generic;
    using Utility;

    public partial class MainPage : ContentPage
    {
        #region Constructor

        public MainPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.PersonRepo.AddNewPerson(newPerson.Text);

            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            var people = App.PersonRepo.GetAllPeople();

            peopleList.ItemsSource = people;
        }

        #endregion
    }
}
