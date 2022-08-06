//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemCategoryView.cs
//**********************************************************

using Autobahn.Facilities.ViewModels;

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSystemCategoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSystemCategoryView : ContentPage
    {
        /// <summary>
        /// Inject the BuildingSystemCategoryViewModel as the data context for the view
        /// </summary>
        public BuildingSystemCategoryView(BuildingSystemCategoryViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
