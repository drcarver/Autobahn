//**********************************************************
//* DomainName: Common Models
//* FileName:   School_OrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The School_OrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class School_OrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the ISchool_Organization View Model as the data context for the view
        /// </summary>
        public School_OrganizationView(Interfaces.ISchool_Organization vm)
        {
            BindingContext  = vm;
        }
    }
}
