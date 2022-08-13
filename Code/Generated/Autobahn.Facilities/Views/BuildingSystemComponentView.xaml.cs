//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSystemComponentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSystemComponentView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSystemComponent View Model as the data context for the view
        /// </summary>
        public BuildingSystemComponentView(Interfaces.IBuildingSystemComponent vm)
        {
            BindingContext  = vm;
        }
    }
}
