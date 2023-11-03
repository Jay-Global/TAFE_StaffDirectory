using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.Model
{
    public class ContactCard
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Department", GroupName = "Details")]
        public string Department { get; set; }

        [Display(Name = "Role", GroupName = "Details")]
        public string Role { get; set; }

        [Display(Name = "Mobile Number", GroupName = "Details")]
        public string MobileNumber { get; set; }

        [Display(Name = "Email", GroupName = "Details")]
        public string Email { get; set; }
    }
}

[JsonSerializable(typeof(List<ContactCard>))]
internal sealed partial class ContactCardContext : JsonSerializerContext
{

}