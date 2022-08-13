//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilitySiteView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilitySiteView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilitySite View Model as the data context for the view
        /// </summary>
        public FacilitySiteView(Interfaces.IFacilitySite vm)
        {
            BindingContext  = vm;
        }
    }
}
