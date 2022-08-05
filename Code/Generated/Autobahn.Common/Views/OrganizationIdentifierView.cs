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
        /// Inject the OrganizationIdentifierViewModel as the data context for the view
        /// </summary>
        public OrganizationIdentifierView(OrganizationIdentifierViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
