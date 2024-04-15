using Devoir2.Services;
using Devoir2.ViewModels;
using Devoir2.Views;
namespace Devoir2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
        }

       
    }
}
