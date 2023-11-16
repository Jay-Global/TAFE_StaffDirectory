namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels
{
    public partial class InsertViewModel : BaseViewModel
    {
        //Database service to perform CRUD operations
        private DatabaseHelper _databaseServiceSQL;

        private List<Employee> _details;


        // Event handler for adding a new student
        
        private async void AddContact_Clicked(object sender, EventArgs e)
        {
            var newEmployee = new Employee();
            //{
            //    FirstName = FirsNameEntry.Text,
            //    LastName = FamilyNameEntry.Text,
            //    Department = StudentNumberEntry.Text,
            //    Role = EnrollmentDatePicker.Date,
            //    MobileNumber = ,
            //    Email = 
            //};

            //SQLite Version
            await _databaseServiceSQL.AddStudentAsync(newEmployee);

            //CSV Version
            //await _databaseServiceCSV.AddStudentAsync(newStudent);

            //Un-comment for pop-ups/troubleshooting
            //await DisplayAlert("Add Student","You Added a student","Ok");

            //GivenNameEntry.Text = FamilyNameEntry.Text = StudentNumberEntry.Text = string.Empty;
            //LoadStudentsAsync();
            //Add UI refresh command here
        }



    }
}



