using System;
using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessageLabel.Text = "Autor: Daria Nedzelska";
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageLabel.Text = "Nieprawidłowy adres e-mail";
            }
            else if (password != confirmPassword)
            {
                MessageLabel.Text = "Hasła się różnią";
            }
            else
            {
                MessageLabel.Text = $"Witaj {email}";
            }
        }
    }
}
