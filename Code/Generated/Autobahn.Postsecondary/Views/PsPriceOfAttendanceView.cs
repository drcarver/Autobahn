//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsPriceOfAttendanceView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsPriceOfAttendanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsPriceOfAttendanceView : ContentPage
    {
        /// <summary>
        /// Inject the PsPriceOfAttendanceViewModel as the data context for the view
        /// </summary>
        public PsPriceOfAttendanceView(PsPriceOfAttendanceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
