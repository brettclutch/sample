using Rpf.Xamarin.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Rpf.Xamarin
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
#pragma warning disable CS0618 // Type or member is obsolete
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
#pragma warning restore CS0618 // Type or member is obsolete
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
#pragma warning disable CS0618 // Type or member is obsolete
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
#pragma warning restore CS0618 // Type or member is obsolete
                    },
                }
            };
        }
	}
}
