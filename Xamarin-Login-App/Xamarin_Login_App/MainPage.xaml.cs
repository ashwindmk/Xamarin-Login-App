using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Login_App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void LoginButtonClicked(Object sender, EventArgs e)
        {
            UserDataLabel.Text = "Please login";

            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if ( string.Equals(username, "ashwin", StringComparison.CurrentCultureIgnoreCase) && string.Equals(password, "pass123")
                || string.Equals(username, "bob", StringComparison.CurrentCultureIgnoreCase) && string.Equals(password, "qwerty")
                || string.Equals(username, "carrie", StringComparison.CurrentCultureIgnoreCase) && string.Equals(password, "password")
            )
            {
                UserDataLabel.Text = "Last logged in as " + username;

                // Go to home page
                await Navigation.PushAsync(new HomePage(username));
            }
            else
            {
                UserDataLabel.Text = "Invalid username or password";
            }
            
        }
	}
}
