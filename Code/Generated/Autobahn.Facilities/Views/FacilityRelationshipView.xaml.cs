//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilityRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilityRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilityRelationship View Model as the data context for the view
        /// </summary>
        public FacilityRelationshipView(Interfaces.IFacilityRelationship vm)
        {
            BindingContext  = vm;
        }
    }
}
