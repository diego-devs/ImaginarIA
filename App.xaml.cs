using Microsoft.Extensions.DependencyInjection;

namespace ImaginarIA;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        
    }
}
