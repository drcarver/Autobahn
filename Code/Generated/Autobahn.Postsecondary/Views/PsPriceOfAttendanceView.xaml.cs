//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSPriceOfAttendanceView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PSPriceOfAttendanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PSPriceOfAttendanceView : ContentPage
    {
        /// <summary>
        /// Inject the IPSPriceOfAttendance View Model as the data context for the view
        /// </summary>
        public PSPriceOfAttendanceView(Interfaces.IPSPriceOfAttendance vm)
        {
            BindingContext  = vm;
        }
    }
}
