//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIdentifierView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationIdentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationIdentifierView : ContentPage
    {
        /// <summary>
        /// Inject the IOrganizationIdentifierViewModel as the data context for the view
        /// </summary>
        public OrganizationIdentifierView(IOrganizationIdentifierViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
