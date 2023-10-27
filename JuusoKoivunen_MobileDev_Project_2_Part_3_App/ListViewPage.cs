namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}
