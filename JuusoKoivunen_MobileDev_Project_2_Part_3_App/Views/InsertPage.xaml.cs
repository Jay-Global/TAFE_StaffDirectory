using Syncfusion.Maui.DataForm;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class InsertPage : ContentPage
{
	public InsertPage()
	{
        InitializeComponent();
		BindingContext = new InsertViewModel();
	}

    private void dataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "FirstName" || e.DataFormItem.FieldName == "LastName" ||
                e.DataFormItem.FieldName == "MiddleName")
            {
                e.DataFormItem.GroupName = "Name";
            }
        }
        if (e.DataFormGroupItem != null)
        {
            if (e.DataFormGroupItem.Name == "Name")
            {
                e.DataFormGroupItem.HeaderBackground = Color.FromHex("#D7DDED");
                e.DataFormGroupItem.HeaderTextStyle = new DataFormTextStyle
                {
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold
                };
            }
        }

    }
}
