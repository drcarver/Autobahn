//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSpaceUtilizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSpaceUtilizationView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSpaceUtilization View Model as the data context for the view
        /// </summary>
        public BuildingSpaceUtilizationView(Interfaces.IBuildingSpaceUtilization vm)
        {
            BindingContext  = vm;
        }
    }
}
