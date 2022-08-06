//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySchoolDesignView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The FacilitySchoolDesignView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacilitySchoolDesignView : ContentPage
    {
        /// <summary>
        /// Inject the FacilitySchoolDesignViewModel as the data context for the view
        /// </summary>
        public FacilitySchoolDesignView(FacilitySchoolDesignViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
