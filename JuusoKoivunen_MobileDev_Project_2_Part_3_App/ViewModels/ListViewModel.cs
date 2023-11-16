namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels
{
    public partial class ListViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Employee> employees = new();

        [ObservableProperty]
        private Employee employee;
        
    } 
}

