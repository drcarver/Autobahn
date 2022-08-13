//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilitySchoolDesignView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilitySchoolDesignView : ContentPage
    {
        /// <summary>
        /// Inject the IFacilitySchoolDesign View Model as the data context for the view
        /// </summary>
        public FacilitySchoolDesignView(Interfaces.IFacilitySchoolDesign vm)
        {
            BindingContext  = vm;
        }
    }
}
