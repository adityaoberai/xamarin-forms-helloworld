using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void click_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You have clicked {count} times!";
        }
    }
}
