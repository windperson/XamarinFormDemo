using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinAppDemo
{
    public class App : Application
    {
        private Label label;
        private Button btn;

        public App()
        {

            label = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!"
            };

            btn = new Button
            {
                Text = "Click",
                HorizontalOptions = LayoutOptions.Center
            };
            btn.Clicked += Btn_Clicked;
            


            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        label,
                        btn          
                    }
                }
            };
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            if(label.Text.Length > 0)
            {
                label.Text = "";
            }
            else
            {
                label.Text = "Clicked!";
            }
        }

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
    }
}
