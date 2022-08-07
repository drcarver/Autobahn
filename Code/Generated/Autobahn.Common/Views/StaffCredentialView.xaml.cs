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
        /// Inject the IStaffCredentialViewModel as the data context for the view
        /// </summary>
        public StaffCredentialView(IStaffCredentialViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
