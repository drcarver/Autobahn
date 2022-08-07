//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponentServiceView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSystemComponentServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSystemComponentServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSystemComponentServiceViewModel as the data context for the view
        /// </summary>
        public BuildingSystemComponentServiceView(IBuildingSystemComponentServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
