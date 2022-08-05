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
        /// Inject the AeStaffViewModel as the data context for the view
        /// </summary>
        public AeStaffView(AeStaffViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
