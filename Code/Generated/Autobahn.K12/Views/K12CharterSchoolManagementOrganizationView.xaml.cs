//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolManagementOrganizationView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12CharterSchoolManagementOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12CharterSchoolManagementOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the IK12CharterSchoolManagementOrganizationViewModel as the data context for the view
        /// </summary>
        public K12CharterSchoolManagementOrganizationView(IK12CharterSchoolManagementOrganizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
