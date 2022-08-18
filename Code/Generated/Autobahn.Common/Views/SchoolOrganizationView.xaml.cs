//**********************************************************
//* DomainName: Common Models
//* FileName:   SchoolOrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The SchoolOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchoolOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the ISchoolOrganization View Model as the data context for the view
        /// </summary>
        public SchoolOrganizationView(Interfaces.ISchoolOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}
