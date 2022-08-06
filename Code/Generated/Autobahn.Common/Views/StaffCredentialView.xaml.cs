//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCredentialView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the StaffCredentialViewModel as the data context for the view
        /// </summary>
        public StaffCredentialView(StaffCredentialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
