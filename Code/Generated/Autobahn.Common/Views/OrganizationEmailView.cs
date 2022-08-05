//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmailView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The OrganizationEmailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationEmailView : ContentPage
    {
        /// <summary>
        /// Inject the OrganizationEmailViewModel as the data context for the view
        /// </summary>
        public OrganizationEmailView(OrganizationEmailViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
