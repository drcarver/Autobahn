//**********************************************************
//* DomainName: Common Models
//* FileName:   LeaOrganizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The LeaOrganizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaOrganizationView : ContentPage
    {
        /// <summary>
        /// Inject the ILeaOrganization View Model as the data context for the view
        /// </summary>
        public LeaOrganizationView(Interfaces.ILeaOrganization vm)
        {
            BindingContext  = vm;
        }
    }
}
