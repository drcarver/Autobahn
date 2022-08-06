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
        /// Inject the BuildingSystemComponentServiceViewModel as the data context for the view
        /// </summary>
        public BuildingSystemComponentServiceView(BuildingSystemComponentServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
