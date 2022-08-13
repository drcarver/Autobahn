//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSpaceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSpaceView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSpace View Model as the data context for the view
        /// </summary>
        public BuildingSpaceView(Interfaces.IBuildingSpace vm)
        {
            BindingContext  = vm;
        }
    }
}
