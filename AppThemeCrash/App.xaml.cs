using AppThemeCrash.ViewModels;

namespace AppThemeCrash
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            MainPage.BindingContext = Handler.MauiContext.Services.GetService<AppShellViewModel>();
        }
    }
}
