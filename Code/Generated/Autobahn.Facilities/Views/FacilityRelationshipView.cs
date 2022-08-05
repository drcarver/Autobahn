//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityRelationshipView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the FacilityRelationshipViewModel as the data context for the view
        /// </summary>
        public FacilityRelationshipView(FacilityRelationshipViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
