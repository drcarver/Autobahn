//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSpaceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSpaceView : ContentPage
    {
        /// <summary>
        /// Inject the BuildingSpaceViewModel as the data context for the view
        /// </summary>
        public BuildingSpaceView(BuildingSpaceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
