//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySiteView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilitySiteView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilitySiteView : ContentPage
    {
        /// <summary>
        /// Inject the FacilitySiteViewModel as the data context for the view
        /// </summary>
        public FacilitySiteView(FacilitySiteViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
