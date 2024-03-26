using CommunityToolkit.Maui.Behaviors;

namespace AppThemeCrash
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var statusBarBehavior = new StatusBarBehavior();
            statusBarBehavior.SetAppThemeColor(StatusBarBehavior.StatusBarColorProperty, Color.FromRgb(255, 0, 0), Color.FromRgb(0, 255, 0));
        }
    }
}
