using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW_LocalDB_XamarainApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) &&
                !string.IsNullOrWhiteSpace(ageEntry.Text) &&
                !string.IsNullOrWhiteSpace(cgpaEntry.Text))
                {
                await App.Database.SavePersonAsync(new Student
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text),
                    CGPA = int.Parse(cgpaEntry.Text)
                });

                nameEntry.Text = ageEntry.Text = cgpaEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
