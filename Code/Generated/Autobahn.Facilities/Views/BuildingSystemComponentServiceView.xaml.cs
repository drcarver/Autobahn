//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSystemComponentServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSystemComponentServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSystemComponentService View Model as the data context for the view
        /// </summary>
        public BuildingSystemComponentServiceView(Interfaces.IBuildingSystemComponentService vm)
        {
            BindingContext  = vm;
        }
    }
}
