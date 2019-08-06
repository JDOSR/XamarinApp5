using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp4
{
    public partial class MainPage : ContentPage
    {
		MainPageViewModel mvm;
        public MainPage()
        {
			mvm = new MainPageViewModel();
			BindingContext = mvm;

            InitializeComponent();
        }
    }
}
