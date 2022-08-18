//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryView.cs
//**********************************************************

namespace Autobahn.Facilities.Views
{
     /// <summary>
     /// The BuildingSystemCategoryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingSystemCategoryView : ContentPage
    {
        /// <summary>
        /// Inject the IBuildingSystemCategory View Model as the data context for the view
        /// </summary>
        public BuildingSystemCategoryView(Interfaces.IBuildingSystemCategory vm)
        {
            BindingContext  = vm;
        }
    }
}
