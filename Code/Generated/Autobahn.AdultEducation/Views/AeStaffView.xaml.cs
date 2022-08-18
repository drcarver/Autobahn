//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffView.cs
//**********************************************************

namespace Autobahn.AdultEducation.Views
{
     /// <summary>
     /// The AeStaffView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeStaffView : ContentPage
    {
        /// <summary>
        /// Inject the IAeStaff View Model as the data context for the view
        /// </summary>
        public AeStaffView(Interfaces.IAeStaff vm)
        {
            BindingContext  = vm;
        }
    }
}
