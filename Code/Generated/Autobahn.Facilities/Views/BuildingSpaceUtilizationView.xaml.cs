//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceUtilizationView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSpaceUtilizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSpaceUtilizationView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSpaceUtilizationViewModel as the data context for the view
        /// </summary>
        public BuildingSpaceUtilizationView(IBuildingSpaceUtilizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
