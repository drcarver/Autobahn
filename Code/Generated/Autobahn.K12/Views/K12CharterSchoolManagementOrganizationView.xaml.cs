//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolManagementOrganizationView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CharterSchoolManagementOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CharterSchoolManagementOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IK12CharterSchoolManagementOrganization View Model as the data context for the view
        /// </summary>
        public K12CharterSchoolManagementOrganizationView(Interfaces.IK12CharterSchoolManagementOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}
