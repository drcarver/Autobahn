//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStaffView.cs
//**********************************************************

using Autobahn.AdultEducation.ViewModels;

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeStaffView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeStaffView : ContentPage
    {
        /// <summary>
        /// Inject the IAeStaffViewModel as the data context for the view
        /// </summary>
        public AeStaffView(IAeStaffViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
