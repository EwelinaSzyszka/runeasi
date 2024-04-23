using runeasi_mobile.Views;

namespace runeasi_mobile;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
