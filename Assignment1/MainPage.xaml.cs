using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Assignment1.Resources;

namespace Assignment1
{
    public partial class MainPage : PhoneApplicationPage
    {
        private bool explanationVisible = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Explanation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            explanationVisible = !explanationVisible;
            if (explanationVisible)
            {
                InfoPublic.Visibility = System.Windows.Visibility.Visible;
                InfoPrivate.Visibility = System.Windows.Visibility.Visible;
                Explanation.Text = AppResources.ExplanationHide;
            }
            else
            {
                InfoPublic.Visibility = System.Windows.Visibility.Collapsed;
                InfoPrivate.Visibility = System.Windows.Visibility.Collapsed;
                Explanation.Text = AppResources.ExplanationShow;
            }
        }

        private void Public_Checked(object sender, RoutedEventArgs e)
        {
            if (WarningPrivate != null)
            {
                WarningPrivate.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Private_Checked(object sender, RoutedEventArgs e)
        {
            if (WarningPrivate != null)
            {
                WarningPrivate.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void LightVersion_Checked(object sender, RoutedEventArgs e)
        {
            InfoLight.Visibility = System.Windows.Visibility.Visible;
        }

        private void LightVersion_Unchecked(object sender, RoutedEventArgs e)
        {
            InfoLight.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SignInStatus.Visibility = System.Windows.Visibility.Visible;
            if (Username.Text.Equals("") || Password.Password.Equals(""))
            {
                SignInStatus.Text = AppResources.SignInError;
                SignInStatus.Foreground = new SolidColorBrush(Colors.Orange);
            }
            else
            {
                SignInStatus.Text = AppResources.SignInSuccess;
                SignInStatus.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
    }
}