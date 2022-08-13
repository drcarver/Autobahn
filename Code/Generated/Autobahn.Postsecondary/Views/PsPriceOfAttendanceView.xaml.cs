//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsPriceOfAttendanceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsPriceOfAttendanceView : ContentPage
    {
        /// <summary>
        /// Inject the IPsPriceOfAttendance View Model as the data context for the view
        /// </summary>
        public PsPriceOfAttendanceView(Interfaces.IPsPriceOfAttendance vm)
        {
            BindingContext  = vm;
        }
    }
}
