//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCompensationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The StaffCompensationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffCompensationView : ContentPage
    {
        /// <summary>
        /// Inject the StaffCompensationViewModel as the data context for the view
        /// </summary>
        public StaffCompensationView(StaffCompensationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
