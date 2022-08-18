//**********************************************************
//* DomainName: Common Models
//* FileName:   Parent_FacilityView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The Parent_FacilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Parent_FacilityView : ContentPage
    {
        /// <summary>
        /// Inject the IParent_Facility View Model as the data context for the view
        /// </summary>
        public Parent_FacilityView(Interfaces.IParent_Facility vm)
        {
            BindingContext  = vm;
        }
    }
}
