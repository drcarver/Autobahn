//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffCredentialView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffCredentialView : ContentPage
    {
        /// <summary>
        /// Inject the IStaffCredential View Model as the data context for the view
        /// </summary>
        public StaffCredentialView(Interfaces.IStaffCredential vm)
        {
            BindingContext  = vm;
        }
    }
}
