using Xamarin.Forms;
using AwesomeApp.ViewModels;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new VMMainPage();
            NavigationPage.SetHasNavigationBar(this, true);
            this.Title = "Xamarin buttons";
        }
        
    }
}
