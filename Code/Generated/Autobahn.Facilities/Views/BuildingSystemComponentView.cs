//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponentView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSystemComponentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSystemComponentView : ContentPage
    {
        /// <summary>
        /// Inject the BuildingSystemComponentViewModel as the data context for the view
        /// </summary>
        public BuildingSystemComponentView(BuildingSystemComponentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
