﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class MainViewModel : ObservableObject
{
	public MainViewModel()
	{
		
	}

	[RelayCommand]

	Task Navigate() => Shell.Current.GoToAsync(nameof(ListViewPage));
}
 